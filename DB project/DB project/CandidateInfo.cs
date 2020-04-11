using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project
{
    public partial class CandidateInfo : Form
    {
        candidate can = new candidate();
        public CandidateInfo()
        {
            InitializeComponent();
        }
         public void Clearfield()
        {

            txtcanid.Text="";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtage.Text = "";
            txtemail.Text = "";
            txtcity.Text = "";
            txtaddress.Text = "";
            masktxtphone.Text = "";
            comboapply.Text = "";
            combogender.Text = "";
            //combomar.Text = "";
            comboexper.Text = "";
            txtquali.Text = "";
            txtlastcompany.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void btnaddcan_Click(object sender, EventArgs e)
        {
            #region
            /* SqlConnection myConn = new SqlConnection();
             myConn.ConnectionString = "server=.; database=HRMproject; integrated security=true";

             SqlCommand myCmd = new SqlCommand();
             myCmd.Connection = myConn;
             string query = "";
             myCmd.CommandText = "insert into tbl_Candidate(CandidateID,FirstName,LastName,Gender,ApplyFor,Age,City,Address,Phone,Email,Qualification,Experience,LastCompany,Date,Time)  values (@CandidateID,@FirstName,@LastName,@Age,@Gender,@ApplyFor,@City,@Address,@Phone,@Email,@Qualification,@Experience,@LastCompany,@Date,@Time)";
             
            myCmd.Parameters.AddWithValue("@CandidateID",Convert.ToInt32(txtcanid.Text));
             myCmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
             myCmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
             myCmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtage.Text));
             myCmd.Parameters.AddWithValue("@Gender", combogender.Text);
             myCmd.Parameters.AddWithValue("@City", txtcity.Text);
             myCmd.Parameters.AddWithValue("@Address", txtaddress.Text);
             myCmd.Parameters.AddWithValue("@Qualification", txtquali.Text);
             myCmd.Parameters.AddWithValue("@ApplyFor", comboapply.Text);
             myCmd.Parameters.AddWithValue("@Experience", comboexper.Text);
             myCmd.Parameters.AddWithValue("@LastCompany", txtlastcompany.Text);

             myCmd.Parameters.AddWithValue("@Phone", masktxtphone.Text);
             myCmd.Parameters.AddWithValue("@Email", txtemail.Text);
             myCmd.Parameters.AddWithValue("@Date", lbldate.Text);
             myCmd.Parameters.AddWithValue("@Time", lbltime.Text);

             myConn.Open();
             int i = myCmd.ExecuteNonQuery();
             myConn.Close();
             if (i > 0)
                 MessageBox.Show("record inserted");
             else
                 MessageBox.Show("no record inserted");
             showRecord();
             */
            #endregion
            candidate add = new candidate();
            try
            {
                add.firstname = txtfirstname.Text;
                add.lasttname = txtlastname.Text;
                add.age = Convert.ToInt32(txtage.Text);
                add.email = txtemail.Text;
                add.city = txtcity.Text;
                add.address = txtaddress.Text;
                add.phone = masktxtphone.Text;
                // add.martialstatus = combomar.Text;
                add.qualification = txtquali.Text;
                add.gender = combogender.Text;
                add.date = lbldate.Text;
                add.time = lbltime.Text;
                add.Applyfor = comboapply.Text;
                add.Experience = comboexper.Text;
                add.id = Convert.ToInt16(txtcanid.Text);
                add.Lastcompany = txtlastcompany.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                add.insert();
                Clearfield();
                dataGridView1.DataSource = can.showrecord();            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

        }
        #region
        /* public void showRecord()
          {
              SqlConnection myConn = new SqlConnection();
              myConn.ConnectionString = "server=.; database=HRMproject; integrated security=true";

              SqlCommand myCmd = new SqlCommand();
              myCmd.Connection = myConn;
              myCmd.CommandText = "Select * from tbl_Candidate";

              SqlDataAdapter myADP = new SqlDataAdapter();
              myADP.SelectCommand = myCmd;

              DataTable mydt = new DataTable();
              myADP.Fill(mydt);

              dataGridView1.DataSource = mydt;
          }

          private void CandidateInfo_Load(object sender, EventArgs e)
          {
              showRecord();
          }*/
        #endregion

        #region
        /*  candidate add = new candidate();
              add.firstname = txtfirstname.Text;
              add.lasttname = txtlastname.Text;
              add.age = Convert.ToInt32(txtage.Text);
              add.email = txtemail.Text;
              add.city = txtcity.Text;
              add.address = txtaddress.Text;
              add.phone = masktxtphone.Text;
             // add.martialstatus = combomar.Text;
              add.qualification = txtquali.Text;
              add.gender = combogender.Text;
              add.date = lbldate.Text;
              add.time = lbltime.Text;
              add.Applyfor = comboapply.Text;
              add.Experience = comboexper.Text;
              add.id = Convert.ToInt16(txtcanid.Text);
              add.Lastcompany = txtlastcompany.Text;

              add.insert();

          }*/
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void CandidateInfo_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();

            dataGridView1.DataSource = can.showrecord();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "server=.; database=HRMproject; integrated security=true";
            //mene yaha per sql table me jo nam likhe hn wo likhe hn [" "] me
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            txtcanid.Text = row.Cells["CandidateID"].Value.ToString();
            txtfirstname.Text = row.Cells["FirstName"].Value.ToString();
            txtlastname.Text = row.Cells["LastName"].Value.ToString();
            combogender.Text = row.Cells["Gender"].Value.ToString();
            comboapply.Text = row.Cells["ApplyFor"].Value.ToString();
            txtage.Text = row.Cells["Age"].Value.ToString();
            txtcity.Text = row.Cells["City"].Value.ToString();
            txtaddress.Text = row.Cells["Address"].Value.ToString();
            masktxtphone.Text = row.Cells["Phone"].Value.ToString();
            txtemail.Text = row.Cells["Email"].Value.ToString();
            txtquali.Text = row.Cells["Qualification"].Value.ToString();
            comboexper.Text = row.Cells["Experience"].Value.ToString();
            txtlastcompany.Text = row.Cells["LastCompany"].Value.ToString();
            lbldate.Text = row.Cells["Date"].Value.ToString();
            lbltime.Text = row.Cells["Time"].Value.ToString();

        }
    }

}
