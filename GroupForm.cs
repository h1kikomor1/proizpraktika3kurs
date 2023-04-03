using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class GroupForm : Form
    {
        FormDataGridView formDataGridView;
        DataBase database = new DataBase();
        public GroupForm()
        {
            InitializeComponent();
        }
        private void GroupForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeDataSet6.ТипЧерногоСписка". При необходимости она может быть перемещена или удалена.
            this.типЧерногоСпискаTableAdapter.Fill(this.employeeDataSet6.ТипЧерногоСписка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeDataSet5.Посетители". При необходимости она может быть перемещена или удалена.
            this.посетителиTableAdapter1.Fill(this.employeeDataSet5.Посетители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeDataSet4.ТипЗаявки". При необходимости она может быть перемещена или удалена.
            this.типЗаявкиTableAdapter1.Fill(this.employeeDataSet4.ТипЗаявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeDataSet3.ТипЗаявки". При необходимости она может быть перемещена или удалена.
            this.типЗаявкиTableAdapter.Fill(this.employeeDataSet3.ТипЗаявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeDataSet2.ТипПосещений". При необходимости она может быть перемещена или удалена.
            this.типПосещенийTableAdapter.Fill(this.employeeDataSet2.ТипПосещений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeDataSet1.Посетители". При необходимости она может быть перемещена или удалена.
            this.посетителиTableAdapter.Fill(this.employeeDataSet1.Посетители);
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            formDataGridView = new FormDataGridView();
            formDataGridView.Show();
            if (null != dataGridView1.CurrentRow)
                formDataGridView.ShowDataGridViewRow(dataGridView1.CurrentRow);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    посетителиBindingSource1.Filter = "ИД_тип_пос = 1";

                    break;

                case 1:

                    посетителиBindingSource1.Filter = "ИД_тип_пос = 2";

                    break;
            }
        }

        

        private void GroupForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:

                    посетителиBindingSource1.Filter = "ИД_тип_заяв = 1";

                    break;

                case 1:

                    посетителиBindingSource1.Filter = "ИД_тип_заяв = 2";

                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:

                    посетителиBindingSource1.Filter = "ИД_тип_ЧС = 1";

                    break;

                case 1:

                    посетителиBindingSource1.Filter = "ИД_тип_ЧС = 2";

                    break;
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox_search.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            ГлавнаяФорма главнаяФорма = new ГлавнаяФорма();
            главнаяФорма.Show();
            this.Hide();
        }

        private void appexit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
