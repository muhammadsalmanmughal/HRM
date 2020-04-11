using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            emptxtid.MaxLength = 3;
            txtretfulldata.MaxLength = 3;
            masktxtemerphone.MaxLength = 11;
            txtemercity.MaxLength = 15;
            txtemername.MaxLength = 18;
            txtemeraddress.MaxLength = 49;
            txtemerrelation.MaxLength = 15;
            txtsupername.MaxLength = 15;
            txtworklocation.MaxLength = 15;
           
            txtempgivenemail.MaxLength = 49;
            combosalary.MaxLength = 9;
            txttitle.MaxLength = 12;
        }

        private void btnretfulldata_Click(object sender, EventArgs e)
        {
            employee reet = new employee();
            try
            {
                int eid = Convert.ToInt32(txtretfulldata.Text);
               // reet.Retrieve();
                reet.Retrieve2(eid);

                txtempname.Text = reet.EmpFirstName;
                txtempfulname.Text = reet.EmpLastName;
                txtempage.Text = reet.EmpAge.ToString();
                
                txtempcity.Text = reet.EmpCity;
                txtempaddress.Text = reet.EmpAddress;
                masktxtempphone.Text = reet.EmpPhone;
                txtempemail.Text = reet.EmpEmail;
                txtempquali.Text = reet.EmpQulification;
                txtempgender.Text = reet.EmpGender;
                txtempapply.Text = reet.EmpAppllyfor;
                txtempexp.Text = reet.EmpJobexper.ToString();
                txtemplastcompany.Text = reet.EmpLastcomppany;
                txtempmartial.Text = reet.EmpMartialstatus;
                txtempextraskill.Text = reet.EmpOtherskills;

                txttitle.Text = reet.EmpTitle;
                txtsupername.Text = reet.EmpSupervisor;
                txtworklocation.Text = reet.EmpWorklocation;
                txtempgivenemail.Text = reet.EmpJobEmail;
                combosalary.Text = reet.EmpSalary.ToString();

                txtemername.Text = reet.EmergencyContact_Name;
                txtemercity.Text = reet.EmergencyContact_City;
                masktxtemerphone.Text = reet.EmergencyContact_Phone;
                txtemerrelation.Text = reet.EmergencyContact_Relation;
                txtemeraddress.Text = reet.EmergencyContact_Address;

                #region
                txtempname.Enabled = false;
                txtempfulname.Enabled = false;
                txtempage.Enabled = false;
                txtempaddress.Enabled = false;
                txtempcity.Enabled = false;
                masktxtempphone.Enabled = false;
                txtempemail.Enabled = false;
                txtempquali.Enabled = false;
                txtempgender.Enabled = false;
                txtempapply.Enabled = false;
                txtempexp.Enabled = false;
                txtemplastcompany.Enabled = false;
                txtempmartial.Enabled = false;
                txtempextraskill.Enabled = false;

                txttitle.Enabled = false;
                txtsupername.Enabled = false;
                txtworklocation.Enabled = false;
                txtempgivenemail.Enabled = false;
                combosalary.Enabled = false;
                txtemername.Enabled = false;
                txtemeraddress.Enabled = false;
                txtemercity.Enabled = false;
                masktxtemerphone.Enabled = false;
                txtemerrelation.Enabled = false;
                #endregion

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
        }

        private void btnretemp_Click(object sender, EventArgs e)
        {
            employee ret = new employee();
            
           
            try
            {
                int cid = Convert.ToInt32(emptxtid.Text);

                ret.Retrieve(cid);
                txtempname.Text = ret.FirstName;
                txtempfulname.Text = ret.LastName;
                txtempage.Text = ret.Age.ToString();
                txtempemail.Text = ret.Email;
                txtempcity.Text = ret.City;
                txtempaddress.Text = ret.Address;
                masktxtempphone.Text = ret.Phone;
                txtempquali.Text = ret.Qualification;
                txtempgender.Text = ret.Gender;
                txtempapply.Text = ret.ApplyFor;
                txtempexp.Text = ret.Experience.ToString();
                txtemplastcompany.Text = ret.Lastcompany;
                txtempmartial.Text = ret.Martialstatus;
                txtempextraskill.Text = ret.Otherskills;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }                                   
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            lblday2.Text = DateTime.Now.DayOfWeek.ToString();
            txtempname.Enabled = false;
            txtempfulname.Enabled = false;
            txtempage.Enabled = false;
            txtempaddress.Enabled = false;
            txtempcity.Enabled = false;
            masktxtempphone.Enabled = false;
            txtempemail.Enabled = false;
            txtempquali.Enabled = false;
            txtempgender.Enabled = false;
            txtempapply.Enabled = false;
            txtempexp.Enabled = false;
            txtemplastcompany.Enabled = false;
            txtempmartial.Enabled = false;
            txtempextraskill.Enabled = false;
            employee a = new employee();
            dataGridView1.DataSource = a.showrecord();
            
        }

        Random rnd = new Random();
        int randomnumber;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbldatetime.Text = datetime.ToString();
        }

        private void emptxtid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtretfulldata_KeyPress(object sender, KeyPressEventArgs e)
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

        private void combosalary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void masktxtemerphone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Extradetails ed = new Extradetails();
            ed.Show();
            this.Hide();
        }

        private void txttitle_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsupername_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtworklocation_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtemername_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtemercity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtemerrelation_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtemeraddress_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            employee del = new employee();
            
                DialogResult dia = MessageBox.Show("Do you really want to delete this employee? \n Employee record will delete permenently",
                    "delete", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {




                    try
                    {
                        del.EmployeeID = Convert.ToInt32(txtretfulldata.Text);


                        del.Delete();
                        MessageBox.Show("data deleted");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (dia == DialogResult.No)
                {

                }
                    
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            ControlPanel cp = new ControlPanel();
            cp.Show();
            this.Hide();
        }

        private void btnaddemp_Click(object sender, EventArgs e)
        {
            employee addd = new employee();
            randomnumber = rnd.Next(1, 500);
            lblranid.Text = randomnumber.ToString();
            try
            {
                #region
                if (txtempname.Text=="")
                {
                    MessageBox.Show("please insert the Firstname");
                    
                    return;
                }
                else if(txtempfulname.Text=="")
                {
                    MessageBox.Show("please insert the lastname");
                   
                    return;
                }
                else if (txtempage.Text == "")
                {
                    MessageBox.Show("please insert the Age");

                    return;
                }
                else if (txtempcity.Text == "")
                {
                    MessageBox.Show("please insert the city");

                    return;
                }
                else if (txtempaddress.Text == "")
                {
                    MessageBox.Show("please insert the address");

                    return;
                }
               
                else if(masktxtempphone.Text=="")
                {
                    MessageBox.Show("please insert the phone");

                    return;
                }
                else if (txtempemail.Text == "")
                {
                    MessageBox.Show("please insert the email");
                    
                    return;
                }
                else if (txtempquali.Text == "")
                {
                    MessageBox.Show("please insert the Qualification");

                    return;
                }
                else if (txtempgender.Text == "")
                {
                    MessageBox.Show("please select gender");

                    return;
                }
                else if (txtempapply.Text == "")
                {
                    MessageBox.Show("please select apply for");

                    return;
                }
                else if (txtempexp.Text == "")
                {
                    MessageBox.Show("please select experience");

                    return;
                }
                else if (txtemplastcompany.Text == "")
                {
                    MessageBox.Show("please insert last company");

                    return;
                }
                else if (txtempmartial.Text == "")
                {
                    MessageBox.Show("please select Martial Status");

                    return;
                }
                else if (txtempextraskill.Text == "")
                {
                    MessageBox.Show("please insert the extraskills");

                    return;
                }
                //------------------------------------------
                 else  if (txttitle.Text == "")
                {
                    MessageBox.Show("please enter title");

                    return;
                }

                else if (txtsupername.Text == "")
                {
                    MessageBox.Show("please enter supervisor name");

                    return;
                }
                else if (txtworklocation.Text == "")
                {
                    MessageBox.Show("please enter worklocation");

                    return;
                }
                else if (txtempgivenemail.Text == "")
                {
                    MessageBox.Show("please enter email");

                    return;
                }
                else if (combosalary.Text == "")
                {
                    MessageBox.Show("please select salary");

                    return;
                }
                else if (txtemername.Text == "")
                {
                    MessageBox.Show("please enter  name");

                    return;
                }
                else if (txtemeraddress.Text == "")
                {
                    MessageBox.Show("please enter address");

                    return;
                }
                else if (txtemercity.Text == "")
                {
                    MessageBox.Show("please enter city");

                    return;
                }
                else if (masktxtemerphone.Text == "")
                {
                    MessageBox.Show("please enter Phone");

                    return;
                }
                else if (txtemerrelation.Text == "")
                {
                    MessageBox.Show("please enter RelationShip");

                    return;
                }
                #endregion
                else
                {
                    #region
                    /* SqlConnection mycon = new SqlConnection();
                    mycon.ConnectionString = "server=.;database=HRMproject;integrated security=true";
                    SqlCommand mycmd = new SqlCommand();
                    mycmd.Connection = mycon;
                    mycmd.CommandText = "insert into tbl_employee values (@eid,@ename,@elastname,@eage,@eaddress,@ephone,@eemail,@egender,@emstatus,@equlai,@eapply,@ejobexp,@elastcompany,@ecity,@eotherskill,@edatetime,@eday,@etitle,@esuper,@eworkloca,@ejobemail,@esalary,@eemername,@eemeraddress,@eemercity,@eemerphone,@eemerrelation)";

                    mycmd.Parameters.AddWithValue("@eid", lblranid);
                    mycmd.Parameters.AddWithValue("@ename", txtempname);

                    mycmd.Parameters.AddWithValue("@elastname", txtempfulname);
                    mycmd.Parameters.AddWithValue("@eage", txtempage);
                    mycmd.Parameters.AddWithValue("@eaddress", txtempaddress);
                    mycmd.Parameters.AddWithValue("@ephone", masktxtempphone);
                    mycmd.Parameters.AddWithValue("@eemail", txtempemail);
                    mycmd.Parameters.AddWithValue("@egender", txtempgender);
                    mycmd.Parameters.AddWithValue("@emstatus", txtempmartial);
                    mycmd.Parameters.AddWithValue("@equlai", txtempquali);
                    mycmd.Parameters.AddWithValue("@eapply", txtempapply);
                    mycmd.Parameters.AddWithValue("@ejobexp", txtempexp);
                    mycmd.Parameters.AddWithValue("@elastcompany", txtemplastcompany);
                    mycmd.Parameters.AddWithValue("@ecity", txtempcity);
                    mycmd.Parameters.AddWithValue("@eotherskill", txtempextraskill);
                    mycmd.Parameters.AddWithValue("@edatetime", lbldatetime);
                    mycmd.Parameters.AddWithValue("@eday", lblday2);
                    mycmd.Parameters.AddWithValue("@etitle", txttitle);
                    mycmd.Parameters.AddWithValue("@esuper", txtsupername);
                    mycmd.Parameters.AddWithValue("@eworkloca", txtworklocation);

                    mycmd.Parameters.AddWithValue("@ejobemail", txtempgivenemail);
                    mycmd.Parameters.AddWithValue("@esalary", combosalary);
                    mycmd.Parameters.AddWithValue("@eemername", txtemername);
                    mycmd.Parameters.AddWithValue("@eemeraddress", txtemeraddress);
                    mycmd.Parameters.AddWithValue("@eemercity", txtemercity);
                    mycmd.Parameters.AddWithValue("@eemerphone", masktxtemerphone);
                    mycmd.Parameters.AddWithValue("@eemerrelation", txtemerrelation);


                    mycon.Open();
                    int i = mycmd.ExecuteNonQuery();
                    mycon.Close();
                    if (i > 0)
                    {
                        throw new Exception("Record Insert");
                    }
                    else
                    {
                        throw new Exception("No Record");
                    }*/
                    #endregion
                    //Personal info
                    addd.EmployeeID = randomnumber;
                    addd.EmpFirstName = txtempname.Text;
                    addd.EmpLastName = txtempfulname.Text;
                    addd.EmpAge = Convert.ToInt32(txtempage.Text);
                    addd.EmpCity = txtempcity.Text;
                    addd.EmpAddress = txtempaddress.Text;
                    addd.EmpPhone = masktxtempphone.Text;
                    addd.EmpEmail = txtempemail.Text;
                    addd.EmpQulification = txtempquali.Text;
                    addd.EmpGender = txtempgender.Text;
                    addd.EmpMartialstatus = txtempmartial.Text;
                    addd.EmpAppllyfor = txtempapply.Text;
                    addd.EmpJobexper = txtempexp.Text;
                    addd.EmpLastcomppany = txtemplastcompany.Text;
                    addd.EmpDatetime = lbldatetime.Text;
                    addd.EmpDay = lblday2.Text;
                    addd.EmpOtherskills = txtempextraskill.Text;
                    //Job title
                    addd.EmpTitle = txttitle.Text;
                    addd.EmpSupervisor = txtsupername.Text;
                    addd.EmpWorklocation = txtworklocation.Text;
                    addd.EmpJobEmail = txtempgivenemail.Text;
                    //  addd.Empstartdate = txtstartdate.Text;
                    addd.EmpSalary = combosalary.Text;
                    //Emergency Contact's data

                    addd.EmergencyContact_Name = txtemername.Text;
                    addd.EmergencyContact_Address = txtemeraddress.Text;
                    addd.EmergencyContact_City = txtemercity.Text;
                    addd.EmergencyContact_Phone = masktxtemerphone.Text;
                    addd.EmergencyContact_Relation = txtemerrelation.Text;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            addd.insert();
            MessageBox.Show("Data inserted");
           
        }

        private void lbldatetime_Click(object sender, EventArgs e)
        {

        }
    }
}
