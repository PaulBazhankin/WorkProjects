
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
            if ((reader != null))
            {
                reader.Dispose();
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
            this.OpenExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.DataTabs = new System.Windows.Forms.TabControl();
            this.DataPage = new System.Windows.Forms.TabPage();
            this.PathPage = new System.Windows.Forms.TabPage();
            this.DiagramField = new System.Windows.Forms.PictureBox();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.ExcelTab = new System.Windows.Forms.TabPage();
            this.IndexingLabel = new System.Windows.Forms.Label();
            this.LoadCellsBtn = new System.Windows.Forms.Button();
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.CellErrorLabel = new System.Windows.Forms.Label();
            this.CellTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SheetTextBox = new System.Windows.Forms.ComboBox();
            this.SheetErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DriftPage = new System.Windows.Forms.TabPage();
            this.DriftAutoCalc = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.headingCutoffDrift = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.DriftSpeed = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.DriftAngle = new System.Windows.Forms.NumericUpDown();
            this.CirclePage = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.len_GNSS = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.headingCutoff = new System.Windows.Forms.NumericUpDown();
            this.m_an_mass = new System.Windows.Forms.LinkLabel();
            this.m_an_aft = new System.Windows.Forms.LinkLabel();
            this.m_d_mass = new System.Windows.Forms.LinkLabel();
            this.m_d_aft = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.a_mass = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.a_aft = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.D_mass = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.D_aft = new System.Windows.Forms.LinkLabel();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.HaltPage = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.CalculateAltBtn = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DataTabs.SuspendLayout();
            this.DataPage.SuspendLayout();
            this.PathPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagramField)).BeginInit();
            this.MainTabs.SuspendLayout();
            this.ExcelTab.SuspendLayout();
            this.DriftPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headingCutoffDrift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriftSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriftAngle)).BeginInit();
            this.CirclePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headingCutoff)).BeginInit();
            this.HaltPage.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(450, 342);
            this.dataGridView1.TabIndex = 9;
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
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(864, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Версия: ver. Автор - Павел Бажанкин 2023-2024";
            // 
            // DataTabs
            // 
            this.DataTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTabs.Controls.Add(this.DataPage);
            this.DataTabs.Controls.Add(this.PathPage);
            this.DataTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DataTabs.Location = new System.Drawing.Point(406, 5);
            this.DataTabs.Margin = new System.Windows.Forms.Padding(0);
            this.DataTabs.Name = "DataTabs";
            this.DataTabs.Padding = new System.Drawing.Point(0, 0);
            this.DataTabs.SelectedIndex = 0;
            this.DataTabs.Size = new System.Drawing.Size(458, 373);
            this.DataTabs.TabIndex = 28;
            // 
            // DataPage
            // 
            this.DataPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataPage.Controls.Add(this.dataGridView1);
            this.DataPage.Location = new System.Drawing.Point(4, 27);
            this.DataPage.Name = "DataPage";
            this.DataPage.Size = new System.Drawing.Size(450, 342);
            this.DataPage.TabIndex = 0;
            this.DataPage.Text = "Данные";
            // 
            // PathPage
            // 
            this.PathPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PathPage.Controls.Add(this.DiagramField);
            this.PathPage.Location = new System.Drawing.Point(4, 27);
            this.PathPage.Name = "PathPage";
            this.PathPage.Size = new System.Drawing.Size(450, 342);
            this.PathPage.TabIndex = 1;
            this.PathPage.Text = "Путь";
            // 
            // DiagramField
            // 
            this.DiagramField.BackColor = System.Drawing.SystemColors.Control;
            this.DiagramField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiagramField.Location = new System.Drawing.Point(0, 0);
            this.DiagramField.Margin = new System.Windows.Forms.Padding(0);
            this.DiagramField.Name = "DiagramField";
            this.DiagramField.Size = new System.Drawing.Size(450, 342);
            this.DiagramField.TabIndex = 0;
            this.DiagramField.TabStop = false;
            this.DiagramField.SizeChanged += new System.EventHandler(this.DiagramField_SizeChanged);
            // 
            // MainTabs
            // 
            this.MainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainTabs.Controls.Add(this.ExcelTab);
            this.MainTabs.Controls.Add(this.DriftPage);
            this.MainTabs.Controls.Add(this.CirclePage);
            this.MainTabs.Controls.Add(this.HaltPage);
            this.MainTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MainTabs.Location = new System.Drawing.Point(0, 5);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(401, 353);
            this.MainTabs.TabIndex = 29;
            // 
            // ExcelTab
            // 
            this.ExcelTab.AllowDrop = true;
            this.ExcelTab.Controls.Add(this.IndexingLabel);
            this.ExcelTab.Controls.Add(this.LoadCellsBtn);
            this.ExcelTab.Controls.Add(this.LoadFileBtn);
            this.ExcelTab.Controls.Add(this.CellErrorLabel);
            this.ExcelTab.Controls.Add(this.CellTextBox);
            this.ExcelTab.Controls.Add(this.label3);
            this.ExcelTab.Controls.Add(this.SheetTextBox);
            this.ExcelTab.Controls.Add(this.SheetErrorLabel);
            this.ExcelTab.Controls.Add(this.label1);
            this.ExcelTab.Location = new System.Drawing.Point(4, 27);
            this.ExcelTab.Name = "ExcelTab";
            this.ExcelTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExcelTab.Size = new System.Drawing.Size(393, 322);
            this.ExcelTab.TabIndex = 0;
            this.ExcelTab.Text = "Excel";
            this.ExcelTab.UseVisualStyleBackColor = true;
            this.ExcelTab.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExcelTab_DragDrop);
            this.ExcelTab.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExcelTab_DragEnter);
            // 
            // IndexingLabel
            // 
            this.IndexingLabel.AutoSize = true;
            this.IndexingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.IndexingLabel.Location = new System.Drawing.Point(138, 179);
            this.IndexingLabel.Name = "IndexingLabel";
            this.IndexingLabel.Size = new System.Drawing.Size(209, 18);
            this.IndexingLabel.TabIndex = 21;
            this.IndexingLabel.Text = "Здесь будет статус загрузки";
            // 
            // LoadCellsBtn
            // 
            this.LoadCellsBtn.Enabled = false;
            this.LoadCellsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LoadCellsBtn.Location = new System.Drawing.Point(6, 176);
            this.LoadCellsBtn.Name = "LoadCellsBtn";
            this.LoadCellsBtn.Size = new System.Drawing.Size(126, 25);
            this.LoadCellsBtn.TabIndex = 20;
            this.LoadCellsBtn.Text = "Загрузить данные";
            this.LoadCellsBtn.UseVisualStyleBackColor = true;
            this.LoadCellsBtn.Click += new System.EventHandler(this.LoadCellsBtn_Click);
            // 
            // LoadFileBtn
            // 
            this.LoadFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LoadFileBtn.Location = new System.Drawing.Point(6, 6);
            this.LoadFileBtn.Name = "LoadFileBtn";
            this.LoadFileBtn.Size = new System.Drawing.Size(189, 30);
            this.LoadFileBtn.TabIndex = 19;
            this.LoadFileBtn.Text = "Загрузить Excel файл";
            this.LoadFileBtn.UseVisualStyleBackColor = true;
            this.LoadFileBtn.Click += new System.EventHandler(this.LoadFileBtn_Click);
            // 
            // CellErrorLabel
            // 
            this.CellErrorLabel.AutoSize = true;
            this.CellErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CellErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CellErrorLabel.Location = new System.Drawing.Point(6, 155);
            this.CellErrorLabel.Name = "CellErrorLabel";
            this.CellErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.CellErrorLabel.TabIndex = 18;
            // 
            // CellTextBox
            // 
            this.CellTextBox.Enabled = false;
            this.CellTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CellTextBox.Location = new System.Drawing.Point(6, 128);
            this.CellTextBox.Name = "CellTextBox";
            this.CellTextBox.Size = new System.Drawing.Size(126, 24);
            this.CellTextBox.TabIndex = 17;
            this.CellTextBox.TextChanged += new System.EventHandler(this.CellTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Начальная (верхняя левая) ячейка";
            // 
            // SheetTextBox
            // 
            this.SheetTextBox.Enabled = false;
            this.SheetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SheetTextBox.Location = new System.Drawing.Point(6, 60);
            this.SheetTextBox.Name = "SheetTextBox";
            this.SheetTextBox.Size = new System.Drawing.Size(126, 26);
            this.SheetTextBox.TabIndex = 15;
            this.SheetTextBox.TextChanged += new System.EventHandler(this.SheetTextBox_TextChanged);
            // 
            // SheetErrorLabel
            // 
            this.SheetErrorLabel.AutoSize = true;
            this.SheetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SheetErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SheetErrorLabel.Location = new System.Drawing.Point(6, 89);
            this.SheetErrorLabel.Name = "SheetErrorLabel";
            this.SheetErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.SheetErrorLabel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Лист с данными";
            // 
            // DriftPage
            // 
            this.DriftPage.Controls.Add(this.DriftAutoCalc);
            this.DriftPage.Controls.Add(this.label16);
            this.DriftPage.Controls.Add(this.headingCutoffDrift);
            this.DriftPage.Controls.Add(this.label15);
            this.DriftPage.Controls.Add(this.DriftSpeed);
            this.DriftPage.Controls.Add(this.label14);
            this.DriftPage.Controls.Add(this.DriftAngle);
            this.DriftPage.Location = new System.Drawing.Point(4, 27);
            this.DriftPage.Name = "DriftPage";
            this.DriftPage.Size = new System.Drawing.Size(393, 322);
            this.DriftPage.TabIndex = 3;
            this.DriftPage.Text = "Хар. Сноса";
            this.DriftPage.UseVisualStyleBackColor = true;
            // 
            // DriftAutoCalc
            // 
            this.DriftAutoCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DriftAutoCalc.Location = new System.Drawing.Point(162, 80);
            this.DriftAutoCalc.Name = "DriftAutoCalc";
            this.DriftAutoCalc.Size = new System.Drawing.Size(103, 24);
            this.DriftAutoCalc.TabIndex = 47;
            this.DriftAutoCalc.Text = "Авторасчет";
            this.DriftAutoCalc.UseVisualStyleBackColor = true;
            this.DriftAutoCalc.Click += new System.EventHandler(this.DriftAutoCalc_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(159, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 34);
            this.label16.TabIndex = 46;
            this.label16.Text = "Точка начала\r\nциркуляции (°)";
            // 
            // headingCutoffDrift
            // 
            this.headingCutoffDrift.Location = new System.Drawing.Point(268, 16);
            this.headingCutoffDrift.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.headingCutoffDrift.Name = "headingCutoffDrift";
            this.headingCutoffDrift.Size = new System.Drawing.Size(120, 24);
            this.headingCutoffDrift.TabIndex = 45;
            this.headingCutoffDrift.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.headingCutoffDrift.ValueChanged += new System.EventHandler(this.Drift_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Скорость сноса";
            // 
            // DriftSpeed
            // 
            this.DriftSpeed.DecimalPlaces = 2;
            this.DriftSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DriftSpeed.Location = new System.Drawing.Point(8, 80);
            this.DriftSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DriftSpeed.Name = "DriftSpeed";
            this.DriftSpeed.Size = new System.Drawing.Size(120, 24);
            this.DriftSpeed.TabIndex = 2;
            this.DriftSpeed.ValueChanged += new System.EventHandler(this.Drift_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "Угол сноса";
            // 
            // DriftAngle
            // 
            this.DriftAngle.DecimalPlaces = 1;
            this.DriftAngle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DriftAngle.Location = new System.Drawing.Point(8, 32);
            this.DriftAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.DriftAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.DriftAngle.Name = "DriftAngle";
            this.DriftAngle.Size = new System.Drawing.Size(120, 24);
            this.DriftAngle.TabIndex = 0;
            this.DriftAngle.ValueChanged += new System.EventHandler(this.Drift_ValueChanged);
            // 
            // CirclePage
            // 
            this.CirclePage.Controls.Add(this.label17);
            this.CirclePage.Controls.Add(this.len_GNSS);
            this.CirclePage.Controls.Add(this.label10);
            this.CirclePage.Controls.Add(this.headingCutoff);
            this.CirclePage.Controls.Add(this.m_an_mass);
            this.CirclePage.Controls.Add(this.m_an_aft);
            this.CirclePage.Controls.Add(this.m_d_mass);
            this.CirclePage.Controls.Add(this.m_d_aft);
            this.CirclePage.Controls.Add(this.label9);
            this.CirclePage.Controls.Add(this.label8);
            this.CirclePage.Controls.Add(this.a_mass);
            this.CirclePage.Controls.Add(this.label7);
            this.CirclePage.Controls.Add(this.a_aft);
            this.CirclePage.Controls.Add(this.label6);
            this.CirclePage.Controls.Add(this.D_mass);
            this.CirclePage.Controls.Add(this.label5);
            this.CirclePage.Controls.Add(this.label4);
            this.CirclePage.Controls.Add(this.D_aft);
            this.CirclePage.Controls.Add(this.CalculateBtn);
            this.CirclePage.Location = new System.Drawing.Point(4, 27);
            this.CirclePage.Name = "CirclePage";
            this.CirclePage.Padding = new System.Windows.Forms.Padding(3);
            this.CirclePage.Size = new System.Drawing.Size(393, 322);
            this.CirclePage.TabIndex = 1;
            this.CirclePage.Text = "Хар. Циркуляции";
            this.CirclePage.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(5, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 17);
            this.label17.TabIndex = 46;
            this.label17.Text = "Расчетная длина:";
            // 
            // len_GNSS
            // 
            this.len_GNSS.AutoSize = true;
            this.len_GNSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.len_GNSS.Location = new System.Drawing.Point(220, 123);
            this.len_GNSS.Name = "len_GNSS";
            this.len_GNSS.Size = new System.Drawing.Size(16, 17);
            this.len_GNSS.TabIndex = 45;
            this.len_GNSS.TabStop = true;
            this.len_GNSS.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(158, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 34);
            this.label10.TabIndex = 44;
            this.label10.Text = "Точка начала\r\nциркуляции (°)";
            // 
            // headingCutoff
            // 
            this.headingCutoff.Location = new System.Drawing.Point(267, 6);
            this.headingCutoff.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.headingCutoff.Name = "headingCutoff";
            this.headingCutoff.Size = new System.Drawing.Size(120, 24);
            this.headingCutoff.TabIndex = 43;
            this.headingCutoff.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.headingCutoff.ValueChanged += new System.EventHandler(this.headingCutoff_ValueChanged);
            // 
            // m_an_mass
            // 
            this.m_an_mass.AutoSize = true;
            this.m_an_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_an_mass.Location = new System.Drawing.Point(298, 106);
            this.m_an_mass.Name = "m_an_mass";
            this.m_an_mass.Size = new System.Drawing.Size(16, 17);
            this.m_an_mass.TabIndex = 42;
            this.m_an_mass.TabStop = true;
            this.m_an_mass.Text = "0";
            this.m_an_mass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // m_an_aft
            // 
            this.m_an_aft.AutoSize = true;
            this.m_an_aft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_an_aft.Location = new System.Drawing.Point(298, 88);
            this.m_an_aft.Name = "m_an_aft";
            this.m_an_aft.Size = new System.Drawing.Size(16, 17);
            this.m_an_aft.TabIndex = 41;
            this.m_an_aft.TabStop = true;
            this.m_an_aft.Text = "0";
            this.m_an_aft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // m_d_mass
            // 
            this.m_d_mass.AutoSize = true;
            this.m_d_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_d_mass.Location = new System.Drawing.Point(298, 70);
            this.m_d_mass.Name = "m_d_mass";
            this.m_d_mass.Size = new System.Drawing.Size(16, 17);
            this.m_d_mass.TabIndex = 40;
            this.m_d_mass.TabStop = true;
            this.m_d_mass.Text = "0";
            this.m_d_mass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // m_d_aft
            // 
            this.m_d_aft.AutoSize = true;
            this.m_d_aft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_d_aft.Location = new System.Drawing.Point(298, 52);
            this.m_d_aft.Name = "m_d_aft";
            this.m_d_aft.Size = new System.Drawing.Size(16, 17);
            this.m_d_aft.TabIndex = 39;
            this.m_d_aft.TabStop = true;
            this.m_d_aft.Text = "0";
            this.m_d_aft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(298, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "СКП (68.3%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(5, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Угол дрейфа (ЦТ):";
            // 
            // a_mass
            // 
            this.a_mass.AutoSize = true;
            this.a_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.a_mass.Location = new System.Drawing.Point(220, 106);
            this.a_mass.Name = "a_mass";
            this.a_mass.Size = new System.Drawing.Size(16, 17);
            this.a_mass.TabIndex = 36;
            this.a_mass.TabStop = true;
            this.a_mass.Text = "0";
            this.a_mass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(5, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Угол дрейфа (Корма):";
            // 
            // a_aft
            // 
            this.a_aft.AutoSize = true;
            this.a_aft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.a_aft.Location = new System.Drawing.Point(220, 88);
            this.a_aft.Name = "a_aft";
            this.a_aft.Size = new System.Drawing.Size(16, 17);
            this.a_aft.TabIndex = 34;
            this.a_aft.TabStop = true;
            this.a_aft.Text = "0";
            this.a_aft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(5, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Диаметр циркуляции (ЦТ):";
            // 
            // D_mass
            // 
            this.D_mass.AutoSize = true;
            this.D_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.D_mass.Location = new System.Drawing.Point(220, 70);
            this.D_mass.Name = "D_mass";
            this.D_mass.Size = new System.Drawing.Size(16, 17);
            this.D_mass.TabIndex = 32;
            this.D_mass.TabStop = true;
            this.D_mass.Text = "0";
            this.D_mass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(5, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Диаметр циркуяции (Корма):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Результаты. (нажмите для копирования)";
            // 
            // D_aft
            // 
            this.D_aft.AutoSize = true;
            this.D_aft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.D_aft.Location = new System.Drawing.Point(220, 52);
            this.D_aft.Name = "D_aft";
            this.D_aft.Size = new System.Drawing.Size(16, 17);
            this.D_aft.TabIndex = 29;
            this.D_aft.TabStop = true;
            this.D_aft.Text = "0";
            this.D_aft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Enabled = false;
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CalculateBtn.Location = new System.Drawing.Point(8, 6);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(126, 25);
            this.CalculateBtn.TabIndex = 28;
            this.CalculateBtn.Text = "Рассчитать";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // HaltPage
            // 
            this.HaltPage.Controls.Add(this.linkLabel3);
            this.HaltPage.Controls.Add(this.label13);
            this.HaltPage.Controls.Add(this.CalculateAltBtn);
            this.HaltPage.Controls.Add(this.linkLabel2);
            this.HaltPage.Controls.Add(this.label12);
            this.HaltPage.Controls.Add(this.linkLabel1);
            this.HaltPage.Controls.Add(this.label11);
            this.HaltPage.Location = new System.Drawing.Point(4, 27);
            this.HaltPage.Name = "HaltPage";
            this.HaltPage.Size = new System.Drawing.Size(393, 322);
            this.HaltPage.TabIndex = 2;
            this.HaltPage.Text = "Хар. Торм. Пути";
            this.HaltPage.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(5, 121);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(16, 18);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "0";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Время";
            // 
            // CalculateAltBtn
            // 
            this.CalculateAltBtn.Location = new System.Drawing.Point(8, 3);
            this.CalculateAltBtn.Name = "CalculateAltBtn";
            this.CalculateAltBtn.Size = new System.Drawing.Size(126, 25);
            this.CalculateAltBtn.TabIndex = 4;
            this.CalculateAltBtn.Text = "Рассчитать";
            this.CalculateAltBtn.UseVisualStyleBackColor = true;
            this.CalculateAltBtn.Click += new System.EventHandler(this.CalculateAltBtn_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(5, 85);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(16, 18);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "0";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Длина Тормозного пути (Нос)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(5, 49);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(16, 18);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "0";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Длина Тормозного пути (Корма)";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 404);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.DataTabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Name = "MainWindow";
            this.Text = "Калькулятор циркуляции";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DataTabs.ResumeLayout(false);
            this.DataPage.ResumeLayout(false);
            this.PathPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiagramField)).EndInit();
            this.MainTabs.ResumeLayout(false);
            this.ExcelTab.ResumeLayout(false);
            this.ExcelTab.PerformLayout();
            this.DriftPage.ResumeLayout(false);
            this.DriftPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headingCutoffDrift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriftSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriftAngle)).EndInit();
            this.CirclePage.ResumeLayout(false);
            this.CirclePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headingCutoff)).EndInit();
            this.HaltPage.ResumeLayout(false);
            this.HaltPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenExcelFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabControl DataTabs;
        private System.Windows.Forms.TabPage DataPage;
        private System.Windows.Forms.TabPage PathPage;
        private System.Windows.Forms.PictureBox DiagramField;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage ExcelTab;
        private System.Windows.Forms.Label IndexingLabel;
        private System.Windows.Forms.Button LoadCellsBtn;
        private System.Windows.Forms.Button LoadFileBtn;
        private System.Windows.Forms.Label CellErrorLabel;
        private System.Windows.Forms.TextBox CellTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SheetTextBox;
        private System.Windows.Forms.Label SheetErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage CirclePage;
        private System.Windows.Forms.LinkLabel m_an_mass;
        private System.Windows.Forms.LinkLabel m_an_aft;
        private System.Windows.Forms.LinkLabel m_d_mass;
        private System.Windows.Forms.LinkLabel m_d_aft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel a_mass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel a_aft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel D_mass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel D_aft;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TabPage HaltPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CalculateAltBtn;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage DriftPage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown DriftSpeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown DriftAngle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown headingCutoff;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown headingCutoffDrift;
        private System.Windows.Forms.Button DriftAutoCalc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel len_GNSS;
    }
}

