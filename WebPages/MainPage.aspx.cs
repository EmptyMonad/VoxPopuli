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
            //get congressmen popularity 1-
            /* ConnectionSqlConnection db = new SqlConnection(VoxPopuliDB.ConnectionString);
             db.Open();
             SqlCommand getRep1AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='1'", db);
             SqlCommand getRep2AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='2'", db);
             SqlCommand getRep3AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='3'", db);
             SqlCommand getRep4AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='4'", db);
             SqlCommand getRep5AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='5'", db);
             SqlCommand getRep6AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='6'", db);
             SqlCommand getRep7AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='7'", db);
             SqlCommand getRep8AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='8'", db);
             SqlCommand getRep9AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='9'", db);
             SqlCommand getRep10AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='10'", db);
             SqlCommand getRep11AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='11'", db);
             SqlCommand getRep12AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='12'", db);
             SqlCommand getRep13AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='13'", db);
             SqlCommand getRep14AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='14'", db);
             SqlCommand getRep15AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='15'", db);
             SqlCommand getRep16AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='16'", db);
             SqlCommand getRep17AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='17'", db);
             SqlCommand getRep18AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='18'", db);
             SqlCommand getRep19AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='19'", db);
             SqlCommand getRep20AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='20'", db);
             SqlCommand getRep21AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='21'", db);
             SqlCommand getRep22AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='22'", db);
             SqlCommand getRep23AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='23'", db);
             SqlCommand getRep24AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='24'", db);
             SqlCommand getRep25AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='25'", db);
             SqlCommand getRep26AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='26'", db);
             SqlCommand getRep27AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='27'", db);
             SqlCommand getRep28AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='28'", db);
             SqlCommand getRep29AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='29'", db);
             SqlCommand getRep30AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='30'", db);
             SqlCommand getRep31AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='31'", db);
             SqlCommand getRep32AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='32'", db);
             SqlCommand getRep33AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='33'", db);
             SqlCommand getRep34AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='34'", db);
             SqlCommand getRep35AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='35'", db);
             SqlCommand getRep36AffinityCMD = new SqlCommand("SELECT RepAffinity FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='36'", db);
             //convert to scalar for comparison
             int Rep1Affinity = (int)getRep1AffinityCMD.ExecuteScalar();
             int Rep2Affinity = (int)getRep2AffinityCMD.ExecuteScalar();
             int Rep3Affinity = (int)getRep3AffinityCMD.ExecuteScalar();
             int Rep4Affinity = (int)getRep4AffinityCMD.ExecuteScalar();
             int Rep5Affinity = (int)getRep5AffinityCMD.ExecuteScalar();
             int Rep6Affinity = (int)getRep6AffinityCMD.ExecuteScalar();
             int Rep7Affinity = (int)getRep7AffinityCMD.ExecuteScalar();
             int Rep8Affinity = (int)getRep8AffinityCMD.ExecuteScalar();
             int Rep9Affinity = (int)getRep9AffinityCMD.ExecuteScalar();
             int Rep10Affinity = (int)getRep10AffinityCMD.ExecuteScalar();
             int Rep11Affinity = (int)getRep11AffinityCMD.ExecuteScalar();
             int Rep12Affinity = (int)getRep12AffinityCMD.ExecuteScalar();
             int Rep13Affinity = (int)getRep13AffinityCMD.ExecuteScalar();
             int Rep14Affinity = (int)getRep14AffinityCMD.ExecuteScalar();
             int Rep15Affinity = (int)getRep15AffinityCMD.ExecuteScalar();
             int Rep16Affinity = (int)getRep16AffinityCMD.ExecuteScalar();
             int Rep17Affinity = (int)getRep17AffinityCMD.ExecuteScalar();
             int Rep18Affinity = (int)getRep18AffinityCMD.ExecuteScalar();
             int Rep19Affinity = (int)getRep19AffinityCMD.ExecuteScalar();
             int Rep20Affinity = (int)getRep20AffinityCMD.ExecuteScalar();
             int Rep21Affinity = (int)getRep21AffinityCMD.ExecuteScalar();
             int Rep22Affinity = (int)getRep22AffinityCMD.ExecuteScalar();
             int Rep23Affinity = (int)getRep23AffinityCMD.ExecuteScalar();
             int Rep24Affinity = (int)getRep24AffinityCMD.ExecuteScalar();
             int Rep25Affinity = (int)getRep25AffinityCMD.ExecuteScalar();
             int Rep26Affinity = (int)getRep26AffinityCMD.ExecuteScalar();
             int Rep27Affinity = (int)getRep27AffinityCMD.ExecuteScalar();
             int Rep28Affinity = (int)getRep28AffinityCMD.ExecuteScalar();
             int Rep29Affinity = (int)getRep29AffinityCMD.ExecuteScalar();
             int Rep30Affinity = (int)getRep30AffinityCMD.ExecuteScalar();
             int Rep31Affinity = (int)getRep31AffinityCMD.ExecuteScalar();
             int Rep32Affinity = (int)getRep32AffinityCMD.ExecuteScalar();
             int Rep33Affinity = (int)getRep33AffinityCMD.ExecuteScalar();
             int Rep34Affinity = (int)getRep34AffinityCMD.ExecuteScalar();
             int Rep35Affinity = (int)getRep35AffinityCMD.ExecuteScalar();
             int Rep36Affinity = (int)getRep36AffinityCMD.ExecuteScalar();
             //call function mapColor 1-36
             mapColor(Rep1Affinity, "district1");
             mapColor(Rep2Affinity, "district2");
             mapColor(Rep3Affinity, "district3");
             mapColor(Rep4Affinity, "district4");
             mapColor(Rep5Affinity, "district5");
             mapColor(Rep6Affinity, "district6");
             mapColor(Rep7Affinity, "district7");
             mapColor(Rep8Affinity, "district8");
             mapColor(Rep9Affinity, "district9");
             mapColor(Rep10Affinity, "district10");
             mapColor(Rep11Affinity, "district11");
             mapColor(Rep12Affinity, "district12");
             mapColor(Rep13Affinity, "district13");
             mapColor(Rep14Affinity, "district14");
             mapColor(Rep15Affinity, "district15");
             mapColor(Rep16Affinity, "district16");
             mapColor(Rep17Affinity, "district17");
             mapColor(Rep18Affinity, "district18");
             mapColor(Rep19Affinity, "district19");
             mapColor(Rep20Affinity, "district20");
             mapColor(Rep21Affinity, "district21");
             mapColor(Rep22Affinity, "district22");
             mapColor(Rep23Affinity, "district23");
             mapColor(Rep24Affinity, "district24");
             mapColor(Rep25Affinity, "district25");
             mapColor(Rep26Affinity, "district26");
             mapColor(Rep27Affinity, "district27");
             mapColor(Rep28Affinity, "district28");
             mapColor(Rep29Affinity, "district29");
             mapColor(Rep30Affinity, "district30");
             mapColor(Rep31Affinity, "district31");
             mapColor(Rep32Affinity, "district32");
             mapColor(Rep33Affinity, "district33");
             mapColor(Rep34Affinity, "district34");
             mapColor{Rep35Affinity, "district35");
             mapColor(Rep36Affinity, "district36");*/
        }
    }
}