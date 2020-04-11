using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace DBproject
{
    class ClsOC:employee
    {
        private int _jID;
        private string _position, _status;

        public int JOBID
        {
            get { return _jID; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Job ID can't be a negative value or zero");
                }
                else
                {
                    _jID = value;
                }
            }
        }

        public string POSITION
        {
            get { return _position; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Please enter valid position");
                }
                else
                {
                    _position = value;
                }
            }
        }

        public string STATUS
        {
            get { return _status; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Invalid Status");
                }
                else
                {
                    _status = value;
                }
            }
        }


        /*  private static List<ClsOC> _lstOC = new List<ClsOC>();
          public static List<ClsOC> LstOC
          {
              get { return _lstOC; }
              set { _lstOC = value; }
          }*/

        public void Create()
        {

           // int jobid;
            //string position, status;
        }

        public string sql = "server=.;database=HRMproject;integrated security=true";

      /*  public void insert(string jobid, string position, string status)
        {
            string query = "insert into tbl_OC values('" + jobid + "','" + position + "','" + status + "') ";
            SqlConnection sql = new SqlConnection();
            SqlCommand cmd = new SqlCommand(query, sql);

            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }
        public void Delete(int jobid)
        {
            string query = "delete from tbl_OC where id=" + jobid;
            SqlConnection sql = new SqlConnection();
            SqlCommand cmd = new SqlCommand(query, sql);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        public void Update()
        {
            string query = "update tbl_OC set JOBID='" + JOBID + "',Position='" + POSITION + "',status='" + STATUS + "' where jobid = '" + JOBID + "'";
            SqlConnection sql = new SqlConnection();
            SqlCommand cmd = new SqlCommand(query, sql);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }
        public static void ExecuteQuery(string query)
        {
            string executequery = "server = .; Database = HRM; integrated security = true";
            SqlConnection con = new SqlConnection(executequery);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
        }

        */

      /*  public void Retrieve2()
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";

            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = myCon;
            myCmd.CommandText = "Select * from tbl_employees where EmployeeID=EmployeeID";

            myCon.Open();

            myCmd.Parameters.AddWithValue("EmployeeID", EmployeeID);
            SqlDataReader sqlReader = myCmd.ExecuteReader();

            while (sqlReader.Read())
            {

                EmpTitle = sqlReader.GetValue(17).ToString();
                EmpSupervisor = sqlReader.GetValue(18).ToString();
                EmpWorklocation = sqlReader.GetValue(19).ToString();
                EmpJobEmail = sqlReader.GetValue(20).ToString();
                EmpSalary = Convert.ToDouble(sqlReader.GetValue(21));
                EmergencyContact_Name = sqlReader.GetValue(22).ToString();
                EmergencyContact_Address = sqlReader.GetValue(23).ToString();
                EmergencyContact_City = sqlReader.GetValue(24).ToString();
                EmergencyContact_Phone = sqlReader.GetValue(25).ToString();
                EmergencyContact_Relation = sqlReader.GetValue(26).ToString();

            }
            sqlReader.Close();
            myCon.Close();
        }*/

        public void retrieve()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";

            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = myCon;
            myCmd.CommandText = "Select * from tbl_employees where EmployeeID=" + EmployeeID;

            myCon.Open();

            myCmd.Parameters.AddWithValue("EmployeeID", EmployeeID);
            SqlDataReader sqlReader = myCmd.ExecuteReader();

            while (sqlReader.Read())
            {

               
                FirstName = sqlReader.GetValue(1).ToString();
                LastName = sqlReader.GetValue(2).ToString();
                Gender = sqlReader.GetValue(3).ToString();
               
                EmpTitle = sqlReader.GetValue(4).ToString();
               

            }
            sqlReader.Close();
            myCon.Close();
        }

        public DataTable showrecord()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = myCon;
            myCmd.CommandText = "Select EmpFirstName,EmpLastName,EmpTitle from tbl_employees";

            SqlDataAdapter myADP = new SqlDataAdapter();
            myADP.SelectCommand = myCmd;

            DataTable mydt = new DataTable();
            myADP.Fill(mydt);
            return mydt;

        }


    }
}
