using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace MapProject.WebPages
{
    public partial class MainPage : System.Web.UI.Page
    {
        public bool AgentOptInStatus;

       [WebMethod]
        public int GetInfo(string district)
        {
            if (String.IsNullOrEmpty(district))
            {
                return 999999999;
            }

            else
            {
                int districtnum = int.Parse(district);
                string commandText = "SELECT picurl FROM congress2 WHERE results_members_district=" + districtnum + ") AS I;";
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1.Properties.Settings.Constr"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int uniquecount = (Int32)cmd.ExecuteScalar(); //??
                    conn.Close();
                    return uniquecount; //??
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        [WebMethod]
        public int GetInfo(int district)
        {
            district.ToString();
            if (String.IsNullOrEmpty(district))
            {
                return 999999999;
            }

            else
            {

                int districtnum = int.Parse(district);

                string commandText = "SELECT {MEMBER INFO} FROM {TABLE} WHERE district_number=" + districtnum + ") AS I;";
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["{Name}.Properties.Settings.Constr"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int uniquecount = (Int32)cmd.ExecuteScalar(); //??
                    conn.Close();
                    return uniquecount; //??
                }
            }
        }

    }
}