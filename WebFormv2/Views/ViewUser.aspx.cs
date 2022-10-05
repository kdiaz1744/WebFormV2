using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormv2.Classes;

namespace WebFormv2.Views
{
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Session["Role"].Equals("Regular")) Response.Redirect("~/");

                string id = Request.QueryString["UserID"];
                if (!string.IsNullOrEmpty(id))
                {
                    //Response.Write("<script>alert('" + id + "');</script>");
                    OMSOperations op = new OMSOperations();
                    Users user = op.FindUserViaUserID(id);

                    UserName.Text = user.UserName;
                    FirstName.Text = user.FirstName;
                    LastName.Text = user.LastName;
                    Email.Text = user.Email;
                    Adress.Text = user.Adress;
                    City.Text = user.City;
                    State.Text = user.State;
                    ZipCode.Text = user.ZipCode;
                    PhoneNumber.Text = user.PhoneNumber;
                }
                else if (Session["Role"].Equals("Admin")) Response.Redirect("AdminHome.aspx");
                else
                {
                    Response.Redirect("~/");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}