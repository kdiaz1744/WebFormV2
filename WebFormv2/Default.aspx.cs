using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormv2.Classes;

namespace WebFormv2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["IDForChange"] = null;
            Session["OldUserName"] = null;
            Session["Once"] = null;
        }
        //[WebMethod(EnableSession = true)]
        //public static object GetAllUsers()
        //{
        //    //var op = new OMSOperations();
        //    var data = new ArrayList();

        //    data = OMSOperations.AllUsers();


        //    return data;
        //}
    }
}