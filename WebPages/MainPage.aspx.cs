using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace MapProject.WebPages
{
    public partial class MainPage : System.Web.UI.Page
    {
        public bool AgentOptInStatus;

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