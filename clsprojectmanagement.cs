using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeProjectAssign
{
    public class clsprojectmanagement
    {
        SqlConnection Con = new SqlConnection("Data Source=INBOOK_X1_NEO;Initial Catalog=ProjectManagementASP;Integrated Security=True");
        public int UserId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Typeid { get; set; }
        public int Productid { get; set; }
        public string Phoneno { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
     
        public int CityID { get; set; }

        public string Passward { get; set; }
        public string Status { get; set; }
      
        public int Sizeid { get; set; }
        public string Date { get; set; }
        public int Id { get; set; }
        public int Projectid { get; set; }
        public int Employeeid { get; set; }
        public int Amount { get; set; }




        public string Projecttype { get; set; }
        public string Projectname { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }


        public clsprojectmanagement(string type,string name, string email,string phoneno,string gender,int city, string passward)
        {
            Type = type;
            Name = name;
            Email = email;     
            Phoneno = phoneno;
            Gender = gender;

            CityID = city;          
            Passward = passward;
        }
        public clsprojectmanagement()
        {

        }
        public clsprojectmanagement(string projecttype,string projectname,DateTime startdate,DateTime enddate)
        {
            Projecttype=projecttype;
            Projectname=projectname;
            Startdate=startdate;
            Enddate=enddate;
        }
        public clsprojectmanagement(int countryid)
        {
            Id=countryid;
        }
        public clsprojectmanagement(string email,string passward)
        {
            Email=email;
            Passward=passward;
        }
        public void Savedata()
        {
            Con.Open();
            SqlCommand cnd = new SqlCommand("SProjectManagement", Con);
            cnd.CommandType = CommandType.StoredProcedure;
            cnd.Parameters.AddWithValue("@Flag", "Savedata");
            cnd.Parameters.AddWithValue("@type", Type);
            cnd.Parameters.AddWithValue("@name", Name);
            cnd.Parameters.AddWithValue("@email", Email);
            cnd.Parameters.AddWithValue("@phoneno", Phoneno);
            cnd.Parameters.AddWithValue("@gender", Gender);          
            cnd.Parameters.AddWithValue("@cityid", CityID);
            cnd.Parameters.AddWithValue("@password", Passward);           
            cnd.ExecuteReader();          
            Con.Close();
        }
        public void saveprojecttype()
        {
            Con.Open();
            SqlCommand cnd = new SqlCommand("SProjectManagement", Con);
            cnd.CommandType = CommandType.StoredProcedure;
            cnd.Parameters.AddWithValue("@Flag", "saveprojecttype");
            cnd.Parameters.AddWithValue("@Projecttype", Projecttype);
            cnd.Parameters.AddWithValue("@ProjectName", Projectname);
            cnd.Parameters.AddWithValue("@startdate", Startdate);
            cnd.Parameters.AddWithValue("@Enddate", Enddate);           
            cnd.ExecuteReader();
            Con.Close();
        }
        public DataTable GetCountry()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCountry");  
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public DataTable GetState()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetState");
            cmd.Parameters.AddWithValue("@CountryID",Id);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public DataTable GetCity()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCity");
            cmd.Parameters.AddWithValue("@StateID", Id);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public DataTable getallproject()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getallproject");         
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public SqlDataReader login()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "login");
            cmd.Parameters.AddWithValue("@email",Email );
            cmd.Parameters.AddWithValue("@password", Passward);
            SqlDataReader dr ;
            dr=cmd.ExecuteReader();
            return dr;
            Con.Close();
        }
        public DataTable getproject()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getproject");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public DataTable getprojectmanagername()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getprojectmanagername");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public clsprojectmanagement(int projectid,int employeeid,string status)
        {
            Projectid = projectid;
            Employeeid = employeeid;
            Status = status;
        }
        public void AssignProject()
        {
            Con.Open();
            SqlCommand cnd = new SqlCommand("SProjectManagement", Con);
            cnd.CommandType = CommandType.StoredProcedure;
            cnd.Parameters.AddWithValue("@Flag", "AssignProject");
            cnd.Parameters.AddWithValue("@projectId", Projectid);
            cnd.Parameters.AddWithValue("@employeeid", Employeeid);
            cnd.Parameters.AddWithValue("@status", Status);
            cnd.Parameters.AddWithValue("@assindate",DateTime.Now);
            cnd.ExecuteReader();
            Con.Close();
        }
        public DataTable assignteamleadprojectname()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "assignteamleadprojectname");
            cmd.Parameters.AddWithValue("@employeeid", Id);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public DataTable getteamleadname()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getteamleadname");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }

       
        public void assignteamleadproject()
        {
            Con.Open();
            SqlCommand cnd = new SqlCommand("SProjectManagement", Con);
            cnd.CommandType = CommandType.StoredProcedure;
            cnd.Parameters.AddWithValue("@Flag", "assignteamleadproject");
            cnd.Parameters.AddWithValue("@projectId", Projectid);
            cnd.Parameters.AddWithValue("@TLEmployeeid", Employeeid);
            cnd.Parameters.AddWithValue("@status", Status);
            cnd.Parameters.AddWithValue("@assindate", DateTime.Now);
            cnd.ExecuteReader();
            Con.Close();
        }
        public clsprojectmanagement(string emailid)
        {
            Email=emailid;
        }
        public SqlDataReader getteamleadalldata()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getteamleadalldata");
            cmd.Parameters.AddWithValue("@email", Email);
            SqlDataReader dr;
            dr=cmd.ExecuteReader();        
            return dr;
            Con.Close();
        }
        public DataTable getcompleteprojectdetails()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SProjectManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "getcompleteprojectdetails");
            cmd.Parameters.AddWithValue("@employeeid", Id);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }

      public  clsprojectmanagement  (int projectid,string status)
        {
            Projectid = projectid;
            Status = status;
           

        }

        public void completetask()
        {
            Con.Open();
            SqlCommand cnd = new SqlCommand("SProjectManagement", Con);
            cnd.CommandType = CommandType.StoredProcedure;
            cnd.Parameters.AddWithValue("@Flag", "completetask");
            cnd.Parameters.AddWithValue("@projectId", Projectid);
       
            cnd.Parameters.AddWithValue("@status", Status);
            cnd.Parameters.AddWithValue("@assindate", DateTime.Now);
            cnd.ExecuteReader();
            Con.Close();
        }

        public clsprojectmanagement(int projectid,int employeeid,int amount,string status)
        {
            Projectid=projectid;
            Employeeid=employeeid;
            Amount=amount;
            Status=status;

        }
        public void paymentdatasave()
        {
            Con.Open();
            SqlCommand cnd = new SqlCommand("SProjectManagement", Con);
            cnd.CommandType = CommandType.StoredProcedure;
            cnd.Parameters.AddWithValue("@Flag", "paymentdatasave");
            cnd.Parameters.AddWithValue("@TLEmployeeid", Employeeid);
            cnd.Parameters.AddWithValue("@projectId", Projectid);
            cnd.Parameters.AddWithValue("@paymentamount", Amount); 
            cnd.Parameters.AddWithValue("@status", Status); 
            cnd.Parameters.AddWithValue("@assindate", DateTime.Now);
            cnd.ExecuteReader();
            Con.Close();
        }
    }
}