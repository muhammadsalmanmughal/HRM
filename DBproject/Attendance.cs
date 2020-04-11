using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DBproject
{
    class Attendance:employee
    {
        private int _empid;
        private string _firstname, _lastname, _title, _location,_empfunction;

        public int EmployeeID
        {
            get { return _empid; }
            set { _empid =value; }
        }
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public string EmployeeIs
        {
            get { return _empfunction; }
            set { _empfunction = value; }
        }


        public string connect = "server=.; database=HRMproject;integrated security=true";
        public void insert()
        {
            string query = "insert into tbl_attendance (EmployeeID,FirstName,LastName,Title,Location,EmployeeIs) values (" + EmployeeID + ",'" + FirstName + "', '" + LastName + "','" + Title + "','" +Location + "','" + EmployeeIs + "')";
            SqlConnection sqlcon = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();

        }

       
        public DataTable showrecord()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = myCon;
            myCmd.CommandText = "Select * from tbl_attendance";

            SqlDataAdapter myADP = new SqlDataAdapter();
            myADP.SelectCommand = myCmd;

            DataTable mydt = new DataTable();
            myADP.Fill(mydt);
            return mydt;

        }
    }
}
