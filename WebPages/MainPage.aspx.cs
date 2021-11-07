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
            //structure is
            //for -10 to 10 votes
            //for -100 to 100 votes
            //for maximum of -1000 to 1000 votes (10 bills, 100% ratio per bill (10x100), scalable to 10,000/100,000 eventually)
            string colorDistrict(int affinity)
            {
                //select popularity from Congressman{district#}
                int value = "";
                
                /*send to js?
                        district1.setStyle color: color , fillColor: color;*/
            return value;
            }
        }
    }
}