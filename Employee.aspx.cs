using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeProjectAssign
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string Gender;
        int Countryid { get;set;}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
            }
                clsprojectmanagement sz = new clsprojectmanagement();
                DataTable dt1 = sz.GetCountry();
                cmbcountry.DataTextField = "CountryName";
                cmbcountry.DataValueField = "CountryID";
                cmbcountry.DataSource = dt1;
                cmbcountry.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string type=cmbtype.Text;
            string name=txtname.Text;
            string email=txtemail.Text;
            string phoneno =txtphoneno.Text;
            string Gender = "";
            if(male.Checked)
            {
                Gender=male.Text;
            }
            if (female.Checked)
            {
                Gender = female.Text;
            }
            
            int cityID = Convert.ToInt32(cmbcity.Text.ToString());
            string Passward=txtpassword.Text;
            clsprojectmanagement obj = new clsprojectmanagement(type,name,email,phoneno,Gender, cityID, Passward);
            obj.Savedata();
            Response.Write("Save Succesefully....!");
        }

        protected void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

       

        protected void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int Countryid = Convert.ToInt32(cmbcountry.SelectedValue.ToString());
                clsprojectmanagement obj = new clsprojectmanagement(Countryid);
                DataTable dt = obj.GetState();
                cmbstate.DataSource = dt;
                cmbstate.DataTextField = "StateName";
                cmbstate.DataValueField = "StateID";
                cmbstate.DataBind();
            }
        }

        protected void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cmbcity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cmbstate_SelectedIndexChanged1(object sender, EventArgs e)
        {
        
            int Stateid = Convert.ToInt32(cmbstate.SelectedValue.ToString());
            clsprojectmanagement obj = new clsprojectmanagement(Stateid);
            DataTable dt = obj.GetCity();
            cmbcity.DataTextField = "CityName";
            cmbcity.DataValueField = "CityID";
            cmbcity.DataSource = dt;
            cmbcity.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtphoneno.Text = "";
            txtpassword.Text = "";
            
        }

        protected void txtphoneno_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtphoneno.Text = "";          
            txtpassword.Text = "";
        }
    }
}