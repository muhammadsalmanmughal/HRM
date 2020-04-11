using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB_project
{
    class candidate
    {
        private string _firstname, _lstname, _address, _email, _gender,/* _martialstatus,*/ _phone, _qualification, _city, _date, _time, _lastcompany, _jobexp, _applyfor;
        private int _candidateid, _age;

        public int id
        {

            get { return _candidateid; }
            set { _candidateid = value; }
        }

        public string firstname
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

        public string lasttname
        {
            get { return _lstname; }
            set
            {
                if (_lstname == "")
                {
                    throw new Exception("Enter your valid Last name");
                }
                else
                {
                    _lstname = value;
                }
            }

        }

        public string phone
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

        public string city
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

       public string address
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

        public string email
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

        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int age
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

        public string qualification
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

        public string Applyfor
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

            get { return _jobexp; }
            set
            {
                if (_jobexp == "")
                {
                    throw new Exception("Enter yourJob Experience");
                }
                else
                {
                    _jobexp = value;
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

      /*  public string martialstatus
        {
            get { return _martialstatus; }
            set { _martialstatus = value; }
        }*/



        public string date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string time
        {
            get { return _time; }
            set { _time = value; }
        }

         public string  connect = "server=.; database=HRMproject; integrated security=true";

        SqlConnection mycon = new SqlConnection();
        public void insert()
        {
            #region
            //(CandidateID,FirstName,LastName,Gender,ApplyFor,Age,City,Address,Phone,Email,Qualification,Experience,LastCompany,Date,Time)
             string query = "insert into tbl_Candidate values(" + id + ",'" + firstname + "','" + lasttname + "','" + gender + "','" + Applyfor + "','" + age + "' ,'" + city + "','" + address + "','" + phone + "','" + email + "','" + qualification + "','" + Experience + "','" + Lastcompany + "','" + date + "','"+time+"')";
            SqlConnection sqlcon = new SqlConnection();
             SqlCommand comm = new SqlCommand(query, sqlcon);
             sqlcon.Open();
             comm.ExecuteNonQuery();
             sqlcon.Close();
            #endregion

           #region
          /*   mycon.ConnectionString = "server=.;database=HRMproject;integrated security=true";
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            //(CandidateID, FirstName, LastName, Gender, ApplyFor, Age, City, Address, Phone, Email, Qualification, Experience, LastCompany, Date, Time);
            mycmd.CommandText = "insert into tbl_Candidate  values (@CandidateID,@FirstName,@LastName,@Age,@Gender,@ApplyFor,@City,@Address,@Phone,@Email,@Qualification,@Experience,@LastCompany,@Date,@Time)";
            mycmd.Parameters.AddWithValue("@CandidateID",id );
            mycmd.Parameters.AddWithValue("@FirstName", firstname);
            mycmd.Parameters.AddWithValue("@LastName", lasttname);
            mycmd.Parameters.AddWithValue("@Gender", gender);
            mycmd.Parameters.AddWithValue("@ApplyFor", Applyfor);
            mycmd.Parameters.AddWithValue("@Age", age);           
            mycmd.Parameters.AddWithValue("@City", city);
            mycmd.Parameters.AddWithValue("@Address", address);
            mycmd.Parameters.AddWithValue("@Phone", phone);
            mycmd.Parameters.AddWithValue("@Email", email);
            mycmd.Parameters.AddWithValue("@Qualification", qualification);
            mycmd.Parameters.AddWithValue("@Experience", Experience);
            mycmd.Parameters.AddWithValue("@LastCompany", Lastcompany);
            mycmd.Parameters.AddWithValue("@Date", date);
            mycmd.Parameters.AddWithValue("@Time", time);

            mycon.Open();
            int i = mycmd.ExecuteNonQuery();
            mycon.Close();
            if (i > 0)
                throw new Exception("record inserted");
            else
                throw new Exception("no record inserted");*/
            #endregion

        }




        public DataTable showrecord()
        {
            mycon.ConnectionString = "server=.;database=HRMproject;integrated security=true";
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = mycon;
            myCmd.CommandText = "Select * from tbl_Candidate";
            SqlDataAdapter myADP = new SqlDataAdapter();
            myADP.SelectCommand = myCmd;
            DataTable mydt = new DataTable();

            myADP.Fill(mydt);
            return mydt;


        }
    }
}
