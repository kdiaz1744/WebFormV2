using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WebFormv2.Classes;

namespace WebFormv2.Views
{
    public partial class EditUser : System.Web.UI.Page
    {
        bool SameUser = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.QueryString["UserID"];
                OMSOperations op = new OMSOperations();
                Users user = op.FindUserViaUserID(id);

                //--If you're a Regular user, you can't change your Role, Status, or Delete
                if (Session["Role"].Equals("Regular"))
                {
                    Rolelbl.Visible = false;
                    Role.Visible = false;
                    Statuslbl.Visible = false;
                    Status.Visible = false;
                    DeleteButton.Visible = false;
                }
                else
                {
                    Rolelbl.Visible = true;
                    Role.Visible = true;
                    Statuslbl.Visible = true;
                    Status.Visible = true;
                    DeleteButton.Visible = true;
                }

                //--Check if is user is signed in
                if (Session["Role"] == null) Response.Redirect("~/");
                //--Check if request was done from button by checking url id
                else if (!string.IsNullOrEmpty(id))
                {
                    //--if Admin, checks if first load. If Regular user, checks first load, and if this user edited is theirs
                    if ((!IsPostBack && Session["Role"].Equals("Admin")) ||
                        !IsPostBack && Session["Role"].Equals("Regular") && Session["UserName"].Equals(user.UserName))
                    {
                        if(Session["UserName"].Equals(user.UserName)) SameUser = true;
                        lblMessage.Visible = false;
                        //hyperlink.Visible = false;

                        Session["OldUserName"] = user.UserName;

                        UserName.Text = user.UserName;
                        FirstName.Text = user.FirstName;
                        LastName.Text = user.LastName;
                        Email.Text = user.Email;
                        Adress.Text = user.Adress;
                        City.Text = user.City;
                        State.Text = user.State;
                        ZipCode.Text = user.ZipCode;
                        PhoneNumber.Text = user.PhoneNumber;
                        Role.SelectedIndex = user.RoleID;
                        Status.SelectedIndex = user.StatusID;

                    }
                }
                else Response.Redirect("~/");


            }
            catch (Exception ex)
            {

            }
        }
        protected void SaveClick(object sender, EventArgs e)
        {
            rfvUserName.ErrorMessage = "This field is required";


            try
            {
                OMSOperations operations = new OMSOperations();
                Users result = operations.FindUserViaUserName(UserName.Text);
                string id = Request.QueryString["UserID"];

                if (Session["OldUserName"].Equals(UserName.Text)) result.Ex = "None";
                if (result.Ex == "Found")
                {
                    rfvUserName.ErrorMessage = "UserName already in use";
                    rfvUserName.IsValid = false;
                    Response.Write("<script>alert('UserName already in use');</script>");
                }
                else if (string.IsNullOrEmpty(id))
                {
                    Session["OldUserName"] = null;
                    Session["Once"] = null;

                    string message = "Invalid way on entering.";
                    string url = "../Default.aspx";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "');";
                    script += "window.location = '";
                    script += url;
                    script += "'; }";
                    ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
                }
                //else if (Session["OldUserName"].Equals(UserName.Text)) ;
                else if (result.Ex == "None")
                {
                    //HttpPostedFile postedFile = FileUpload.PostedFile;
                    //string FileName = Path.GetFileName(postedFile.FileName);
                    //string FileType = Path.GetExtension(FileName);
                    //int size = postedFile.ContentLength;

                    //Stream stream = postedFile.InputStream;
                    //BinaryReader binaryReader = new BinaryReader(stream);
                    //Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);



                    Users NUser = new Users();
                    NUser.UserID = Convert.ToInt32(id);
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

                    result.Ex = operations.EditUser(NUser);

                    if (result.Ex == "Done")
                    {
                        Session["OldUserName"] = null;
                        Session["Once"] = null;
                        //---------------------------
                        if (SameUser) Session["UserName"].Equals(NUser.UserName);
                        //---------------------------

                        string message = "User " + NUser.UserName + " succesfully changed!";
                        string url = "AdminHome.aspx";
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

        protected void DeleteClick(object sender, EventArgs e)
        {
            try
            {
                OMSOperations op = new OMSOperations();
                string id = Request.QueryString["UserID"];

                //--Avoid deleting yourself
                if (Session["UserName"].Equals(UserName.Text))
                {
                    Response.Write("<script>alert('You cannot delete yourself!');</script>");
                }
                else
                {

                    string result = op.DeleteUser(id);
                    if (result == "Done")
                    {
                        string message = "User " + UserName.Text + " succesfully deleted!";
                        string url = "AdminHome.aspx";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "');";
                        script += "window.location = '";
                        script += url;
                        script += "'; }";
                        ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
                    }
                    else if (result == "None")
                    {
                        Response.Write("<script>alert('Could not delete user " + UserName.Text + "');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('" + result + "');</script>");
                    }
                }
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex + "');</script>");
            }

        }

    }
}