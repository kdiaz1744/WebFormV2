using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormv2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //if (Session["Role"].Equals("Admin")) AboutButton.Visible = false;
                //else if (Session["Role"].Equals("Regular")) AboutButton.Visible = false;
                //else AboutButton.Visible = true;

                //Session["UserName"] = null;
                //Session["FirstName"] = null;
                //Session["Status"] = null;
                //Session["Role"] = null;

                if (Session["UserName"] == null)
                {
                    LoginButton.Visible = true;
                    NameButton.Visible = false;
                    LogOffButton.Visible = false;
                    RegularButton.Visible = false;
                    AdminButton.Visible = false;
                    AddUserButton.Visible = false;
                }
                else
                {
                    LoginButton.Visible = false;
                    NameButton.Visible = true;
                    LogOffButton.Visible = true;

                    if (Session["Role"].Equals("Regular")) RegularButton.Visible = true;
                    else 
                    { 
                        AdminButton.Visible = true;
                        AddUserButton.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }


        }

        protected void Tester(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void LogOffButton_ServerClick(object sender, EventArgs e)
        {
            try
            {
                Session["UserName"] = null;
                Session["FirstName"] = null;
                Session["LastName"] = null;
                Session["Status"] = null;
                Session["Role"] = null;
                LogOffButton.Visible = false;

                Session["IDForChange"] = null;
                Session["OldUserName"] = null;

                Response.Redirect("~/");
            }
            catch (Exception ex)
            {

            }
        }
    }
}