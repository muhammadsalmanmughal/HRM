using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DBproject
{
    class payroll:employee
    {
        private int _empid; 
        private string _firstname, _empfullname,_empsalary ,_day;

        public int EmployeeID
        {
            get { return _empid; }
            set { _empid = value; }
        }
        public string Empfullname
        {
            get { return _firstname; }
            set{_firstname= value;}
        }
        public string Empsalary
        {
            get { return _empsalary; }
            set { _empsalary = value; }
        }
      /*  public string Netpay
        {
            get { return _netpay; }
            set { _netpay = value; }
        }*/
        public string Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public string connect = "server=.; database=HRMproject;integrated security=true";
        public void insert()
        {
            string query = "insert into tbl_payroll (EmployeeID,Empfullname,Empsalary,Day) values (" + EmployeeID + ",'" + Empfullname + "', '" + Empsalary + "','" + Day + "')";
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
            myCmd.CommandText = "Select * from tbl_payroll";

            SqlDataAdapter myADP = new SqlDataAdapter();
            myADP.SelectCommand = myCmd;

            DataTable mydt = new DataTable();
            myADP.Fill(mydt);
            return mydt;

        }
    }
}
