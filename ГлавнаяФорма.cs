using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ГлавнаяФорма : Form
    {
        public ГлавнаяФорма()
        {
            InitializeComponent();
        }

        private void private_button_Click(object sender, EventArgs e)
        {
            PrivateForm privateForm = new PrivateForm();
            privateForm.Show();
            this.Hide();
        }

        private void group_button_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.Show();
            this.Hide();
        }
    }
}
