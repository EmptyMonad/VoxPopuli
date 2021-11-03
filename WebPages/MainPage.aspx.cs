using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Services;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace MapProject.WebPages
{
    public partial class MainPage : System.Web.UI.Page
    {
        public bool AgentOptInStatus;

        [WebMethod]
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            int district1score;
            if (district1score >= 1 && <= 5)
            {
                level1();
            }
            */

        }
    }
}