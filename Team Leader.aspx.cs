using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        int projectid =0;      
        string EmailId;
        int EmployeeId;
        string Status = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            EmailId = Session["Eemail"].ToString();
            EmployeeId = Convert.ToInt32( Session["EmployeeID"].ToString());                            
            clsprojectmanagement obj = new clsprojectmanagement(EmailId);
            SqlDataReader dr;
            dr = obj.getteamleadalldata();
            while (dr.Read())
            {

                projectid = Convert.ToInt32(dr["ProjectID"].ToString());

                lblteamleadername.Text = dr["EName"].ToString();
                lblprojectname.Text = dr["ProjectName"].ToString();
                lblprojectname0.Text = dr["ProjectName"].ToString();
                lblprojectname1.Text = dr["ProjectName"].ToString();
                lblprojectname2.Text = dr["ProjectName"].ToString();


                Status = dr["Status"].ToString();
            }

            

            if (Status == "Assign")
            {
                btncomplete0.Enabled = true;
                btncomplete2.Enabled = false;
                btncomplete1.Enabled = false;

            }

            if (Status == "Iteration1")
            {
                btncomplete1.Enabled = true;
                btncomplete0.Enabled = false;
                btncomplete2.Enabled = false;
            }
            if (Status == "Iteration2")
            {
                btncomplete1.Enabled = false;
                btncomplete0.Enabled = false;
                btncomplete2.Enabled = true;
            }
            if (Status == "Project Complete")
            {
                btncomplete0.Enabled = false;
                btncomplete1.Enabled = false;
                btncomplete2.Enabled = false;

            }
        
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string status = "Iteration1";
            DateTime date = DateTime.Now;
            if(status== "assign")
            {
                btncomplete1.Enabled=true;
            }
            else 
            {
                clsprojectmanagement obj=new clsprojectmanagement(projectid, status);
                obj.completetask();
                Response.Write("<script LANGUAGE='javascript'>alert('Your Data Save Succesefully')</script>");
                btncomplete0.Enabled = false;
                btncomplete1.Enabled=true;
                //btncomplete2.Enabled=false;
            }
        }

        protected void btncomplete1_Click(object sender, EventArgs e)
        {
           
        }

        protected void btncomplete2_Click(object sender, EventArgs e)
        {
            string status = "Project Complete";
            DateTime date = DateTime.Now;
            if (status == "Iteration2")
            {
                btncomplete0.Enabled = false;
            }
            else
            {
                clsprojectmanagement obj = new clsprojectmanagement(projectid, status);
                obj.completetask();
                Response.Write("<script LANGUAGE='javascript'>alert('Your Data Save Succesefully')</script>");
                btncomplete1.Enabled = false;
                btncomplete2.Enabled = false;
                btncomplete0.Enabled = false;
            }
        }

        protected void btncomplete1_Click1(object sender, EventArgs e)
        {
            string status = "Iteration2";
            DateTime date = DateTime.Now;
            if (status == "Iteration1")
            {
                btncomplete2.Enabled = true;
            }
            else
            {
                clsprojectmanagement obj = new clsprojectmanagement(projectid, status);
                obj.completetask();
                Response.Write("<script LANGUAGE='javascript'>alert('Your Data Save Succesefully')</script>");
                btncomplete2.Enabled = true;
                btncomplete1.Enabled = false;
                btncomplete0.Enabled = false;
            }
        }
    }
}