using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text == "admin" && this.txtpass.Text == "admin")
            {
               // timer1.Enabled = true;
                // MessageBox.Show("Welcome");
                Form mdima = new mainMDI();
                mdima.Show();
                this.Hide();
            }

            else if (this.txtname.Text != "admin")
            {

                txtname.BackColor = Color.Red;
                MessageBox.Show("Sorry your name does not match");

            }
            else if (this.txtpass.Text != "admin")
            {

                txtpass.BackColor = Color.Red;
                MessageBox.Show("Sorry your password does not match");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }
    }
}
