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
    public partial class Extradetails : Form
    {
        public Extradetails()
        {
            InitializeComponent();
            emprettxtid.MaxLength = 3;
        }

        private void btnretemp_Click(object sender, EventArgs e)
        {
            employee retr = new employee();
            try
            {
               // retr.candidateid
              int eidd   = Convert.ToInt32(emprettxtid.Text);

                retr.Retrieve2(eidd);

                txtrettitle.Text = retr.EmpTitle;
                txtretsupername.Text = retr.EmpSupervisor;
                txtretworklocation.Text = retr.EmpWorklocation;
                txtretempgivenemail.Text = retr.EmpJobEmail;
                comboretsalary.Text = retr.EmpSalary.ToString();


                txtretemername.Text = retr.EmergencyContact_Name;
                txtretemercity.Text = retr.EmergencyContact_City;
                txtretphone.Text = retr.EmergencyContact_Phone;
                txtretemerrelation.Text = retr.EmergencyContact_Relation;
                txtretemeraddress.Text = retr.EmergencyContact_Address;


                #region
                txtrettitle.Enabled = false;
                txtretsupername.Enabled = false;
                txtretworklocation.Enabled = false;
                txtretempgivenemail.Enabled = false;
                comboretsalary.Enabled = false;
                txtretemername.Enabled = false;
                txtretemeraddress.Enabled = false;
                txtretemercity.Enabled = false;
                txtretphone.Enabled = false;
                txtretemerrelation.Enabled = false;
                #endregion
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm();
            ef.Show();
            this.Hide();
        }

        private void emprettxtid_KeyPress(object sender, KeyPressEventArgs e)
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

        
    }
}
