using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace DBproject
{
    class candidate
    {
       
        private int _candidateid, _age;
        private string _firstname, _lastname, _gender, _applyfor, _city, _address, _phone, _email, _qualification, _experience, _lastcompany, _date, _day, _martialstatus, _otherskills;

        public int candidateid
        {

            get { return _candidateid; }
            set { _candidateid = value; }
        }

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                if (_firstname == "")
                {
                    throw new Exception("Enter your valid name");
                }
                else
                {
                    _firstname = value;
                }
            }
        }

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (_lastname == "")
                {
                    throw new Exception("Enter your valid Last name");
                }
                else
                {
                    _lastname = value;
                }
            }

        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Enter your valid Phone number");
                }
                else
                {
                    _phone = value;
                }
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (_city == "")
                {
                    throw new Exception("Enter your valid city");
                }
                else
                {
                    _city = value;
                }
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (_address == "")
                {
                    throw new Exception("Enter your valid address");
                }
                else
                {
                    _address = value;
                }
            }

        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email == "")
                {
                    throw new Exception("Enter your valid email address");
                }
                else
                {
                    _email = value;
                }
            }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (_age < 23 && _age >= 60)
                {
                    throw new Exception("Age should be greater then 23 and less then 60");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string Qualification
        {
            get { return _qualification; }
            set
            {
                if (_qualification == "")
                {
                    throw new Exception("Choose your qualification first");
                }
                else
                {
                    _qualification = value;
                }
            }
        }

        public string ApplyFor
        {
            get { return _applyfor; }
            set
            {
                if (_applyfor == "")
                {
                    throw new Exception("Select the position your are apply for");
                }
                else
                {
                    _applyfor = value;
                }
            }
        }

        public string Experience
        {

            get { return _experience; }
            set
            {
                if (_experience == "")
                {
                    throw new Exception("Enter yourJob Experience");
                }
                else
                {
                    _experience = value;
                }
            }
        }

        public string Lastcompany
        {
            get { return _lastcompany; }
            set
            {
                if (_lastcompany == "")
                {
                    throw new Exception("Enter your lastcompany name");
                }
                else
                {
                    _lastcompany = value;
                }
            }
        }

        public string Martialstatus
        {
            get { return _martialstatus; }
            set { _martialstatus = value; }
        }
        public string Otherskills
        {
            get { return _otherskills; }
            set { _otherskills = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public string connect = "server=.; database=HRMproject;integrated security=true";
        public void insert()
        {
            string query = "insert into tbl_candidate (Candidateid,Age,FirstName,LastName,Gender,ApplyFor,City,Address,Phone,Email,Qualification,Experience,Lastcompany,Date,Day,Martialstatus,Otherskills) values (" + candidateid + "," + Age + ", '" + FirstName + "','" + LastName + "','" + Gender + "','" + ApplyFor + "','" + City + "','" + Address + "', '" + Phone + "','" + Email + "','" + Qualification + "','" + Experience + "','" + Lastcompany + "','" + Date + "','" + Day + "','" + Martialstatus + "','" + Otherskills + "')";
            SqlConnection sqlcon = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();

        }

        public void Delete()
        {
            string query = "delete from tbl_candidate where Candidateid=" + candidateid;
            SqlConnection sql = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, sql);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        public DataTable showrecord()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = myCon;
            myCmd.CommandText = "Select * from tbl_candidate";
            SqlDataAdapter myADP = new SqlDataAdapter();
            myADP.SelectCommand = myCmd;

            DataTable mydt = new DataTable();
            myADP.Fill(mydt);
            return mydt;

        }

        public void Retrieve(int cid)
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";

            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = myCon;
            myCmd.CommandText = "Select * from tbl_candidate where Candidateid=" + cid;

            myCon.Open();

            myCmd.Parameters.AddWithValue("Candidateid", cid);
            SqlDataReader sqlReader = myCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                Age = Convert.ToInt32(sqlReader.GetValue(1));
                FirstName = sqlReader.GetValue(2).ToString();
                LastName = sqlReader.GetValue(3).ToString();
                Gender = sqlReader.GetValue(4).ToString();
                ApplyFor = sqlReader.GetValue(5).ToString();
                City = sqlReader.GetValue(6).ToString();
                Address = sqlReader.GetValue(7).ToString();
                Phone = sqlReader.GetValue(8).ToString();
                Email = sqlReader.GetValue(9).ToString();
                Qualification = sqlReader.GetValue(10).ToString();
                Experience = sqlReader.GetValue(11).ToString();
                Lastcompany = sqlReader.GetValue(12).ToString();
                Date = sqlReader.GetValue(13).ToString();
                Day = sqlReader.GetValue(14).ToString();
                Martialstatus = sqlReader.GetValue(15).ToString();
                Otherskills = sqlReader.GetValue(16).ToString();

            }
            sqlReader.Close();
            myCon.Close();
        }
    
    }
}
