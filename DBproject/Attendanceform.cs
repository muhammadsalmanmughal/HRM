using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject
{
    public partial class Attendanceform : Form
    {
        public Attendanceform()
        {
            InitializeComponent();
            txtempaid.MaxLength = 3;
            combofunction.MaxLength = 12;
            txtempalname.Enabled = false;
            txtempaname.Enabled = false;
            txtempatitle.Enabled = false;
            txtempalocation.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlPanel cp = new ControlPanel();
            cp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendance add = new Attendance();
            try
            {
                if (txtempaid.Text == "")
                {
                    MessageBox.Show("please insert the Employee ID");
                    
                    return;
                }
                else if(combofunction.Text == "")
                {
                    MessageBox.Show("Select Employee Is ");
                }

                else
                {
                    add.EmployeeID = Convert.ToInt32(txtempaid.Text);
                    add.FirstName = txtempaname.Text;
                    add.LastName = txtempalname.Text;
                    add.Location = txtempalocation.Text;
                    add.Title = txtempatitle.Text;
                    add.EmployeeIs = combofunction.Text;
                    add.insert();
                    MessageBox.Show("Data inserted in database");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
           
        }

        private void Attendanceform_Load(object sender, EventArgs e)
        {
            Attendance ret = new Attendance();
            dgvattendance.DataSource = ret.showrecord();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attendance ret = new Attendance();
            try
            {
                int aid = Convert.ToInt32(txtempaid.Text);
                ret.Retrieve2(aid);

                txtempaname.Text = ret.EmpFirstName;
                txtempalname.Text = ret.EmpLastName;
                txtempalocation.Text = ret.EmpWorklocation;
                txtempatitle.Text = ret.EmpTitle;
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
        }

        private void txtempaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("only numbers are allowed");
            }
        }

        private void combofunction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                //these char may pass
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("only alphbets are allow");
            }
        }
    }
}
