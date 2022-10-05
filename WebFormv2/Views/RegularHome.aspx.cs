using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormv2.Classes;

namespace WebFormv2.Views
{
    public partial class RegularHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Role"] == null) Response.Redirect("~/");
                else if (Session["Role"].Equals("Admin")) Response.Redirect("~/Views/AdminHome.aspx");
                else
                {
                    Users AUser = new Users();
                    OMSOperations op = new OMSOperations();
                    AUser = op.FindUserViaUserName(Session["UserName"].ToString());
                    Email.Text = AUser.Email;
                    Adress.Text = AUser.Adress;
                    City.Text = AUser.City;
                    State.Text = AUser.State;
                    ZipCode.Text = AUser.ZipCode;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex + "');</script>");
            }
        }



        [WebMethod(EnableSession = true)]
        public static object ShowAllUsers()
        {
            //var op = new OMSOperations();
            var data = new ArrayList();

            data = OMSOperations.AllUsers();


            return data;
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            //window.location.href = "https://localhost:44308/Views/EditUser.aspx?" + "UserID=" + id;
            OMSOperations op = new OMSOperations();
            Users user = op.FindUserViaUserName(Session["UserName"].ToString());
            Response.Redirect("EditUser.aspx?UserID=" + user.UserID);
        }
    }
}