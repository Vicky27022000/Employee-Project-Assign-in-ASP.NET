using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsprojectmanagement obj=new clsprojectmanagement();
            DataTable dt = obj.getallproject();
            gdallrpoject.DataSource = dt;
            gdallrpoject.DataBind();
        }

        protected void gdallrpoject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}