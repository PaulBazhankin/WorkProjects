﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExcelReader.Reader;
using static WorkProject1.ExcelHelper;
using static WorkProject1.MathHelper;
using static DecimalMath.DecimalEx;

namespace WorkProject1
{
    public partial class MainWindow : Form
    {
        bool fileOpened = false;
        delegate void InvokeDelegate();
        readonly List<decimal>[] data = new List<decimal>[4];
        public MainWindow()
        {
            InitializeComponent();
            data[0] = new List<decimal>();
            data[1] = new List<decimal>();
            data[2] = new List<decimal>();
            data[3] = new List<decimal>();
        }
        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            OpenExcelFileDialog.ShowDialog();
        }

        private void OpenExcelFileDialog_FileOK(object sender, CancelEventArgs e)
        {
            SheetTextBox.Enabled = true;
            fileOpened = true;
            CellTextBox_TextChanged(sender, e);
        }

        private void LoadCellsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); //Выключаем все кнопки и поля ввода
            CalculateBtn.Enabled = false;
            LoadCellsBtn.Enabled = false;
            LoadFileBtn.Enabled = false;
            SheetTextBox.Enabled = false;
            CellTextBox.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            Task task = Task.Run(() =>
            {
                string R = "";//Получение номера (обозначения) начального столбца и номер начальной строки
                string C = "";
                bool numbers = false;
                for (int i = 0; i < CellTextBox.Text.Length; i++)
                {
                    char sym = CellTextBox.Text.ToUpper()[i];
                    if (char.IsDigit(sym)) numbers = true;
                    if (numbers) R += sym;
                    else C += sym;
                }
                int r = int.Parse(R);
                int c = ColumnNumber(C);
                int rows = 0;
                {
                    int _r = r;
                    int _c = c;
                    while (true)
                    {
                        string //Получение значений из четырёх столбцов таблицы и преобразование их в числа. Загрузка останавливается при достижении нечислового значения
                            str1 = GetCellValue(OpenExcelFileDialog.FileName, SheetTextBox.Text, $"{ColumnLabel(_c)}{_r}"),
                            str2 = GetCellValue(OpenExcelFileDialog.FileName, SheetTextBox.Text, $"{ColumnLabel(_c + 1)}{_r}"),
                            str3 = GetCellValue(OpenExcelFileDialog.FileName, SheetTextBox.Text, $"{ColumnLabel(_c + 2)}{_r}"),
                            str4 = GetCellValue(OpenExcelFileDialog.FileName, SheetTextBox.Text, $"{ColumnLabel(_c + 3)}{_r}");
                        if (
                            !decimal.TryParse(str1, NumberStyles.Number, new CultureInfo("En-US"), out decimal dec1) ||
                            !decimal.TryParse(str2, NumberStyles.Number, new CultureInfo("En-US"), out decimal dec2) ||
                            !decimal.TryParse(str3, NumberStyles.Number, new CultureInfo("En-US"), out decimal dec3) ||
                            !decimal.TryParse(str4, NumberStyles.Number, new CultureInfo("En-US"), out decimal dec4)
                        ) break;
                        else
                        {
                            rows++;
                            try
                            {
                                Invoke(new InvokeDelegate(() => //Запись во внутреннюю таблицу и обновление счетчика
                                {
                                    IndexingLabel.Text = $"Запись. Записано {rows} строк";
                                    dataGridView1.Rows.Add(
                                        _r - r + 1,
                                        Math.Round(dec1, 2),
                                        Math.Round(dec2, 2),
                                        Math.Round(dec3, 2),
                                        Math.Round(dec4, 2)
                                    );
                                    data[0].Add(dec1);
                                    data[1].Add(dec2);
                                    data[2].Add(dec3);
                                    data[3].Add(dec4);
                                }));
                            } catch { }
                        }
                        _r++;
                    }
                }
                try
                {
                    Invoke(new InvokeDelegate(()=> {//Включение элементов управления
                        progressBar1.Style = ProgressBarStyle.Blocks;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = rows;
                        IndexingLabel.Text = $"Готово. Записано {rows} строк";
                        LoadCellsBtn.Enabled = true;
                        CalculateBtn.Enabled = true;
                        LoadFileBtn.Enabled = true;
                        SheetTextBox.Enabled = true;
                        CellTextBox.Enabled = true;
                    }));
                }
                catch { }
            });
        }

        private void CellTextBox_TextChanged(object sender, EventArgs e)
        {//Проверка адреса ячейки (Загрузка невозможна при неверном адресе
            bool numbers = false;
            if (CellTextBox.Text.Length > 0)
            {
                for (int i = 0; i < CellTextBox.Text.Length; i++)
                {
                    char sym = CellTextBox.Text.ToUpper()[i];
                    if (
                        (char.IsUpper(sym) && numbers) || 
                        (char.IsDigit(sym) && i == 0) || 
                        (!numbers && sym == '0') || 
                        (!char.IsUpper(sym)&&!char.IsNumber(sym))
                    )
                    {
                        CellErrorLabel.Text = "Неверный адрес ячейки";
                        LoadCellsBtn.Enabled = false;
                        return;
                    }
                    if (char.IsDigit(sym)) numbers = true;
                }
                if (!numbers)
                {
                    CellErrorLabel.Text = "Неверный адрес ячейки";
                    LoadCellsBtn.Enabled = false;
                    return;
                }
                CellErrorLabel.Text = "";
                LoadCellsBtn.Enabled = fileOpened;
                return;
            }
            LoadCellsBtn.Enabled = false;
        }

        private void SheetTextBox_TextChanged(object sender, EventArgs e)
        {//Проверка названия листа (Ввод ячейки невозможен при неправильном названии)
            if (GetCellValue(OpenExcelFileDialog.FileName, SheetTextBox.Text, "A1") == null) {
                SheetErrorLabel.Text = "Лист не существует в этой таблице";
                CellTextBox.Enabled = false;
                LoadCellsBtn.Enabled = false;
            }
            else {
                SheetErrorLabel.Text = "";
                CellTextBox.Enabled = true;
                CellTextBox_TextChanged(sender, e);
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {//Расчеты (aft - Корма, nose - Нос, mass - ЦМ
            decimal Xc, Yc;
            { //вычисление координат центра циркуляции Xc и Yc
                decimal
                    Xc_aft = Sum(data[0].ToArray()) / data[0].Count,
                    Yc_aft = Sum(data[1].ToArray()) / data[1].Count,
                    Xc_nose = Sum(data[2].ToArray()) / data[2].Count,
                    Yc_nose = Sum(data[3].ToArray()) / data[3].Count;
                Xc = (Xc_aft + Xc_nose) / 2;
                Yc = (Yc_aft + Yc_nose) / 2;
            }
            decimal[] //вычисление мгновенных радиусов циркуляции (по стр.206)
                DX_aft = Array.ConvertAll(data[0].ToArray(), delegate (decimal input) { return input - Xc; }),
                DY_aft = Array.ConvertAll(data[1].ToArray(), delegate (decimal input) { return input - Yc; }),
                DX_nose = Array.ConvertAll(data[2].ToArray(), delegate (decimal input) { return input - Xc; }), 
                DY_nose = Array.ConvertAll(data[3].ToArray(), delegate (decimal input) { return input - Yc; }),
                R_aft = new decimal[DX_aft.Length], R_nose = new decimal[DX_nose.Length], R_mass = new decimal[R_nose.Length];
            decimal L;
            Form2 getGPSLength = new Form2();
            DialogResult result = getGPSLength.ShowDialog(); //Запрос расстояния между датчиками GPS судна
            if (result == DialogResult.OK)
            {
                L = getGPSLength.Out;
            }
            else
            {
                MessageBox.Show("Ввод данных отменён. Расчет прерван", "Ошибка", default, icon: MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < data[0].Count; i++)
            {
                R_aft[i] = Sqrt(Pow(DX_aft[i], 2) + Pow(DY_aft[i], 2));
                R_nose[i] = Sqrt(Pow(DX_nose[i], 2) + Pow(DY_nose[i], 2));
                R_mass[i] = 0.5m * Sqrt(2 * Pow(R_aft[i], 2) + 2 * Pow(R_nose[i],2)-Pow(L,2));
            }
            decimal[] alpha_aft = new decimal[R_aft.Length], alpha_mass = new decimal[R_nose.Length]; // вычисление Углов дрейфа
            for(int i = 0; i < alpha_aft.Length; i++)
            {
                alpha_aft[i] = (Pi / 2) - ACos((Pow(R_aft[i], 2) - Pow(R_mass[i], 2) + 0.25m * Pow(L, 2)) / (2 * R_aft[i] * L));
                alpha_mass[i] = (Pi / 2) - ACos((Pow(R_mass[i], 2) - Pow(R_nose[i], 2) + 0.25m * Pow(L, 2)) / (2 * R_mass[i] * L));
                alpha_aft[i] *= 180 / Pi;
                alpha_mass[i] *= 180 / Pi;
            }
            decimal r_aft, r_mass, angle_aft, angle_mass, m_r_aft, m_r_mass, m_a_aft, m_a_mass;
            D_aft.Text = ((r_aft = Sum(R_aft) / R_aft.Length) * 2).ToString("F2", new CultureInfo("Ru-Ru"));
            D_mass.Text = ((r_mass = Sum(R_mass) / R_mass.Length) * 2).ToString("F2", new CultureInfo("Ru-Ru"));
            a_aft.Text = ((angle_aft = Sum(alpha_aft) / alpha_aft.Length) * 2).ToString("F2", new CultureInfo("Ru-Ru"));
            a_mass.Text = ((angle_mass = Sum(alpha_mass) / alpha_mass.Length) * 2).ToString("F2", new CultureInfo("Ru-Ru"));
            decimal[] mi_r_aft, mi_r_mass, mi_a_aft, mi_a_mass;//вычисление средней квадратической погрешности
            mi_r_aft = new decimal[data[0].Count]; mi_r_mass = new decimal[data[1].Count]; mi_a_aft = new decimal[data[2].Count]; mi_a_mass = new decimal[data[3].Count];
            for (int i = 0; i < data[0].Count; i++)
            {
                mi_r_aft[i] = Pow(r_aft - R_aft[i], 2);
                mi_r_mass[i] = Pow(r_mass - R_mass[i], 2);
                mi_a_aft[i] = Pow(angle_aft - alpha_aft[i], 2);
                mi_a_mass[i] = Pow(angle_mass - alpha_mass[i], 2);
            }
            m_r_aft = Sqrt(Sum(mi_r_aft) / mi_r_aft.Length);
            m_r_mass = Sqrt(Sum(mi_r_mass) / mi_r_mass.Length);
            m_a_aft = Sqrt(Sum(mi_a_aft) / mi_a_aft.Length);
            m_a_mass = Sqrt(Sum(mi_a_mass) / mi_a_mass.Length);
            m_d_aft.Text = (m_r_aft / Sqrt(R_aft.Length)).ToString("F2", new CultureInfo("Ru-RU"));
            m_d_mass.Text = (m_r_mass / Sqrt(R_mass.Length)).ToString("F2", new CultureInfo("Ru-RU"));
            m_an_aft.Text = (m_a_aft / Sqrt(alpha_aft.Length)).ToString("F2", new CultureInfo("Ru-RU"));
            m_an_mass.Text = (m_a_mass / Sqrt(alpha_mass.Length)).ToString("F2", new CultureInfo("Ru-RU"));
        }

        private void CopyLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText((sender as LinkLabel).Text);
        }
    }
}
