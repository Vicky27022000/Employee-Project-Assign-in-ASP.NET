using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm9 : System.Web.UI.Page
    {

        public int projectid;
        public int TLid;
        protected void Page_Load(object sender, EventArgs e)
        {
             projectid =Convert.ToInt32( Session["ProjectID"]);
            TLid = Convert.ToInt32(Session["TLEmployeeid"]);

            string project = Request.QueryString["ProjectName"].ToString();
            string TLname = Request.QueryString["TeamLead"].ToString();
            string Projectmanager = Request.QueryString["ProjectManager"].ToString();
            string Emailid = Request.QueryString["Eemail"].ToString();
            string phoneno = Request.QueryString["EPhoneNo"].ToString();
            string amount = Request.QueryString["Amount"].ToString();
          //  projectid = Convert.ToInt32(Request.QueryString["ProjectName"].ToString());
           //  TLid =Convert.ToInt32(Request.QueryString["TLEmployeeid"].ToString());


            lblprojectname.Text=project;
            lblprojectmanager.Text = Projectmanager;
            lblteamlead.Text = TLname;

        }

        protected void btnpayment_Click(object sender, EventArgs e)
        {

          // int projectid = Convert.ToUInt16(Session["ProjectID"]);
          //int  TLid = Convert.ToInt32(Session["TLEmployeeid"]);
            string Paymentstatus = "Payment Done";
            int amount = Convert.ToUInt16(txtamount.Text);
            clsprojectmanagement obj = new clsprojectmanagement(projectid, TLid, amount, Paymentstatus);
            obj.paymentdatasave();
            Response.Write("<script LANGUAGE='javascript'>alert('Payment Succesefully')</script>");

        }
    }
}