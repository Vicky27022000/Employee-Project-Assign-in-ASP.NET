using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        public int ProjectID;
        public int TLEmployeeid;
        protected void Page_Load(object sender, EventArgs e)
        {
           // grcompleteproject.RowHeaderColumn.="Teamleader;
            clsprojectmanagement obj=new clsprojectmanagement();
           DataTable dt= obj.getcompleteprojectdetails();
            grcompleteproject.DataSource = dt;
            grcompleteproject.DataBind();
        }

        protected void grcompleteproject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Projectname = grcompleteproject.SelectedRow.Cells[1].Text;
            string TeamLead= grcompleteproject.SelectedRow.Cells[2].Text;
            string Projmanager = grcompleteproject.SelectedRow.Cells[3].Text;
            string email = grcompleteproject.SelectedRow.Cells[4].Text;
            string phoneno = grcompleteproject.SelectedRow.Cells[5].Text;
            int Projectid = Convert.ToInt32(grcompleteproject.SelectedRow.Cells[7].Text);
            int tlemployeeid= Convert.ToInt32(grcompleteproject.SelectedRow.Cells[8].Text);
            string amount = "50000";
            Session["ProjectID"] = Projectid;
            Session["TLEmployeeid"] = tlemployeeid;
            Response.Redirect("Pay.aspx?ProjectName=" + Projectname + "&TeamLead=" + TeamLead +
                "&ProjectManager=" + Projmanager + "&Eemail=" + email +
                "&EPhoneNo=" + phoneno  + "&Amount=" + amount );
        }
    }
}