using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DBproject
{
    class employee:candidate
    {
        private string _empname, _emplstname, _empaddress, _emphone, _empemail, _empgender, _empqulification, _empcity, _empdatetime, _empday, _empappllyfor, _empexeerp, _empllastcompany, _martialstatus, _otherskills;
        private string _emptitle, _empsuper, _empworkloca, _empjobmail, _empstartdate,_empsalary;//extra data
        private string _emerfname, _emeraddress, _emercity, _emerphone, _emerrelation;//emergency contact
        private int /*_empid,*/ _empage, _employeeID;
        


        //employee data
        #region

        /*  public int empid
        { get { return _empid; }
            set { _empid = value; }
        }*/
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        public int EmpAge
        {
            get { return _empage; }
            set
            {
                _empage = value;

            }
        }
        public string EmpFirstName
        {
            get { return _empname; }
            set
            {
                if (_empname == "")
                {
                    throw new Exception("Enter your valid name");
                }
                else
                {
                    _empname = value;
                }
            }
        }
        public string EmpLastName
        {
            get { return _emplstname; }
            set
            {
                if (_emplstname == "")
                {
                    throw new Exception("Enter your valid Last name");
                }
                else
                {
                    _emplstname = value;
                }
            }

        }
        public string EmpAddress
        {
            get { return _empaddress; }
            set
            {
                if (_empaddress == "")
                {
                    throw new Exception("Enter your valid address");
                }
                else
                {
                    _empaddress = value;
                }
            }

        }
        public string EmpPhone
        {
            get { return _emphone; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Enter your valid Phone number");
                }
                else
                {
                    _emphone = value;
                }
            }
        }
        public string EmpEmail
        {
            get { return _empemail; }
            set
            {
                if (_empemail == "")
                {
                    throw new Exception("Enter your valid email address");
                }
                else
                {
                    _empemail = value;
                }
            }
        }
        public string EmpGender
        {//ager kuch b select na ho to error shoe kese karen.
            get { return _empgender; }
            set { _empgender = value; }
        }
        public string EmpQulification
        {//ager kuch b select na ho to error shoe kese karen.
            get { return _empqulification; }
            set
            {
                if (_empqulification == "")
                {
                    throw new Exception("Choose your qualification first");
                }
                else
                {
                    _empqulification = value;
                }
            }
        }
        public string EmpAppllyfor
        {
            get { return _empappllyfor; }
            set
            {
                _empappllyfor = value;
            }
        }
        public string EmpJobexper
        {
            get { return _empexeerp; }
            set { _empexeerp = value; }
        }
        public string EmpLastcomppany
        {
            get { return _empllastcompany; }
            set { _empllastcompany = value; }
        }
        public string EmpCity
        {
            get { return _empcity; }
            set
            {
                if (_empcity == "")
                {
                    throw new Exception("Enter your valid city");
                }
                else
                {
                    _empcity = value;
                }
            }
        }
        public string EmpDatetime
        {
            get { return _empdatetime; }
            set { _empdatetime = value; }
        }
        public string EmpDay
        {
            get { return _empday; }
            set { _empday = value; }
        }
        public string EmpMartialstatus
        {
            get { return _martialstatus; }
            set { _martialstatus = value; }
        }
        public string EmpOtherskills
        {
            get { return _otherskills; }
            set { _otherskills = value; }
        }
       
        #endregion

        //employee extra data
        #region
        public string EmpTitle
        {
            get { return _emptitle; }
            set
            {
                if (_emptitle == "")
                {
                    throw new Exception("Enter Employee Job Title");
                }
                else
                {
                    _emptitle = value;
                }
            }
        }
        public string EmpSupervisor
        {
            get { return _empsuper; }
            set
            {
                if (_empsuper == "")
                {
                    throw new Exception("Enter Supervisor Name");
                }
                else
                {
                    _empsuper = value;
                }
            }
        }
        public string EmpWorklocation
        {
            get { return _empworkloca; }
            set
            {
                if (_empworkloca == "")
                { throw new Exception("Enter Employee Work Location"); }
                else
                {
                    _empworkloca = value;
                }
            }
        }
        public string EmpJobEmail
        {
            get { return _empjobmail; }
            set
            {
                if (_empjobmail == "")
                { throw new Exception("Enter Employee Given Email"); }
                else
                { _empjobmail = value; }
            }
        }
        public string Emptartdate
        {
            get { return _empstartdate; }
            set { _empstartdate = value; }
        }
        public string EmpSalary
        {
            get { return _empsalary; }
            set
            {
                _empsalary = value;
            }
        }
        #endregion

        //Employee Emergency Contact Member
        #region
        public string EmergencyContact_Name
        {
            get { return _emerfname; }
            set
            {
                if (_emerfname == "")
                { throw new Exception("Enter Employee Emergency contact's name"); }
                else
                {
                    _emerfname = value;
                }
            }
        }
        public string EmergencyContact_Address
        {
            get { return _emeraddress; }
            set
            {
                if (_emeraddress == "")
                { throw new Exception("Enter Emergency contact's Address"); }
                else
                {
                    _emeraddress = value;
                }
            }
        }
        public string EmergencyContact_City
        {
            get { return _emercity; }
            set
            {
                if (_emercity == "")
                { throw new Exception("Enter Emergency contact's City"); }
                else
                {
                    _emercity = value;
                }
            }
        }
        public string EmergencyContact_Phone
        {
            get { return _emerphone; }
            set
            {
                if (_emerphone == "")
                { throw new Exception("Enter Emergency contact's Phone number"); }
                else
                {
                    _emerphone = value;
                }
            }
        }
        public string EmergencyContact_Relation
        {
            get { return _emerrelation; }
            set
            {
                if (_emerrelation == "")
                { throw new Exception("Enter Emergency contact's Relation"); }
                else
                {
                    _emerrelation = value;
                }
            }
        }
        #endregion

        public DataTable showrecord()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = myCon;
            myCmd.CommandText = "Select * from tbl_employees";
            

            SqlDataAdapter myADP = new SqlDataAdapter();
            myADP.SelectCommand = myCmd;

            DataTable mydt = new DataTable();
            myADP.Fill(mydt);
            return mydt;

        }
       

        //public void Retrieve()
        //{

        //    SqlConnection myCon = new SqlConnection();
        //    myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";

        //    SqlCommand myCmd = new SqlCommand();
        //    myCmd.Connection = myCon;
        //    myCmd.CommandText = "Select * from tbl_candidate where Candidateid=candidateid";

        //    myCon.Open();

        //    myCmd.Parameters.AddWithValue("Candidateid", candidateid);
        //    SqlDataReader sqlReader = myCmd.ExecuteReader();

        //    while (sqlReader.Read())
        //    {

        //        Age = Convert.ToInt32(sqlReader.GetValue(1));
        //        FirstName = sqlReader.GetValue(2).ToString();
        //        LastName = sqlReader.GetValue(3).ToString();
        //        Gender = sqlReader.GetValue(4).ToString();
        //        ApplyFor = sqlReader.GetValue(5).ToString();
        //        City = sqlReader.GetValue(6).ToString();
        //        Address = sqlReader.GetValue(7).ToString();
        //        Phone = sqlReader.GetValue(8).ToString();
        //        Email = sqlReader.GetValue(9).ToString();
        //        Qualification = sqlReader.GetValue(10).ToString();
        //        Experience = sqlReader.GetValue(11).ToString();
        //        Lastcompany = sqlReader.GetValue(12).ToString();
        //        Date = sqlReader.GetValue(13).ToString();
        //        Day = sqlReader.GetValue(14).ToString();
        //        Martialstatus = sqlReader.GetValue(15).ToString();
        //        Otherskills = sqlReader.GetValue(16).ToString();
        //        /* EmpTitle = sqlReader.GetValue(17).ToString();
        //         EmpSupervisor = sqlReader.GetValue(18).ToString();
        //         EmpWorklocation = sqlReader.GetValue(19).ToString();
        //         EmpJobEmail = sqlReader.GetValue(20).ToString();
        //         EmpSalary = Convert.ToDouble(sqlReader.GetValue(21));
        //         EmergencyContact_Name = sqlReader.GetValue(22).ToString();
        //         EmergencyContact_Address = sqlReader.GetValue(23).ToString();
        //         EmergencyContact_City = sqlReader.GetValue(24).ToString();
        //         EmergencyContact_Phone = sqlReader.GetValue(25).ToString();
        //         EmergencyContact_Relation = sqlReader.GetValue(26).ToString();*/

        //    }
        //    sqlReader.Close();
        //    myCon.Close();
        //}

        public void Retrieve2(int eidd)
        {

            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = "server=.;database=HRMproject;integrated security=true";

            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = myCon;
            myCmd.CommandText = "Select * from tbl_employees where EmployeeID=" + eidd;
          
            myCon.Open();

            myCmd.Parameters.AddWithValue("EmployeeID", eidd);
            SqlDataReader sqlReader = myCmd.ExecuteReader();

            while (sqlReader.Read())
            { 
                EmpFirstName = sqlReader.GetValue(1).ToString();
                EmpLastName = sqlReader.GetValue(2).ToString();
                EmpAge = Convert.ToInt32(sqlReader.GetValue(3));
                EmpAddress = sqlReader.GetValue(4).ToString();
                EmpPhone = sqlReader.GetValue(5).ToString();
                EmpEmail = sqlReader.GetValue(6).ToString();
                EmpGender = sqlReader.GetValue(7).ToString();
                EmpMartialstatus = sqlReader.GetValue(8).ToString();
                EmpQulification = sqlReader.GetValue(9).ToString();
                EmpAppllyfor = sqlReader.GetValue(10).ToString();
                EmpJobexper = sqlReader.GetValue(11).ToString();
                EmpLastcomppany = sqlReader.GetValue(12).ToString();
                EmpCity = sqlReader.GetValue(13).ToString();
                EmpOtherskills = sqlReader.GetValue(14).ToString();
   
                Date = sqlReader.GetValue(15).ToString();
                Day = sqlReader.GetValue(16).ToString();
                      
                EmpTitle = sqlReader.GetValue(17).ToString();
                EmpSupervisor = sqlReader.GetValue(18).ToString();
                EmpWorklocation = sqlReader.GetValue(19).ToString();
                EmpJobEmail = sqlReader.GetValue(20).ToString();
                EmpSalary = sqlReader.GetValue(21).ToString();
                EmergencyContact_Name = sqlReader.GetValue(22).ToString();
                EmergencyContact_Address = sqlReader.GetValue(23).ToString();
                EmergencyContact_City = sqlReader.GetValue(24).ToString();
                EmergencyContact_Phone = sqlReader.GetValue(25).ToString();
                EmergencyContact_Relation = sqlReader.GetValue(26).ToString();

            }
            sqlReader.Close();
            myCon.Close();
        }

        public string connect = "server=.; database=HRMproject;integrated security=true";
        public void insert()
        {
           
         
            string query = "insert into tbl_employees(EmployeeID,EmpFirstName,EmpLastName,EmpAge,EmpAddress,EmpPhone,EmpEmail,EmpGender,EmpMartialstatus,EmpQulification,EmpAppllyfor,EmpJobexper,EmpLastcomppany,EmpCity,EmpOtherskills,EmpDatetime,EmpDay,EmpTitle,EmpSupervisor,EmpWorklocation,EmpJobEmail,EmpSalary,EmergencyContact_Name,EmergencyContact_Address,EmergencyContact_City,EmergencyContact_Phone,EmergencyContact_Relation)  values (" + EmployeeID + ", '" + EmpFirstName + "','" + EmpLastName + "'," + EmpAge + ",'" + EmpAddress + "','" + EmpPhone + "','" + EmpEmail + "','" + EmpGender + "', '" + EmpMartialstatus + "','" + EmpQulification + "','" + EmpAppllyfor + "','" + EmpJobexper + "','" + EmpLastcomppany + "','" + EmpCity + "','" + EmpOtherskills + "','" + EmpDatetime + "','" + EmpDay + "','" + EmpTitle + "','" + EmpSupervisor + "', '" + EmpWorklocation + "','" + EmpJobEmail + "','" + EmpSalary + "','" + EmergencyContact_Name + "','" + EmergencyContact_Address + "', '" + EmergencyContact_City + "','" + EmergencyContact_Phone + "','" + EmergencyContact_Relation + "')";
            
            SqlConnection sqlcon = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, sqlcon);

           
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
          
        }



       /* public void insert()
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = "server=.;database=HRMproject;integrated security=true";
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "insert into tbl_employee values (@eid,@ename,@elastname,@eage,@eaddress,@ephone,@eemail,@egender,@emstatus,@equlai,@eapply,@ejobexp,@elastcompany,@ecity,@eotherskill,@edatetime,@eday,@etitle,@esuper,@eworkloca,@ejobemail,@esalary,@eemername,@eemeraddress,@eemercity,@eemerphone,@eemerrelation)";

            mycmd.Parameters.AddWithValue("@eid", EmployeeID);
            mycmd.Parameters.AddWithValue("@ename", EmpFirstName);

            mycmd.Parameters.AddWithValue("@elastname", EmpLastName);
            mycmd.Parameters.AddWithValue("@eage", EmpAge);
            mycmd.Parameters.AddWithValue("@eaddress", EmpAddress);
            mycmd.Parameters.AddWithValue("@ephone", EmpPhone);
            mycmd.Parameters.AddWithValue("@eemail", EmpEmail);
            mycmd.Parameters.AddWithValue("@egender", EmpGender);
            mycmd.Parameters.AddWithValue("@emstatus", EmpMartialstatus);
            mycmd.Parameters.AddWithValue("@equlai", EmpQulification);
            mycmd.Parameters.AddWithValue("@eapply", EmpAppllyfor);
            mycmd.Parameters.AddWithValue("@ejobexp", EmpJobexper);
            mycmd.Parameters.AddWithValue("@elastcompany", EmpLastcomppany);
            mycmd.Parameters.AddWithValue("@ecity", EmpCity);
            mycmd.Parameters.AddWithValue("@eotherskill", EmpOtherskills);
            mycmd.Parameters.AddWithValue("@edatetime", EmpDatetime);
            mycmd.Parameters.AddWithValue("@eday", EmpDay);
            mycmd.Parameters.AddWithValue("@etitle", EmpTitle);
            mycmd.Parameters.AddWithValue("@esuper", EmpSupervisor);
            mycmd.Parameters.AddWithValue("@eworkloca", EmpWorklocation);

             mycmd.Parameters.AddWithValue("@ejobemail", EmpJobEmail);
            mycmd.Parameters.AddWithValue("@esalary", EmpSalary);
            mycmd.Parameters.AddWithValue("@eemername", EmergencyContact_Name);
            mycmd.Parameters.AddWithValue("@eemeraddress", EmergencyContact_Address);
            mycmd.Parameters.AddWithValue("@eemercity", EmergencyContact_City);
            mycmd.Parameters.AddWithValue("@eemerphone", EmergencyContact_Phone);
            mycmd.Parameters.AddWithValue("@eemerrelation", EmergencyContact_Relation);


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
            }

        }*/

        public void Delete()
        {
            string query = "delete from tbl_employees where EmployeeID=" + EmployeeID;
           SqlConnection sql = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, sql);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }







    }
}
