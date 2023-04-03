using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDataGridView : Form
    {
        public FormDataGridView()
        {
            InitializeComponent();
        }

        internal void ShowDataGridViewRow(DataGridViewRow dataGridViewRow)
        {
            familiya_textBox.Text = dataGridViewRow.Cells[0].Value.ToString();
            imya_textBox.Text = dataGridViewRow.Cells[1].Value.ToString();
            otchestvo_textBox.Text = dataGridViewRow.Cells[2].Value.ToString();
            telephone_textBox.Text = dataGridViewRow.Cells[3].Value.ToString();
            email_textBox.Text = dataGridViewRow.Cells[4].Value.ToString();
            organization_textBox.Text = dataGridViewRow.Cells[5].Value.ToString();
            primachanie_textBox.Text = dataGridViewRow.Cells[6].Value.ToString();
            datarozh_textBox.Text = dataGridViewRow.Cells[7].Value.ToString();
            seriyatextBox.Text = dataGridViewRow.Cells[8].Value.ToString();
            nomer_textBox.Text = dataGridViewRow.Cells[9].Value.ToString();
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
