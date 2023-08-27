using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public string Type;
        public string Name;
        public int Employeeid;
        public string EmailId;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string emailid = txtemail.Text;
            string password = txtpassword.Text;
             
            if(txtemail.Text==""&& txtpassword.Text=="")
            {
                Response.Write("<Srcipt lauguage='javascript(lpz fill email and passward')</script>");
            }
            else
            {
                clsprojectmanagement cp=new clsprojectmanagement(txtemail.Text,txtpassword.Text);
                SqlDataReader dr;
                dr = cp.login();
                while(dr.Read())
                {
                    Type = dr["EType"].ToString();
                    Employeeid = Convert.ToInt32(dr["EmployeeID"].ToString());
                    Name = dr["EName"].ToString();
                    EmailId = dr["Eemail"].ToString();
                }
                if (dr.HasRows == true)
                {
                    if (Type == "Admin")
                    {
                        Response.Redirect("Assign Project.aspx");
                    }
                    else if (Type == "Project Manager")
                    {
                        Response.Redirect("Project Manager");
                    }
                    else if (Type == "Team Lead")
                    {
                        Session["EmployeeID"] = Employeeid;
                        Session["Eemail"] = EmailId;
                        Response.Redirect("Team Leader.aspx"); 
                    }

                }
                else { }
                
            }
        }
    }
}