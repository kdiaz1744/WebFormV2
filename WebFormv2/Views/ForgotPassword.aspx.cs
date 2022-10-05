using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormv2.Classes;

namespace WebFormv2.Views
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["IDForChange"] = null;
        }

        protected void SendClick(object sender, EventArgs e)
        {
            OMSOperations operations = new OMSOperations();
            Users result = operations.FindUserViaUserName(UserName.Text);
            if (result.Ex == "None")
            {
                Response.Write("<script>alert('Invalid Credentials');</script>");
            }
            else if (result.StatusID == 2)
            {
                Response.Write("<script>alert('Account is inactive, please contact an admin');</script>");
            }
            else if (result.Ex == "Found")
            {

                OutOperations op = new OutOperations();
                string res = op.SendPassword(result);

                string message = "Password emailed succesfully";
                string url = "Login.aspx";
                string script = "window.onload = function(){ alert('";

                if (res == "Done") script += message;
                else script += res;

                script += "');";
                script += "window.location = '";
                script += url;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);

                //Response.Write("<script>alert('Email sent succesfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('" + result + "');</script>");
            }
        }

        //protected void CancelClick(object sender, EventArgs e)
        //{
        //    Response.Redirect("~/");
        //}
    }
}