using WebFormv2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormv2.Views
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session["IDForChange"] = null;
                Session["OldUserName"] = null;
                Session["Once"] = null;
                if (!Session["Role"].Equals("Admin")) Response.Redirect("~/");

            }
            catch (Exception ex)
            {

            }
        }

        protected void RegisterUser(object sender, EventArgs e)
        {
            rfvUserName.ErrorMessage = "This field is required";
            //rfvUserName.IsValid = true;

            try
            {
                OMSOperations operations = new OMSOperations();
                OutOperations outOperations = new OutOperations();
                Users result = operations.FindUserViaUserName(UserName.Text);

                if (result.Ex == "Found")
                {
                    rfvUserName.ErrorMessage = "UserName already in use";
                    rfvUserName.IsValid = false;
                    Response.Write("<script>alert('UserName already in use');</script>");
                }
                //else if (rfvCheck())
                //{
                //    ErrorMessage.Text = "Please check for errors";
                //    ErrorMessage.Visible = true;
                //}
                else if (result.Ex == "None")
                {
                    Users NUser = new Users();
                    NUser.UserName = UserName.Text;
                    NUser.FirstName = FirstName.Text;
                    NUser.LastName = LastName.Text;
                    NUser.Email = Email.Text;
                    NUser.Adress = Adress.Text;
                    NUser.City = City.Text;
                    NUser.State = State.Text;
                    NUser.ZipCode = ZipCode.Text;
                    NUser.PhoneNumber = PhoneNumber.Text;
                    NUser.RoleID = Convert.ToInt32(Role.SelectedValue);
                    NUser.StatusID = Convert.ToInt32(Status.SelectedValue);
                    NUser.Password = Guid.NewGuid().ToString();
                    NUser.Password = NUser.Password.Remove(12);

                    result.Ex = operations.AddUser(NUser);
                    outOperations.NewUser(NUser);
                    //Response.Write("<script>alert('User " + NUser.UserName + " succesfully added!');</script>");

                    string message = "User " + NUser.UserName + " succesfully added!";
                    string url = "../Default.aspx";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "');";
                    script += "window.location = '";
                    script += url;
                    script += "'; }";
                    ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
                }
                else
                {
                    Response.Write("<script>alert('" + result.Ex + "');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex + "');</script>");
            }

        }

        protected bool rfvCheck()
        {

            if (!rfvUserName.IsValid) { return true; }
            else if (!rfvFirstName.IsValid) { return true; }
            else if (!rfvLastName.IsValid) { return true; }
            else if (!rfvEmail.IsValid) { return true; }
            else if (!rfvAdress.IsValid) { return true; }
            else if (!rfvCity.IsValid) { return true; }
            else if (!rfvState.IsValid) { return true; }
            else if (!rfvZipCode.IsValid) { return true; }
            else if (!rfvPhoneNumber.IsValid) { return true; }
            else if (!rfvRole.IsValid) { return true; }
            else if (!rfvStatus.IsValid) { return true; }
            else return false;
        }
    }
}