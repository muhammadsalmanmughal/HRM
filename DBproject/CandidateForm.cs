using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject
{
    public partial class CandidateForm : Form
    {
       
        public CandidateForm()
        {
            InitializeComponent();
            masktxtphone.MaxLength = 11;
            txtcancity.MaxLength = 15;
            txtfirstname.MaxLength = 15;
            txtlastname.MaxLength = 15;
            txtage.MaxLength = 2;
            txtcanid.MaxLength = 3;
            txtemail.MaxLength = 50;
            txtextraskill.MaxLength = 50;
            combomartial.MaxLength = 12;
            txtaddress.MaxLength = 49;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.Show();
            this.Hide();
            
        }

        private void CandidateForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblday.Text = DateTime.Now.DayOfWeek.ToString();
            candidate add = new candidate();
            dataGridView1.DataSource = add.showrecord();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbldate.Text = datetime.ToString();
        }

        private void btnaddcan_Click(object sender, EventArgs e)
        {
            candidate add = new candidate();
            #region
            try
            {
                if (txtcanid.Text == "")
                {
                    MessageBox.Show("please insert the Candidate ID");
                    
                    return;
                }
                else if(txtfirstname.Text=="")
                {
                    MessageBox.Show("please insert the Firstname");
                    
                    return;
                }
                else if(txtlastname.Text=="")
                {
                    MessageBox.Show("please insert the lastname");
                   
                    return;
                }
                else if (txtage.Text == "")
                {
                    MessageBox.Show("please insert the Age");

                    return;
                }
                else if (txtcancity.Text == "")
                {
                    MessageBox.Show("please insert the city");

                    return;
                }
                else if (txtaddress.Text == "")
                {
                    MessageBox.Show("please insert the address");

                    return;
                }
               
                else if(masktxtphone.Text=="")
                {
                    MessageBox.Show("please insert the phone");

                    return;
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("please insert the email");
                    
                    return;
                }
                else if (txtquali.Text == "")
                {
                    MessageBox.Show("please insert the Qualification");

                    return;
                }
                else if (combogender.Text == "")
                {
                    MessageBox.Show("please select gender");

                    return;
                }
                else if (comboapply.Text == "")
                {
                    MessageBox.Show("please select apply for");

                    return;
                }
                else if (comboexper.Text == "")
                {
                    MessageBox.Show("please select experience");

                    return;
                }
                else if (txtlastcompany.Text == "")
                {
                    MessageBox.Show("please insert last company");

                    return;
                }
                else if (combomartial.Text == "")
                {
                    MessageBox.Show("please select Martial Status");

                    return;
                }
                else if (txtextraskill.Text == "")
                {
                    MessageBox.Show("please insert the extraskills");

                    return;
                }
            #endregion
                else
                {
                    add.FirstName = txtfirstname.Text;
                    add.LastName = txtlastname.Text;
                    add.Age = Convert.ToInt32(txtage.Text);
                    add.Email = txtemail.Text;
                    add.City = txtcancity.Text;
                    add.Address = txtaddress.Text;
                    add.Phone = masktxtphone.Text;                   
                    add.Qualification = txtquali.Text;
                    add.Gender = combogender.Text;
                    add.Date = lbldate.Text;                   
                    add.ApplyFor = comboapply.Text;
                    add.Experience = comboexper.Text;
                    add.candidateid = Convert.ToInt32(txtcanid.Text);
                    add.Lastcompany = txtlastcompany.Text;
                    add.Day = lblday.Text;
                    add.Martialstatus = combomartial.Text;
                    add.Otherskills = txtextraskill.Text;


                   
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            add.insert();
            MessageBox.Show("Data saved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlPanel cp = new ControlPanel();
            cp.Show();
            this.Hide();
        }

        private void btnret_Click(object sender, EventArgs e)
        {
            candidate ret = new candidate();
            try
            {
                int cid = Convert.ToInt32(txtcanid.Text);
                ret.Retrieve(cid);
                

                txtfirstname.Text = ret.FirstName;
                txtlastname.Text = ret.LastName;
                txtage.Text = ret.Age.ToString();
                txtemail.Text = ret.Email;
                txtcancity.Text = ret.City;
                txtaddress.Text = ret.Address;
                masktxtphone.Text = ret.Phone;
                txtquali.Text = ret.Qualification;
                combogender.Text = ret.Gender;
                //  lbldate.Text = ret.Date;
                lblday.Text = ret.Day;
                comboapply.Text = ret.ApplyFor;
                comboexper.Text = ret.Experience.ToString();
                combomartial.Text = ret.Martialstatus;
                txtlastcompany.Text = ret.Lastcompany;
                //lbldate.Text = ret.Date;
                combomartial.Text = ret.Martialstatus;
                txtextraskill.Text = ret.Otherskills;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
        }

        private void txtcanid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void masktxtphone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcancity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtquali_KeyPress(object sender, KeyPressEventArgs e)
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

        private void combogender_KeyPress(object sender, KeyPressEventArgs e)
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

      

        private void comboapply_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtlastcompany_KeyPress(object sender, KeyPressEventArgs e)
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

        private void combomartial_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtextraskill_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void txtage_Validating(object sender, CancelEventArgs e)
        {
            decimal Input = Convert.ToDecimal(txtage.Text);
            if (Input < 23 || Input > 60)
            {
                MessageBox.Show("Age not valid only 23 to 60");
                e.Cancel = true;
                return;
            }
        }


       

       



    }
}
