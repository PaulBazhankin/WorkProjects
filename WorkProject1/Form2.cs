using System;
using System.Windows.Forms;

namespace WorkProject1
{
    public partial class Form2 : Form
    {
        public decimal Out = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Out = InputBox.Value;
            Close();
        }
    }
}
