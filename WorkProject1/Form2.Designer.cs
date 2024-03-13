namespace WorkProject1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputBox = new System.Windows.Forms.NumericUpDown();
            this.AcсeptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.DecimalPlaces = 2;
            this.InputBox.Location = new System.Drawing.Point(12, 35);
            this.InputBox.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.InputBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(120, 20);
            this.InputBox.TabIndex = 0;
            this.InputBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AcсeptBtn
            // 
            this.AcсeptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcсeptBtn.Location = new System.Drawing.Point(216, 226);
            this.AcсeptBtn.Name = "AcсeptBtn";
            this.AcсeptBtn.Size = new System.Drawing.Size(75, 23);
            this.AcсeptBtn.TabIndex = 1;
            this.AcсeptBtn.Text = "Принять";
            this.AcсeptBtn.UseVisualStyleBackColor = true;
            this.AcсeptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(297, 226);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите расстояние между датчиками GPS (м)";
            // 
            // Form2
            // 
            this.AcceptButton = this.AcсeptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcсeptBtn);
            this.Controls.Add(this.InputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Запрос Данных";
            ((System.ComponentModel.ISupportInitialize)(this.InputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown InputBox;
        private System.Windows.Forms.Button AcсeptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
    }
}