using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MapProject.WebPages
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(SqlDataSource1.ConnectionString);
            SqlCommand district1count = new SqlCommand("SELECT UpVote FROM VotingInformation WHERE DistrictNumber = 1 ", db);
            
            db.Open();
            {
              
                int district1value = (Int32)district1count.ExecuteScalar();
                if (district1value < 3)
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "MainPageMap.js", "paintDistrictBlack(district13)", true);
                }
               
            }
            db.Close();
        }
    }
}