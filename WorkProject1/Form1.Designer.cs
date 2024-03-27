
namespace WorkProject1
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SheetErrorLabel = new System.Windows.Forms.Label();
            this.SheetTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CellTextBox = new System.Windows.Forms.TextBox();
            this.CellErrorLabel = new System.Windows.Forms.Label();
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.LoadCellsBtn = new System.Windows.Forms.Button();
            this.OpenExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.IndexingLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.D_aft = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.D_mass = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.a_aft = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.a_mass = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.m_an_mass = new System.Windows.Forms.LinkLabel();
            this.m_an_aft = new System.Windows.Forms.LinkLabel();
            this.m_d_mass = new System.Windows.Forms.LinkLabel();
            this.m_d_aft = new System.Windows.Forms.LinkLabel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лист с данными";
            // 
            // SheetErrorLabel
            // 
            this.SheetErrorLabel.AutoSize = true;
            this.SheetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.SheetErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SheetErrorLabel.Location = new System.Drawing.Point(12, 79);
            this.SheetErrorLabel.Name = "SheetErrorLabel";
            this.SheetErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.SheetErrorLabel.TabIndex = 2;
            // 
            // SheetTextBox
            // 
            this.SheetTextBox.Enabled = false;
            this.SheetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.SheetTextBox.Location = new System.Drawing.Point(12, 56);
            this.SheetTextBox.Name = "SheetTextBox";
            this.SheetTextBox.Size = new System.Drawing.Size(100, 20);
            this.SheetTextBox.TabIndex = 3;
            this.SheetTextBox.TextChanged += new System.EventHandler(this.SheetTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Начальная (верхняя левая) ячейка";
            // 
            // CellTextBox
            // 
            this.CellTextBox.Enabled = false;
            this.CellTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.CellTextBox.Location = new System.Drawing.Point(12, 112);
            this.CellTextBox.Name = "CellTextBox";
            this.CellTextBox.Size = new System.Drawing.Size(100, 20);
            this.CellTextBox.TabIndex = 5;
            this.CellTextBox.TextChanged += new System.EventHandler(this.CellTextBox_TextChanged);
            // 
            // CellErrorLabel
            // 
            this.CellErrorLabel.AutoSize = true;
            this.CellErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.CellErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CellErrorLabel.Location = new System.Drawing.Point(12, 135);
            this.CellErrorLabel.Name = "CellErrorLabel";
            this.CellErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.CellErrorLabel.TabIndex = 6;
            // 
            // LoadFileBtn
            // 
            this.LoadFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.LoadFileBtn.Location = new System.Drawing.Point(12, 5);
            this.LoadFileBtn.Name = "LoadFileBtn";
            this.LoadFileBtn.Size = new System.Drawing.Size(157, 30);
            this.LoadFileBtn.TabIndex = 7;
            this.LoadFileBtn.Text = "Загрузить Excel файл";
            this.LoadFileBtn.UseVisualStyleBackColor = true;
            this.LoadFileBtn.Click += new System.EventHandler(this.LoadFileBtn_Click);
            // 
            // LoadCellsBtn
            // 
            this.LoadCellsBtn.Enabled = false;
            this.LoadCellsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.LoadCellsBtn.Location = new System.Drawing.Point(12, 153);
            this.LoadCellsBtn.Name = "LoadCellsBtn";
            this.LoadCellsBtn.Size = new System.Drawing.Size(126, 25);
            this.LoadCellsBtn.TabIndex = 8;
            this.LoadCellsBtn.Text = "Загрузить данные";
            this.LoadCellsBtn.UseVisualStyleBackColor = true;
            this.LoadCellsBtn.Click += new System.EventHandler(this.LoadCellsBtn_Click);
            // 
            // OpenExcelFileDialog
            // 
            this.OpenExcelFileDialog.DefaultExt = "xlsx";
            this.OpenExcelFileDialog.Filter = "Excel|*.xls;*.xlsx|Все файлы|*.*";
            this.OpenExcelFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenExcelFileDialog_FileOK);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(432, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(420, 363);
            this.dataGridView1.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(864, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Enabled = false;
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.CalculateBtn.Location = new System.Drawing.Point(12, 182);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(126, 25);
            this.CalculateBtn.TabIndex = 11;
            this.CalculateBtn.Text = "Рассчитать";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // IndexingLabel
            // 
            this.IndexingLabel.AutoSize = true;
            this.IndexingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.IndexingLabel.Location = new System.Drawing.Point(144, 157);
            this.IndexingLabel.Name = "IndexingLabel";
            this.IndexingLabel.Size = new System.Drawing.Size(171, 15);
            this.IndexingLabel.TabIndex = 12;
            this.IndexingLabel.Text = "Здесь будет статус загрузки";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(2, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Автор - Павел Бажанкин 2023-2024";
            // 
            // D_aft
            // 
            this.D_aft.AutoSize = true;
            this.D_aft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.D_aft.Location = new System.Drawing.Point(190, 223);
            this.D_aft.Name = "D_aft";
            this.D_aft.Size = new System.Drawing.Size(14, 15);
            this.D_aft.TabIndex = 14;
            this.D_aft.TabStop = true;
            this.D_aft.Text = "0";
            this.D_aft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.label4.Location = new System.Drawing.Point(9, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Результаты. (нажмите для копирования)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.label5.Location = new System.Drawing.Point(9, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Диаметр циркуяции (Корма):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.label6.Location = new System.Drawing.Point(9, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Диаметр циркуляции (ЦТ):";
            // 
            // D_mass
            // 
            this.D_mass.AutoSize = true;
            this.D_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.D_mass.Location = new System.Drawing.Point(190, 238);
            this.D_mass.Name = "D_mass";
            this.D_mass.Size = new System.Drawing.Size(14, 15);
            this.D_mass.TabIndex = 17;
            this.D_mass.TabStop = true;
            this.D_mass.Text = "0";
            this.D_mass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.label7.Location = new System.Drawing.Point(9, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Угол дрейфа (Корма):";
            // 
            // a_aft
            // 
            this.a_aft.AutoSize = true;
            this.a_aft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.a_aft.Location = new System.Drawing.Point(190, 253);
            this.a_aft.Name = "a_aft";
            this.a_aft.Size = new System.Drawing.Size(14, 15);
            this.a_aft.TabIndex = 19;
            this.a_aft.TabStop = true;
            this.a_aft.Text = "0";
            this.a_aft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.label8.Location = new System.Drawing.Point(9, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Угол дрейфа (ЦТ):";
            // 
            // a_mass
            // 
            this.a_mass.AutoSize = true;
            this.a_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.a_mass.Location = new System.Drawing.Point(190, 268);
            this.a_mass.Name = "a_mass";
            this.a_mass.Size = new System.Drawing.Size(14, 15);
            this.a_mass.TabIndex = 21;
            this.a_mass.TabStop = true;
            this.a_mass.Text = "0";
            this.a_mass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.label9.Location = new System.Drawing.Point(262, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "СКП (68.3%):";
            // 
            // m_an_mass
            // 
            this.m_an_mass.AutoSize = true;
            this.m_an_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.m_an_mass.Location = new System.Drawing.Point(262, 268);
            this.m_an_mass.Name = "m_an_mass";
            this.m_an_mass.Size = new System.Drawing.Size(14, 15);
            this.m_an_mass.TabIndex = 27;
            this.m_an_mass.TabStop = true;
            this.m_an_mass.Text = "0";
            this.m_an_mass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // m_an_aft
            // 
            this.m_an_aft.AutoSize = true;
            this.m_an_aft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.m_an_aft.Location = new System.Drawing.Point(262, 253);
            this.m_an_aft.Name = "m_an_aft";
            this.m_an_aft.Size = new System.Drawing.Size(14, 15);
            this.m_an_aft.TabIndex = 26;
            this.m_an_aft.TabStop = true;
            this.m_an_aft.Text = "0";
            this.m_an_aft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // m_d_mass
            // 
            this.m_d_mass.AutoSize = true;
            this.m_d_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.m_d_mass.Location = new System.Drawing.Point(262, 238);
            this.m_d_mass.Name = "m_d_mass";
            this.m_d_mass.Size = new System.Drawing.Size(14, 15);
            this.m_d_mass.TabIndex = 25;
            this.m_d_mass.TabStop = true;
            this.m_d_mass.Text = "0";
            this.m_d_mass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // m_d_aft
            // 
            this.m_d_aft.AutoSize = true;
            this.m_d_aft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.32F);
            this.m_d_aft.Location = new System.Drawing.Point(262, 223);
            this.m_d_aft.Name = "m_d_aft";
            this.m_d_aft.Size = new System.Drawing.Size(14, 15);
            this.m_d_aft.TabIndex = 24;
            this.m_d_aft.TabStop = true;
            this.m_d_aft.Text = "0";
            this.m_d_aft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Корма X";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Корма Y";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Нос X";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Нос Y";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 404);
            this.Controls.Add(this.m_an_mass);
            this.Controls.Add(this.m_an_aft);
            this.Controls.Add(this.m_d_mass);
            this.Controls.Add(this.m_d_aft);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.a_mass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.a_aft);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.D_mass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.D_aft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IndexingLabel);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LoadCellsBtn);
            this.Controls.Add(this.LoadFileBtn);
            this.Controls.Add(this.CellErrorLabel);
            this.Controls.Add(this.CellTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SheetTextBox);
            this.Controls.Add(this.SheetErrorLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Калькулятор циркуляции";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SheetErrorLabel;
        private System.Windows.Forms.TextBox SheetTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CellTextBox;
        private System.Windows.Forms.Label CellErrorLabel;
        private System.Windows.Forms.Button LoadFileBtn;
        private System.Windows.Forms.Button LoadCellsBtn;
        private System.Windows.Forms.OpenFileDialog OpenExcelFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label IndexingLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel D_aft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel D_mass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel a_aft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel a_mass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel m_an_mass;
        private System.Windows.Forms.LinkLabel m_an_aft;
        private System.Windows.Forms.LinkLabel m_d_mass;
        private System.Windows.Forms.LinkLabel m_d_aft;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

