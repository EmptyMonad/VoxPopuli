using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VoxPopuli.WebPages
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Cookies["Userinfo"] != null)
            {


                HttpCookie userCookie = HttpContext.Current.Request.Cookies["Userinfo"];
                HttpContext.Current.Response.Cookies.Remove("Userinfo");
                userCookie.Expires = DateTime.Now.AddDays(-10);
                userCookie.Value = null;
                HttpContext.Current.Response.SetCookie(userCookie);
            }
            Response.Redirect("~/WebPages/MainPage.aspx");
        }
    }
}