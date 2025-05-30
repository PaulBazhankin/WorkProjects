﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WorkProject1.ExcelHelper;
using static WorkProject1.MathHelper;
using static DecimalMath.DecimalEx;
using ExcelReader;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace WorkProject1
{
    public partial class MainWindow : Form
    {
        static string versionStr = "7";
        static Version currentV = new Version("Prj1."+versionStr);

        Reader reader;
        bool fileOpened = false;
        delegate void InvokeDelegate();
        delegate string StrDelegate(int row, int column);
        readonly List<decimal>[] data = new List<decimal>[4];
        readonly List<decimal>[] data2 = new List<decimal>[4];
        decimal Xc, Yc, r_aft, r_mass;
        CultureInfo cult = new CultureInfo("Ru-RU");
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            OpenExcelFileDialog.ShowDialog();
        }

        private decimal ResizeDecimal(decimal value, decimal nativeFactor, decimal resultingFactor)
        {
            return (value / nativeFactor) * resultingFactor;
        }

        private void DrawVesselPath() //Отрисовка циркуляции
        {
            Bitmap bmp = new Bitmap(DiagramField.Size.Width, DiagramField.Size.Height);
            Graphics gr = Graphics.FromImage(bmp);
            decimal
                x_min = Math.Min(data[0].Min(), data[2].Min()),
                y_min = Math.Min(data[1].Min(), data[3].Min()),
                x_max = Math.Max(data[0].Max(), data[2].Max()) - x_min + 40,
                y_max = Math.Max(data[1].Max(), data[3].Max()) - y_min + 40,
                n_factor, factor;
            if(DiagramField.Width > DiagramField.Height)
            {
                decimal
                    shape = y_max / x_max,
                    w_shape = (decimal)DiagramField.Height / DiagramField.Width;
                if(w_shape > shape)
                {
                    n_factor = x_max;
                    factor = DiagramField.Width;
                }
                else
                {
                    n_factor = y_max;
                    factor = DiagramField.Height;
                }
            }
            else
            {
                decimal
                    shape = y_max / x_max,
                    w_shape = (decimal)DiagramField.Width / DiagramField.Height;
                if (w_shape > shape)
                {
                    n_factor = y_max;
                    factor = DiagramField.Height;
                }
                else
                {
                    n_factor = x_max;
                    factor = DiagramField.Width;
                }
            }
            decimal[,] decimals = new decimal[4, data[0].Count()];
            for (int i = 0; i < decimals.GetLength(1); i++)
            {
                decimals[0, i] = ResizeDecimal(data[0][i] - x_min, n_factor, factor) + 20;
                decimals[1, i] = DiagramField.Height - ResizeDecimal(data[1][i] - y_min, n_factor, factor) - 20;
                decimals[2, i] = ResizeDecimal(data[2][i] - x_min, n_factor, factor) + 20;
                decimals[3, i] = DiagramField.Height - ResizeDecimal(data[3][i] - y_min, n_factor, factor) - 20;
            }
            int l = (Math.Min(DiagramField.Width, DiagramField.Height) / 15);
            for (int i = l/2; i < DiagramField.Width; i += l)
            {
                gr.DrawLine(Pens.Gray, i, 0, i, DiagramField.Height - 1);
            }
            for (int i = l/2; i < DiagramField.Height; i += l)
            {
                gr.DrawLine(Pens.Gray, 0, i, DiagramField.Width, i);
            }
            for (int i = 0; i < decimals.GetLength(1) - 1; i++)
            {
                gr.DrawLine(Pens.Blue, (float)decimals[0, i], (float)decimals[1, i], (float)decimals[0, i + 1], (float)decimals[1, i + 1]);
                gr.DrawLine(Pens.DarkOrange, (float)decimals[2, i], (float)decimals[3, i], (float)decimals[2, i + 1], (float)decimals[3, i + 1]);
            }
            gr.Dispose();
            DiagramField.Image = bmp;
        }

        private void OpenExcelFileDialog_FileOK(object sender, CancelEventArgs e)
        {
            SheetTextBox.Enabled = true;
            fileOpened = true;
            reader?.Dispose();
            reader = new Reader(OpenExcelFileDialog.FileName);
            SheetTextBox.Items.Clear();
            foreach (string sheet in reader.GetSheets())
            {
                SheetTextBox.Items.Add(sheet); SheetTextBox.SelectedIndex = 0;
            }
        }

        private void LoadCellsBtn_Click(object sender, EventArgs e)
        {
            DiagramField.Image = null;
            data[0] = data[0] ?? new List<decimal>();
            data[1] = data[1] ?? new List<decimal>();
            data[2] = data[2] ?? new List<decimal>();
            data[3] = data[3] ?? new List<decimal>();
            data[0].Clear();
            data[1].Clear();
            data[2].Clear();
            data[3].Clear();
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
                            str1 = (string)Invoke(new StrDelegate((int row, int column) => { return reader.GetCellValue(SheetTextBox.Text, $"{ColumnLabel(column)}{row}"); }), _r, _c),
                            str2 = (string)Invoke(new StrDelegate((int row, int column) => { return reader.GetCellValue(SheetTextBox.Text, $"{ColumnLabel(column)}{row}"); }), _r, _c + 1),
                            str3 = (string)Invoke(new StrDelegate((int row, int column) => { return reader.GetCellValue(SheetTextBox.Text, $"{ColumnLabel(column)}{row}"); }), _r, _c + 2),
                            str4 = (string)Invoke(new StrDelegate((int row, int column) => { return reader.GetCellValue(SheetTextBox.Text, $"{ColumnLabel(column)}{row}"); }), _r, _c + 3);
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
                            }
                            catch { }
                        }
                        _r++;
                    }
                }
                try
                {
                    Invoke(new InvokeDelegate(()=> {//Включение элементов управления
                        data2[0] = new List<decimal>();
                        data2[1] = new List<decimal>();
                        data2[2] = new List<decimal>();
                        data2[3] = new List<decimal>();
                        for (int i = 0; i < data[0].Count; i++)
                        {
                            data2[0].Add(data[0][i]);
                            data2[1].Add(data[1][i]);
                            data2[2].Add(data[2][i]);
                            data2[3].Add(data[3][i]);
                        }
                        progressBar1.Style = ProgressBarStyle.Blocks;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = rows;
                        IndexingLabel.Text = $"Готово. Записано {rows} строк";
                        LoadCellsBtn.Enabled = true;
                        CalculateBtn.Enabled = true;
                        LoadFileBtn.Enabled = true;
                        SheetTextBox.Enabled = true;
                        CellTextBox.Enabled = true;
                        DrawVesselPath();
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
                    string isUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    char sym = CellTextBox.Text.ToUpper()[i];
                    if (
                        (isUpper.Contains(sym) && numbers) || 
                        (char.IsDigit(sym) && i == 0) || 
                        (!numbers && sym == '0') || 
                        (!isUpper.Contains(sym)&&!char.IsNumber(sym))
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
            if (reader.GetCellValue(SheetTextBox.Text, "A1") == null) {
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
            Drift_ValueChanged(sender, e);
            decimal GNSS_len = 0;
            {
                for(int i = 0; i < data[0].Count; i++)
                {
                    GNSS_len += Sqrt(Pow(data[2][i] - data[0][i], 2) + Pow(data[3][i] - data[1][i], 2));
                }
                GNSS_len/= data[0].Count;
                len_GNSS.Text = GNSS_len.ToString("F2", new CultureInfo("Ru-Ru"));
            }
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
            for (int i = 0; i < data[0].Count; i++)
            {
                R_aft[i] = Sqrt(Pow(DX_aft[i], 2) + Pow(DY_aft[i], 2));
                R_nose[i] = Sqrt(Pow(DX_nose[i], 2) + Pow(DY_nose[i], 2));
                R_mass[i] = 0.5m * Sqrt(2 * Pow(R_aft[i], 2) + 2 * Pow(R_nose[i],2)-Pow(GNSS_len,2));
            }
            decimal[] alpha_aft = new decimal[R_aft.Length], alpha_mass = new decimal[R_nose.Length]; // вычисление Углов дрейфа
            for(int i = 0; i < alpha_aft.Length; i++)
            {
                alpha_aft[i] = (Pi / 2) - ACos((Pow(R_aft[i], 2) - Pow(R_mass[i], 2) + 0.25m * Pow(GNSS_len, 2)) / (2 * R_aft[i] * GNSS_len));
                alpha_mass[i] = (Pi / 2) - ACos((Pow(R_mass[i], 2) - Pow(R_nose[i], 2) + 0.25m * Pow(GNSS_len, 2)) / (2 * R_mass[i] * GNSS_len));
                alpha_aft[i] *= 180 / Pi;
                alpha_mass[i] *= 180 / Pi;
            }
            decimal angle_aft, angle_mass, m_r_aft, m_r_mass, m_a_aft, m_a_mass;
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
            m_d_aft.Text = (m_r_aft / Sqrt(R_aft.Length)).ToString("F2", cult);
            m_d_mass.Text = (m_r_mass / Sqrt(R_mass.Length)).ToString("F2", cult);
            m_an_aft.Text = (m_a_aft / Sqrt(alpha_aft.Length)).ToString("F2", cult);
            m_an_mass.Text = (m_a_mass / Sqrt(alpha_mass.Length)).ToString("F2", cult);
            DrawVesselPath();
        }

        private void CopyLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText((sender as LinkLabel).Text);
        }

        private void CalculateAltBtn_Click(object sender, EventArgs e)
        {
            decimal s_aft = 0, s_nose = 0;
            for(int i = 1; i < data[0].Count; i++)
            {
                s_aft += Sqrt(Pow(data[0][i] - data[0][i-1],2) + Pow(data[1][i] - data[1][i - 1], 2));
                s_nose += Sqrt(Pow(data[2][i] - data[2][i - 1], 2) + Pow(data[3][i] - data[3][i - 1], 2));
            }
            linkLabel1.Text = s_aft.ToString("F2", cult);
            linkLabel2.Text = s_nose.ToString("F2", cult);
            linkLabel3.Text = data[0].Count.ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void DoHeadingCutoff()
        { //расчет мгновенного курса
            int I = 0;
            decimal heading = 0, i_heading = 0, M_Δ_heading = 0;
            try
            {
                do
                {
                    decimal dx = data[2][I] - data[0][I];
                    decimal dy = data[3][I] - data[1][I];
                    //int sector = dy > 0 ?
                    //    dx < 0 ? 4 : 1 :
                    //    dx < 0 ? 3 : 2;
                    heading = ATan2(dy, dx) / Pi * 180;
                    while (heading - i_heading > 360) heading -= 360;
                    while (heading - i_heading < -360) heading += 360;
                    //if (sector == 4 || sector == 3) heading += 180;
                    //if (sector == 2) heading += 360;
                    if (I == 0) i_heading = heading;
                    I++;
                    if (heading - i_heading > 180) heading -= 360;
                    if (heading - i_heading < -180) heading += 360;
                    if (Math.Abs(heading - i_heading) > M_Δ_heading) M_Δ_heading = Math.Abs(heading - i_heading);
                } while (M_Δ_heading < headingCutoff.Value);
                data[0].RemoveRange(0, I);
                data[1].RemoveRange(0, I);
                data[2].RemoveRange(0, I);
                data[3].RemoveRange(0, I);
                DrawVesselPath();
                label18.Text = $"Время циркуляции: {data[0].Count}";
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show($"Значение точки установившейся циркуляции\nслишком велико, попробуйте\n{(int)M_Δ_heading} или меньше", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Drift_ValueChanged(object sender, EventArgs e)
        {
            if(sender == headingCutoffDrift)
            {
                headingCutoff.Value = headingCutoffDrift.Value;
                return;
            }
            if (data[0].Count != data2[0].Count){
                data[0].Clear();
                data[0].AddRange(data2[0]);
                data[1].Clear();
                data[1].AddRange(data2[1]);
                data[2].Clear();
                data[2].AddRange(data2[2]);
                data[3].Clear();
                data[3].AddRange(data2[3]);
            }
            for (int i = 1; i < data[0].Count; i++)
            {
                data[0][i] = data2[0][i] + DriftSpeed.Value * i * Cos(DriftAngle.Value / 180 * Pi);
                data[1][i] = data2[1][i] + DriftSpeed.Value * i * Sin(DriftAngle.Value / 180 * Pi);
                data[2][i] = data2[2][i] + DriftSpeed.Value * i * Cos(DriftAngle.Value / 180 * Pi);
                data[3][i] = data2[3][i] + DriftSpeed.Value * i * Sin(DriftAngle.Value / 180 * Pi);
            }
            if(sender != DriftAutoCalc) DoHeadingCutoff();
            DrawVesselPath();
        }

        private void DiagramField_SizeChanged(object sender, EventArgs e)
        {
            if (data[3] != null && data[3].Count != 0) DrawVesselPath();
        }

        private void ExcelTab_DragDrop(object sender, DragEventArgs e)
        {
            OpenExcelFileDialog.FileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            OpenExcelFileDialog_FileOK(sender, new CancelEventArgs(false));
        }

        private void ExcelTab_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void DriftAutoCalc_Click(object sender, EventArgs e)
        {
            data[0].Clear();
            data[0].AddRange(data2[0]);
            data[1].Clear();
            data[1].AddRange(data2[1]);
            data[2].Clear();
            data[2].AddRange(data2[2]);
            data[3].Clear();
            data[3].AddRange(data2[3]);
            DoHeadingCutoff();
#if DEBUG
            int I = 0;
            try
            {
                decimal heading = 0, heading_p = heading, i_heading = 0, M_Δ_heading = 0;
                do
                {
                    decimal dx = data[2][I] - data[0][I];
                    decimal dy = data[3][I] - data[1][I];
                    int sector = dy > 0 ?
                        dx < 0 ? 4 : 1 :
                        dx < 0 ? 3 : 2;
                    heading_p = heading;
                    heading = ATan2(dy, dx) / Pi * 180; 
                    while (heading - i_heading > 360) heading -= 360;
                    while (heading - i_heading < -360) heading += 360;
                    if (sector == 4 || sector == 3) heading += 180;
                    if (sector == 2) heading += 360;
                    if (I == 0) i_heading = heading;
                    if (heading - i_heading > 180) heading -= 360;
                    if (heading - i_heading < -180) heading += 360;
                    I++;
                    if (Math.Abs(heading - i_heading) > M_Δ_heading) M_Δ_heading = Math.Abs(heading - i_heading);
                } while (Math.Abs(heading - i_heading) < 360);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show($"Установившаяся циркуляция меньше 360°", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            {
                decimal dx = ((data[0][0] - data[0][I]) + (data[2][0] - data[2][I]))/2;
                decimal dy = ((data[1][0] - data[1][I]) + (data[3][0] - data[3][I]))/2;
                int sector = dy > 0 ?
                    dx < 0 ? 4 : 1 :
                    dx < 0 ? 3 : 2;
                decimal angle = ATan2(dy, dx) / Pi * 180;
                if (sector == 4 || sector == 3) angle += 180;
                if (sector == 2) angle += 360;
                decimal strength = Sqrt(Pow(dx, 2) + Pow(dy, 2))/2;
                DriftAngle.Value = angle;
                DriftSpeed.Value = strength/I;
            }
#endif
            Drift_ValueChanged(sender, e);
        }

        private void headingCutoff_ValueChanged(object sender, EventArgs e)
        {
            headingCutoffDrift.Value = headingCutoff.Value;
            return;
        }

        private async void MainWindow_Shown(object sender, EventArgs e)
        {
            label2.Text = $"Версия: {versionStr}. Автор - Павел Бажанкин 2023-2024";
#if !DEBUG
            Width = SystemInformation.VirtualScreen.Width;
            Height = SystemInformation.VirtualScreen.Height;
            Location = Point.Empty;
            DriftAutoCalc.Text = "Обрезать";
#endif
#if DEBUG
            //label2.Text += " DEBUG";
#endif
            HttpRequestMessage request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://api.github.com/repos/PaulBazhankin/WorkProjects/tags"),
                Method = HttpMethod.Get
            };
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github+json"));
            request.Headers.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue(@"(Win)"));
            request.Headers.Add("X-GitHub-Api-Version", "2022-11-28");
            HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.SendAsync(request);
            var jsonResponse = await response.Content.ReadAsStringAsync();
            Version newest = JsonSerializer.Deserialize<GithubTag[]>(jsonResponse, new JsonSerializerOptions() { IncludeFields = true }).Select((GithubTag g)=> new Version(g.name)).Where((Version v) => v.Name == "Prj1").FirstOrDefault();
            if (newest.MainVersion > currentV.MainVersion || newest.SubVersion > currentV.SubVersion) 
            { 
                DialogResult dr = MessageBox.Show("Устаревшая версия\nОбновить?","Внимание!",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(dr == DialogResult.Yes) System.Diagnostics.Process.Start($"https://github.com/PaulBazhankin/WorkProjects/releases/tag/{newest.FullName}");
            }
        }

        class Version
        {
            public string Name { get; }
            public string FullName { get; }
            public int MainVersion { get; }
            public int SubVersion { get; }

            public Version(string ver)
            {
                string[] sections = ver.Split('.');
                Name = sections[0];
                FullName = ver;
                MainVersion = int.Parse(sections[1]);
                if (sections.Length < 3) SubVersion = 0;
                else SubVersion = int.Parse(sections[2]);
            }
        }

        class GithubTag
        {
            public string name;
            public string zipball_url;
            public string tarball_url;
            public class Commit
            {
                public string sha;
                public string url;

                public Commit(string sha, string url)
                {
                    this.sha = sha;
                    this.url = url;
                }
            }
            public Commit commit;
            public string node_id;
            public GithubTag(string name, Commit commit, string zipball_url, string tarball_url, string node_id)
            {
                this.name = name;
                this.commit = commit;
                this.zipball_url = zipball_url;
                this.tarball_url = tarball_url;
                this.node_id = node_id;
            }
        }
    }
}
