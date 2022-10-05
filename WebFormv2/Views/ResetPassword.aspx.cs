using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormv2.Classes;

namespace WebFormv2.Views
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IDForChange"] == null) Response.Redirect("~/");
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            rfvCurrentPassword.ErrorMessage = "This field is required.";
            OMSOperations op = new OMSOperations();
            Users val = new Users();
            val = op.GetPassword(Session["IDForChange"].ToString());

            if (val.Password != CurrentPassword.Text)
            {
                Response.Write("<script>alert('Invalid Password');</script>");
                rfvCurrentPassword.ErrorMessage = "Invalid Password.";
                rfvCurrentPassword.IsValid = false;

            }
            else
            {
                string result = op.ChangePassword(Convert.ToInt32(Session["IDForChange"].ToString()), Password.Text, false);
                if (result == "Done")
                {
                    string message = "Password succesfully changed!";
                    string url = "Login.aspx";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "');";
                    script += "window.location = '";
                    script += url;
                    script += "'; }";
                    ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);

                    Session["IDForChange"] = null;
                }
                else
                {
                    Response.Write("<script>alert('" + result + "');</script>");
                }
            }
        }
    }
}