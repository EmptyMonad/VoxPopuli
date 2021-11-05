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
                string color = "#FFFFFF";
                if (affinity >= -10 || affinity <= 10)
                {
                    if (affinity >= -10 && affinity <= -5)
                        color = "#6D5D25";
                    else if (affinity >= -4 && affinity <= -1)
                        color = "#BDAB6C";
                    else if (affinity >= 1 && affinity <= 4)
                        color = "#84BD6C";
                    else if (affinity >= 5 && affinity <= 10)
                        color = "#48892D";
                    else if (affinity == 0)
                        color = "#FFFFFF";
                }
                if (affinity >= -100 || affinity <= 100)
                {
                    if (affinity >= -100 && affinity <= -50)
                        color = "#6D5D25";
                    if (affinity >= -49 && affinity <= -11)
                        color = "#9C883F";
                    else if (affinity >= -10 && affinity <= -1)
                        color = "#BDAB6C";
                    else if (affinity >= 1 && affinity <= 10)
                        color = "#84BD6C";
                    if (affinity >= 11 && affinity <= 49)
                        color = "#5C9C40";
                    else if (affinity >= 50 && affinity <= 100)
                        color = "#48892D";
                    else if (affinity == 0)
                        color = "#FFFFFF";
                }
                /*send to js?
                        district1.setStyle color: color , fillColor: color;*/
            return color;
            }
        }
    }
}