using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            string Projecttype=ddltype.Text;
            string projectname=txtprojectname.Text;
            DateTime Startdate=Convert.ToDateTime(txtstartdate.Text);
            DateTime Enddate= Convert.ToDateTime(txtenddate0.Text);
            clsprojectmanagement obj=new clsprojectmanagement(Projecttype,projectname,Startdate,Enddate);
            obj.saveprojecttype();
            Response.Write("Save Succesefully...!");
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            txtprojectname.Text = "";
        }

        protected void btncalstartdate_Click(object sender, ImageClickEventArgs e)
        {
            if(startdate.Visible)
            {
                startdate.Visible = false;
            }
            else
            {
                startdate.Visible = true;   
            }
            startdate.Attributes.Add("style", "positio:absolute");
        }

        protected void btncalenddate_Click(object sender, ImageClickEventArgs e)
        {
            if (enddate.Visible)
            {
                enddate.Visible = false;
            }
            else
            {
                enddate.Visible = true;
            }
            enddate.Attributes.Add("style", "positio:absolute");
        }

        protected void startdate_SelectionChanged(object sender, EventArgs e)
        {
            txtstartdate.Text=startdate.SelectedDate.ToString("dd/MM/yyyy");
            startdate.Visible = false;

        }

        protected void enddate_SelectionChanged(object sender, EventArgs e)
        {
            txtenddate0.Text=enddate.SelectedDate.ToString("dd/MM/yyyy");
            enddate.Visible=false;
        }

        protected void txtenddate0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}