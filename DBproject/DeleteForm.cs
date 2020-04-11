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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            CandidateForm cf = new CandidateForm();
            cf.Show();
            this.Hide();
        }

        private void btnretrive_Click(object sender, EventArgs e)
        {
            candidate ret = new candidate();
            try
            {
                int cid = Convert.ToInt32(txtdelcanid.Text);
                ret.Retrieve(cid);
                /* txtproductname.Text = pr.ProductName;
                 txtcategoryid.Text = pr.CategoryID.ToString();
                 txtproductquantity.Text = pr.ProductQuantity.ToString();*/

                txtdelfirstname.Text = ret.FirstName;
                txtdellastname.Text = ret.LastName;
                txtdelage.Text = ret.Age.ToString();
                txtdelemail.Text = ret.Email;
                txtdelcity.Text = ret.City;
                txtdeladdress.Text = ret.Address;
                masktxtdelphone.Text = ret.Phone;
                //  add.martialstatus = combomar.Text;
                txtdelquali.Text = ret.Qualification;
                combodelgender.Text = ret.Gender;
                //  lbldate.Text = ret.Date;
                txtdelday.Text = ret.Day;
                combodelapply.Text = ret.ApplyFor;
                combodelexper.Text = ret.Experience.ToString();

                txtdellastcompany.Text = ret.Lastcompany;
                txtdeldatetime.Text = ret.Date;
                combomar.Text = ret.Martialstatus;
                txtextraskill.Text = ret.Otherskills;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            txtdelfirstname.Enabled = false;
            txtdellastname.Enabled = false;
            txtdelage.Enabled = false;
            txtdeladdress.Enabled = false;
            txtdelcity.Enabled = false;
            masktxtdelphone.Enabled = false;
            txtdelemail.Enabled = false;
            txtdelquali.Enabled = false;
            combodelgender.Enabled = false;
            // combodelmar.Enabled = false;
            combodelapply.Enabled = false;
            combodelexper.Enabled = false;
            txtdellastcompany.Enabled = false;
            txtdeldatetime.Enabled = false;
            txtdelday.Enabled = false;
            combomar.Enabled = false;
            txtextraskill.Enabled = false;

           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            candidate del = new candidate();
            DialogResult dia = MessageBox.Show("Do you really want to delete this candidate data? \n Candidate record will delete permenently",
                    "delete", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
            try
            {
                del.candidateid = Convert.ToInt32(txtdelcanid.Text);


                del.Delete();
                MessageBox.Show("data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                }
             else if(dia == DialogResult.No)
                    {

                    }
        }
    }
    
}
