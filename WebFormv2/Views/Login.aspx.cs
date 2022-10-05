using WebFormv2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormv2.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ForgotPassword.NavigateUrl = "ForgotPassword";
            Session["IDForChange"] = null;

        }

        protected void LogIn(object sender, EventArgs e)
        {
            OMSOperations oper = new OMSOperations();
            Users RUser = new Users();

            RUser = oper.ValidateUser(UserName.Text.Trim(), Password.Text);

            if (UserName.Text == "" || Password.Text == "")
            {
                SuccessMessage.Visible = false;
                FailureText.Text = "All fields are required";
                ErrorMessage.Visible = true;
            }
            else if (RUser.Ex == "None")
            {
                Response.Write("<script>alert('Invalid Credentials');</script>");
                SuccessMessage.Visible = false;
                FailureText.Text = "Invalid login attempt";
                ErrorMessage.Visible = true;
            }
            else if (RUser.StatusID == 2)
            {
                Response.Write("<script>alert('Account is inactive, please contact an admin');</script>");
                SuccessMessage.Visible = false;
                FailureText.Text = "Invalid login attempt";
                ErrorMessage.Visible = true;
            }
            else if (RUser.Initial)
            {
                Session["IDForChange"] = RUser.UserID;

                string message = "Please change your password";
                string url = "ResetPassword.aspx";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "');";
                script += "window.location = '";
                script += url;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);

                //Response.Write("<script>alert('Initial Password Found');</script>");
                //Response.Redirect("~/Views/ResetPassword.aspx");
            }
            else if (RUser.Ex == "Found")
            {
                Session["IDForChange"] = null;
                Session["Once"] = null;

                Session["UserName"] = RUser.UserName;
                Session["FirstName"] = RUser.FirstName;
                Session["LastName"] = RUser.LastName;
                Session["Status"] = "Active";
                if (RUser.RoleID == 1) Session["Role"] = "Admin";
                else Session["Role"] = "Regular";

                ErrorMessage.Visible = false;
                SuccessText.Text = "User login successful";
                SuccessMessage.Visible = true;

                Response.Redirect("~/");
            }
            else
            {
                //Response.Write("<script>alert('Database Connection Problem');</script>");
                Response.Write("<script>alert('" + RUser.Ex + "');</script>");

            }

        }
    }


}