using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm7 : System.Web.UI.Page
    {

        public int Projectid = 0;

        protected void Page_Load(object sender, EventArgs e)

        {
            if (!Page.IsPostBack)
            {
                clsprojectmanagement obj = new clsprojectmanagement();
                DataTable dt = obj.getproject();
                ddproject.DataValueField = "ProjectID";
                ddproject.DataTextField = "ProjectName";
                ddproject.DataSource = dt;
                ddproject.DataBind();
            
                clsprojectmanagement obj1 = new clsprojectmanagement();
                DataTable dt1 = obj1.getprojectmanagername();
                ddprojectmanager.DataSource = dt1;
                ddprojectmanager.DataValueField = "EmployeeID";
                ddprojectmanager.DataTextField = "EName";               
                ddprojectmanager.DataBind();

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string status = "Assign";
            int Projectid = Convert.ToInt32(ddproject.SelectedValue);
            int EmployeeID= Convert.ToInt32(ddprojectmanager.SelectedValue);
            clsprojectmanagement obj =new clsprojectmanagement(Projectid,EmployeeID,status);
            obj.AssignProject();
            Response.Write("Save Succesefully....!");
        }
    }
}