using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsprojectmanagement obj = new clsprojectmanagement();
                DataTable dt = obj.assignteamleadprojectname();
                ddproject.DataValueField = "ProjectID";
                ddproject.DataTextField = "ProjectName";
                ddproject.DataSource = dt;
                ddproject.DataBind();

                clsprojectmanagement obj1 = new clsprojectmanagement();
                DataTable dt1 = obj1.getteamleadname();
                ddteamlead.DataValueField = "EmployeeID";
                ddteamlead.DataTextField = "EName";
                ddteamlead.DataSource = dt1;
                ddteamlead.DataBind();

            }
        }

        protected void btnassign_Click(object sender, EventArgs e)
        {
          
            int Projectid = Convert.ToInt32(ddproject.SelectedValue);
            int EmployeeID = Convert.ToInt32(ddteamlead.SelectedValue);
            String status = "Pending";
            clsprojectmanagement obj = new clsprojectmanagement(Projectid, EmployeeID,status);
            obj.assignteamleadproject();
            Response.Write("Update Succesefully....!");
        }
    }
}