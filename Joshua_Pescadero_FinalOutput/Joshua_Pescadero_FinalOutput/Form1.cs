using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joshua_Pescadero_FinalOutput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Trim().Equals(""))
            {
                txtUsername.Focus();
                MessageBox.Show("Please input Username");
            }

            else if (txtPassword.Text.Trim().Equals(""))
            {
                txtPassword.Focus();
                MessageBox.Show("Please input Password");
            }
            else

            {
                frmHome frm = new frmHome();
                frm.Show();
                this.Hide();
            }
        }
    }
}
