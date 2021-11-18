﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VoxPopuli.WebPages
{
    public partial class TXDistrict1 : System.Web.UI.Page
    {

        private string state = "TX";
        private string district = "1";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Define the state for this page
           
            
          
            //Define the SQL Connection
            SqlConnection db = new SqlConnection(VoxPopuliDB.ConnectionString);




            //Define the Command for grabbing the First Name of The Representative
            SqlCommand getRepFirstNameCMD = new SqlCommand("SELECT results_members_first_name FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='1'", db);

            //Define the Command for grabbing the Last Name of The Representative
            SqlCommand getRepLastNameCMD = new SqlCommand("SELECT results_members_last_name FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='1'", db);

            //Define the Command for grabbing the twitter Handle of the Rep
            SqlCommand getRepTwitterCMD = new SqlCommand("SELECT results_members_twitter_account FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='1'", db);

            //Define the Command for grabbing the image URL of the representative
            SqlCommand getRepPicURLCMD = new SqlCommand("SELECT picurl FROM congress2 WHERE results_congress= '117' AND results_members_state='TX' AND results_members_district ='1'", db);


            //Define The Command For Grabbing the Reps Vote on Each Bill
            SqlCommand getBill20VoteCMD = new SqlCommand("SELECT vote_position FROM Bill20 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill19VoteCMD = new SqlCommand("SELECT vote_position FROM Bill19 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill18VoteCMD = new SqlCommand("SELECT vote_position FROM Bill18 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill17VoteCMD = new SqlCommand("SELECT vote_position FROM Bill17 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill16VoteCMD = new SqlCommand("SELECT vote_position FROM Bill16 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill15VoteCMD = new SqlCommand("SELECT vote_position FROM Bill15 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill14VoteCMD = new SqlCommand("SELECT vote_position FROM Bill14 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill13VoteCMD = new SqlCommand("SELECT vote_position FROM Bill13 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill12VoteCMD = new SqlCommand("SELECT vote_position FROM Bill12 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill11VoteCMD = new SqlCommand("SELECT vote_position FROM Bill11 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill10VoteCMD = new SqlCommand("SELECT vote_position FROM Bill10 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill9VoteCMD = new SqlCommand("SELECT vote_position FROM Bill9 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill8VoteCMD = new SqlCommand("SELECT vote_position FROM Bill8 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill7VoteCMD = new SqlCommand("SELECT vote_position FROM Bill7 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill6VoteCMD = new SqlCommand("SELECT vote_position FROM Bill6 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill5VoteCMD = new SqlCommand("SELECT vote_position FROM Bill5 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill4VoteCMD = new SqlCommand("SELECT vote_position FROM Bill4 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill3VoteCMD = new SqlCommand("SELECT vote_position FROM Bill3 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill2VoteCMD = new SqlCommand("SELECT vote_position FROM Bill2 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill1VoteCMD = new SqlCommand("SELECT vote_position FROM Bill1 WHERE state='TX' AND district ='1'", db);




            //Bill20
            SqlCommand getBill20Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='315'", db);
            SqlCommand getBill20ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='315'", db);
            SqlCommand getBill20Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='315'", db);
            SqlCommand getBill20Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='315'", db);

            //Billl316
            SqlCommand getBill19Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='316'", db);
            SqlCommand getBill19ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='316'", db);
            SqlCommand getBill19Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='316'", db);
            SqlCommand getBill19Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='316'", db);


            //Bill18
            SqlCommand getBill18Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='317'", db);
            SqlCommand getBill18ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='317'", db);
            SqlCommand getBill18Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='317'", db);
            SqlCommand getBill18Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='317'", db);


            //Bill 318
            SqlCommand getBill17Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='318'", db);
            SqlCommand getBill17ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='318'", db);
            SqlCommand getBill17Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='318'", db);
            SqlCommand getBill17Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='318'", db);

            //Bill 319

            SqlCommand getBill16Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='319'", db);
            SqlCommand getBill16ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='319'", db);
            SqlCommand getBill16Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='319'", db);
            SqlCommand getBill16Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='319'", db);


            //Bill 320
            SqlCommand getBill15Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='320'", db);
            SqlCommand getBill15ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='320'", db);
            SqlCommand getBill15Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='320'", db);
            SqlCommand getBill15Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='320'", db);


            //Bill 321
            SqlCommand getBill14Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='321'", db);
            SqlCommand getBill14ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='321'", db);
            SqlCommand getBill14Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='321'", db);
            SqlCommand getBill14Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='321'", db);


            //Bill 322
            SqlCommand getBill13Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='322'", db);
            SqlCommand getBill13ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='322'", db);
            SqlCommand getBill13Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='322'", db);
            SqlCommand getBill13Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='322'", db);


            //Bill 323
            SqlCommand getBill12Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='323'", db);
            SqlCommand getBill12ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='323'", db);
            SqlCommand getBill12Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='323'", db);
            SqlCommand getBill12Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='323'", db);


            //Bill 324
            SqlCommand getBill11Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='324'", db);
            SqlCommand getBill11ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='324'", db);
            SqlCommand getBill11Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='324'", db);
            SqlCommand getBill11Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='324'", db);

            //Bill 325
            SqlCommand getBill10Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='325'", db);
            SqlCommand getBill10ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='325'", db);
            SqlCommand getBill10Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='325'", db);
            SqlCommand getBill10Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='325'", db);


            //Bill 326
            SqlCommand getBill9Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='326'", db);
            SqlCommand getBill9ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='326'", db);
            SqlCommand getBill9Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='326'", db);
            SqlCommand getBill9Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='326'", db);


            //Bill 327
            SqlCommand getBill8Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='327'", db);
            SqlCommand getBill8ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='327'", db);
            SqlCommand getBill8Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='327'", db);
            SqlCommand getBill8Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='327'", db);


            //Bill 328
            SqlCommand getBill7Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='328'", db);
            SqlCommand getBill7ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='328'", db);
            SqlCommand getBill7Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='328'", db);
            SqlCommand getBill7Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='328'", db);


            //Bill 329
            SqlCommand getBill6Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='329'", db);
            SqlCommand getBill6ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='329'", db);
            SqlCommand getBill6Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='329'", db);
            SqlCommand getBill6Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='329'", db);


            //Bill 330
            SqlCommand getBill5Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='330'", db);
            SqlCommand getBill5ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='330'", db);
            SqlCommand getBill5Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='330'", db);
            SqlCommand getBill5Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='330'", db);


            //Bill 331
            SqlCommand getBill4Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='331'", db);
            SqlCommand getBill4ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='331'", db);
            SqlCommand getBill4Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='331'", db);
            SqlCommand getBill4Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='331'", db);


            //Bill 332
            SqlCommand getBill3Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='332'", db);
            SqlCommand getBill3ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='332'", db);
            SqlCommand getBill3Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='332'", db);
            SqlCommand getBill3Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='332'", db);


            //Bill 333
            SqlCommand getBill2Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='333'", db);
            SqlCommand getBill2ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='333'", db);
            SqlCommand getBill2Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='333'", db);
            SqlCommand getBill2Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='333'", db);

            SqlCommand getBill1Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='334'", db);
            SqlCommand getBill1ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='334'", db);
            SqlCommand getBill1Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='334'", db);
            SqlCommand getBill1Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='334'", db);













            //Open the DB try/catch to execute the commands, then replace the html elements appropriatley

            db.Open();
            try
            {
                //Execute Commands For Represenative Information
                string repFirstName = (string)getRepFirstNameCMD.ExecuteScalar();
                string repLastName = (string)getRepLastNameCMD.ExecuteScalar();
                string repTwitter = (string)getRepTwitterCMD.ExecuteScalar();
                string repPicURL = (string)getRepPicURLCMD.ExecuteScalar();



                //Execute Commands For Votes on Bills
                string Bill20Vote = (string)getBill20VoteCMD.ExecuteScalar();
                string Bill19Vote = (string)getBill19VoteCMD.ExecuteScalar();
                string Bill18Vote = (string)getBill18VoteCMD.ExecuteScalar();
                string Bill17Vote = (string)getBill17VoteCMD.ExecuteScalar();
                string Bill16Vote = (string)getBill16VoteCMD.ExecuteScalar();
                string Bill15Vote = (string)getBill15VoteCMD.ExecuteScalar();
                string Bill14Vote = (string)getBill14VoteCMD.ExecuteScalar();
                string Bill13Vote = (string)getBill13VoteCMD.ExecuteScalar();
                string Bill12Vote = (string)getBill12VoteCMD.ExecuteScalar();
                string Bill11Vote = (string)getBill11VoteCMD.ExecuteScalar();
                string Bill10Vote = (string)getBill10VoteCMD.ExecuteScalar();
                string Bill9Vote = (string)getBill9VoteCMD.ExecuteScalar();
                string Bill8Vote = (string)getBill8VoteCMD.ExecuteScalar();
                string Bill7Vote = (string)getBill7VoteCMD.ExecuteScalar();
                string Bill6Vote = (string)getBill6VoteCMD.ExecuteScalar();
                string Bill5Vote = (string)getBill5VoteCMD.ExecuteScalar();
                string Bill4Vote = (string)getBill4VoteCMD.ExecuteScalar();
                string Bill3Vote = (string)getBill3VoteCMD.ExecuteScalar();
                string Bill2Vote = (string)getBill2VoteCMD.ExecuteScalar();
                string Bill1Vote = (string)getBill1VoteCMD.ExecuteScalar();

                //Execute Commands for Bill Information


                //Bill 315
                string Bill20Name = (string)getBill20Name.ExecuteScalar();
                string Bill20ID = (string)getBill20ID.ExecuteScalar();
                string Bill20Link = (string)getBill20Link.ExecuteScalar();
                string Bill20Result = (string)getBill20Result.ExecuteScalar();

                //Bill19
                string Bill19Name = (string)getBill19Name.ExecuteScalar();
                string Bill19ID = (string)getBill19ID.ExecuteScalar();
                string Bill19Link = (string)getBill19Link.ExecuteScalar();
                string Bill19Result = (string)getBill19Result.ExecuteScalar();

                //Bill18
                string Bill18Name = (string)getBill18Name.ExecuteScalar();
                string Bill18ID = (string)getBill18ID.ExecuteScalar();
                string Bill18Link = (string)getBill18Link.ExecuteScalar();
                string Bill18Result = (string)getBill18Result.ExecuteScalar();

                //Bill17
                string Bill17Name = (string)getBill17Name.ExecuteScalar();
                string Bill17ID = (string)getBill17ID.ExecuteScalar();
                string Bill17Link = (string)getBill17Link.ExecuteScalar();
                string Bill17Result = (string)getBill17Result.ExecuteScalar();

                //Bill16
                string Bill16Name = (string)getBill16Name.ExecuteScalar();
                string Bill16ID = (string)getBill16ID.ExecuteScalar();
                string Bill16Link = (string)getBill16Link.ExecuteScalar();
                string Bill16Result = (string)getBill16Result.ExecuteScalar();

                //Billl320
                string Bill15Name = (string)getBill15Name.ExecuteScalar();
                string Bill15ID = (string)getBill15ID.ExecuteScalar();
                string Bill15Link = (string)getBill15Link.ExecuteScalar();
                string Bill15Result = (string)getBill15Result.ExecuteScalar();

                //Bill14
                string Bill14Name = (string)getBill14Name.ExecuteScalar();
                string Bill14ID = (string)getBill14ID.ExecuteScalar();
                string Bill14Link = (string)getBill14Link.ExecuteScalar();
                string Bill14Result = (string)getBill14Result.ExecuteScalar();

                //Bill13
                string Bill13Name = (string)getBill13Name.ExecuteScalar();
                string Bill13ID = (string)getBill13ID.ExecuteScalar();
                string Bill13Link = (string)getBill13Link.ExecuteScalar();
                string Bill13Result = (string)getBill13Result.ExecuteScalar();

                //Bill 323
                string Bill12Name = (string)getBill12Name.ExecuteScalar();
                string Bill12ID = (string)getBill12ID.ExecuteScalar();
                string Bill12Link = (string)getBill12Link.ExecuteScalar();
                string Bill12Result = (string)getBill12Result.ExecuteScalar();

                //Bill 324
                string Bill11Name = (string)getBill11Name.ExecuteScalar();
                string Bill11ID = (string)getBill11ID.ExecuteScalar();
                string Bill11Link = (string)getBill11Link.ExecuteScalar();
                string Bill11Result = (string)getBill11Result.ExecuteScalar();

                //Bill 325

                string Bill10Name = (string)getBill10Name.ExecuteScalar();
                string Bill10ID = (string)getBill10ID.ExecuteScalar();
                string Bill10Link = (string)getBill10Link.ExecuteScalar();
                string Bill10Result = (string)getBill10Result.ExecuteScalar();

                //Bill 326
                string Bill9Name = (string)getBill9Name.ExecuteScalar();
                string Bill9ID = (string)getBill9ID.ExecuteScalar();
                string Bill9Link = (string)getBill9Link.ExecuteScalar();
                string Bill9Result = (string)getBill9Result.ExecuteScalar();

                //Bill 327
                string Bill8Name = (string)getBill8Name.ExecuteScalar();
                string Bill8ID = (string)getBill8ID.ExecuteScalar();
                string Bill8Link = (string)getBill8Link.ExecuteScalar();
                string Bill8Result = (string)getBill8Result.ExecuteScalar();

                //Bill 328
                string Bill7Name = (string)getBill7Name.ExecuteScalar();
                string Bill7ID = (string)getBill7ID.ExecuteScalar();
                string Bill7Link = (string)getBill7Link.ExecuteScalar();
                string Bill7Result = (string)getBill7Result.ExecuteScalar();

                //Bill 329
                string Bill6Name = (string)getBill6Name.ExecuteScalar();
                string Bill6ID = (string)getBill6ID.ExecuteScalar();
                string Bill6Link = (string)getBill6Link.ExecuteScalar();
                string Bill6Result = (string)getBill6Result.ExecuteScalar();

                //Bill 330
                string Bill5Name = (string)getBill5Name.ExecuteScalar();
                string Bill5ID = (string)getBill5ID.ExecuteScalar();
                string Bill5Link = (string)getBill5Link.ExecuteScalar();
                string Bill5Result = (string)getBill5Result.ExecuteScalar();

                //Bill 331
                string Bill4Name = (string)getBill4Name.ExecuteScalar();
                string Bill4ID = (string)getBill4ID.ExecuteScalar();
                string Bill4Link = (string)getBill4Link.ExecuteScalar();
                string Bill4Result = (string)getBill4Result.ExecuteScalar();

                //Bill 332
                string Bill3Name = (string)getBill3Name.ExecuteScalar();
                string Bill3ID = (string)getBill3ID.ExecuteScalar();
                string Bill3Link = (string)getBill3Link.ExecuteScalar();
                string Bill3Result = (string)getBill3Result.ExecuteScalar();

                //Bill 333
                string Bill2Name = (string)getBill2Name.ExecuteScalar();
                string Bill2ID = (string)getBill2ID.ExecuteScalar();
                string Bill2Link = (string)getBill2Link.ExecuteScalar();
                string Bill2Result = (string)getBill2Result.ExecuteScalar();

                string Bill1Name = (string)getBill1Name.ExecuteScalar();
                string Bill1ID = (string)getBill1ID.ExecuteScalar();
                string Bill1Link = (string)getBill1Link.ExecuteScalar();
                string Bill1Result = (string)getBill1Result.ExecuteScalar();





                //Replace HTML Elements Based off Information Pulled From The Database
                RepNameHolder.InnerHtml = repFirstName + " " + repLastName;
                twitterHandle.InnerHtml = "@" + repTwitter;


                //Replace the Bill Information For Each Bill
                Bill1.PostBackUrl = Bill1Link;
                billname1.InnerHtml = Bill1Name;
                BillID1.InnerHtml = "Bill ID: " + Bill1ID;
                result1.InnerHtml = "Bill Result: " + Bill1Result;
                repvote1.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill1Vote;


                Bill2.PostBackUrl = Bill2Link;
                billname2.InnerHtml = Bill2Name;
                BillID2.InnerHtml = "Bill ID: " + Bill2ID;
                result2.InnerHtml = "Bill Result: " + Bill2Result;
                repvote2.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill2Vote;



                Bill3.PostBackUrl = Bill3Link;
                billname3.InnerHtml = Bill3Name;
                BillID3.InnerHtml = "Bill ID: " + Bill3ID;
                result3.InnerHtml = "Bill Result: " + Bill3Result;
                repvote3.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill3Vote;



                Bill4.PostBackUrl = Bill4Link;
                billname4.InnerHtml = Bill4Name;
                BillID4.InnerHtml = "Bill ID: " + Bill4ID;
                result4.InnerHtml = "Bill Result: " + Bill4Result;
                repvote4.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill4Vote;



                Bill5.PostBackUrl = Bill5Link;
                billname5.InnerHtml = Bill5Name;
                BillID5.InnerHtml = "Bill ID: " + Bill5ID;
                result5.InnerHtml = "Bill Result: " + Bill5Result;
                repvote5.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill5Vote;



                Bill6.PostBackUrl = Bill6Link;
                billname6.InnerHtml = Bill6Name;
                BillID6.InnerHtml = "Bill ID: " + Bill6ID;
                result6.InnerHtml = "Bill Result: " + Bill6Result;
                repvote6.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill6Vote;



                Bill7.PostBackUrl = Bill7Link;
                billname7.InnerHtml = Bill7Name;
                BillID7.InnerHtml = "Bill ID: " + Bill7ID;
                result7.InnerHtml = "Bill Result: " + Bill7Result;
                repvote7.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill7Vote;



                Bill8.PostBackUrl = Bill8Link;
                billname8.InnerHtml = Bill8Name;
                BillID8.InnerHtml = "Bill ID: " + Bill8ID;
                result8.InnerHtml = "Bill Result: " + Bill8Result;
                repvote8.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill8Vote;



                Bill9.PostBackUrl = Bill9Link;
                billname9.InnerHtml = Bill9Name;
                BillID9.InnerHtml = "Bill ID: " + Bill9ID;
                result9.InnerHtml = "Bill Result: " + Bill9Result;
                repvote9.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill9Vote;



                Bill10.PostBackUrl = Bill10Link;
                billname10.InnerHtml = Bill10Name;
                BillID10.InnerHtml = "Bill ID: " + Bill10ID;
                result10.InnerHtml = "Bill Result: " + Bill10Result;
                repvote10.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill10Vote;



                Bill11.PostBackUrl = Bill11Link;
                billname11.InnerHtml = Bill11Name;
                BillID11.InnerHtml = "Bill ID: " + Bill11ID;
                result11.InnerHtml = "Bill Result: " + Bill11Result;
                repvote11.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill11Vote;



                Bill12.PostBackUrl = Bill12Link;
                billname12.InnerHtml = Bill12Name;
                BillID12.InnerHtml = "Bill ID: " + Bill12ID;
                result12.InnerHtml = "Bill Result: " + Bill12Result;
                repvote12.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill12Vote;



                Bill13.PostBackUrl = Bill13Link;
                billname13.InnerHtml = Bill13Name;
                BillID13.InnerHtml = "Bill ID: " + Bill13ID;
                result13.InnerHtml = "Bill Result: " + Bill13Result;
                repvote13.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill13Vote;



                Bill14.PostBackUrl = Bill14Link;
                billname14.InnerHtml = Bill14Name;
                BillID14.InnerHtml = "Bill ID: " + Bill14ID;
                result14.InnerHtml = "Bill Result: " + Bill14Result;
                repvote14.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill14Vote;



                Bill15.PostBackUrl = Bill15Link;
                billname15.InnerHtml = Bill15Name;
                BillID15.InnerHtml = "Bill ID: " + Bill15ID;
                result15.InnerHtml = "Bill Result: " + Bill15Result;
                repvote15.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill15Vote;



                Bill16.PostBackUrl = Bill16Link;
                billname16.InnerHtml = Bill16Name;
                BillID16.InnerHtml = "Bill ID: " + Bill16ID;
                result16.InnerHtml = "Bill Result: " + Bill16Result;
                repvote16.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill16Vote;



                Bill17.PostBackUrl = Bill17Link;
                billname17.InnerHtml = Bill17Name;
                BillID17.InnerHtml = "Bill ID: " + Bill17ID;
                result17.InnerHtml = "Bill Result: " + Bill17Result;
                repvote17.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill17Vote;



                Bill18.PostBackUrl = Bill18Link;
                billname18.InnerHtml = Bill18Name;
                BillID18.InnerHtml = "Bill ID: " + Bill18ID;
                result18.InnerHtml = "Bill Result: " + Bill18Result;
                repvote18.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill18Vote;



                Bill19.PostBackUrl = Bill19Link;
                billname19.InnerHtml = Bill19Name;
                BillID19.InnerHtml = "Bill ID: " + Bill19ID;
                result19.InnerHtml = "Bill Result: " + Bill19Result;
                repvote19.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill19Vote;



                Bill20.PostBackUrl = Bill20Link;
                billname20.InnerHtml = Bill20Name;
                BillID20.InnerHtml = "Bill ID: " + Bill20ID;
                result20.InnerHtml = "Bill Result: " + Bill20Result;
                repvote20.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill20Vote;











            }
            catch
            {

            }

            finally
            {
                db.Close();
            }


            //Setting Username for testing purposes -- delete me
            string username = "AdminTesting1";

            //Now, We Will Need to Populate Prior Votes From The User. Implementing LoadVotes function
            LoadVotes(username, state, district, "Bill1", upvote1, downvote1);
            LoadVotes(username, state, district, "Bill2", upvote2, downvote2);
            LoadVotes(username, state, district, "Bill3", upvote3, downvote3);
            LoadVotes(username, state, district, "Bill4", upvote4, downvote4);
            LoadVotes(username, state, district, "Bill5", upvote5, downvote5);
            LoadVotes(username, state, district, "Bill6", upvote6, downvote6);
            LoadVotes(username, state, district, "Bill7", upvote7, downvote7);
            LoadVotes(username, state, district, "Bill8", upvote8, downvote8);
            LoadVotes(username, state, district, "Bill9", upvote9, downvote9);
            LoadVotes(username, state, district, "Bill10", upvote10, downvote10);
            LoadVotes(username, state, district, "Bill11", upvote11, downvote11);
            LoadVotes(username, state, district, "Bill12", upvote12, downvote12);
            LoadVotes(username, state, district, "Bill13", upvote13, downvote13);
            LoadVotes(username, state, district, "Bill14", upvote14, downvote14);
            LoadVotes(username, state, district, "Bill15", upvote15, downvote15);
            LoadVotes(username, state, district, "Bill16", upvote16, downvote16);
            LoadVotes(username, state, district, "Bill17", upvote17, downvote17);
            LoadVotes(username, state, district, "Bill18", upvote18, downvote18);
            LoadVotes(username, state, district, "Bill19", upvote19, downvote19);
            LoadVotes(username, state, district, "Bill20", upvote20, downvote20);


        }

        //isolates the number from the string
        //Allowing the code to know what bill and bill items will be effected dynamically.
        protected int buttonconvert(string buttonID)
        {
            int buttonnum = 0;
            string tmp = buttonID;
            try
            {
                tmp = Regex.Replace(tmp, "[^0-20]+", string.Empty);
                buttonnum = Int32.Parse(tmp);

            }
            catch (Exception)
            {
                Console.WriteLine("Error: String cannot be converted to Int");
            } 
            

            return buttonnum;
        }

        protected void button_clicked(object sender, EventArgs e)
        {

            int idnum; //holds button number
            bool containsnum = false; //bool to check if the statement contains a number
            ImageButton button = (ImageButton)sender; //Make the sender a button first
            string buttonId = button.ID; //holds full name of button
            if (containsnum = buttonId.Any(char.IsDigit) == true) //if the original button id has a number, continue
            {
                setcolor(sender);
                //pass the string of the button to get the number.
                idnum = buttonconvert(buttonId);
                //use the number to indivigually sql the elements into the correct 
                // objects
                switch (idnum)
                {
                    case 1:
                        //sql database thingy

                        break;
                    case 2:
                        //sql database thingy
                        break;
                    case 3:
                        //sql database thingy
                        break;
                    case 4:
                        //sql database thingy
                        break;
                    case 5:
                        //sql database thingy
                        break;
                    case 6:
                        //sql database thingy
                        break;
                    case 7:
                        //sql database thingy
                        break;
                    case 8:
                        //sql database thingy
                        break;
                    case 9:
                        //sql database thingy
                        break;
                    case 10:
                        //sql database thingy
                        break;
                    case 11:
                        //sql database thingy
                        break;
                    case 12:
                        //sql database thingy
                        break;
                    case 13:
                        //sql database thingy
                        break;
                    case 14:
                        //sql database thingy
                        break;
                    case 15:
                        //sql database thingy
                        break;
                    case 16:
                        //sql database thingy
                        break;
                    case 17:
                        //sql database thingy
                        break;
                    case 18:
                        //sql database thingy
                        break;
                    case 19:
                        //sql database thingy
                        break;
                    case 20:
                        //sql database thingy
                        break;
                    default:
                        Console.WriteLine("Error: No valid bill number.");
                        break;
                }
            }

            else
                Console.WriteLine("No button found");
        }

        /**
         * SetColor function
         * Returns: N/A
         * Purpose: Takes the sender button object and colors the button in the correct color based on the sender.
         **/
        protected void setcolor(object sender)
        {
           
            //Define strings of upvote
            string up = "upvote";
            string g = "green";
            //Get button
            ImageButton button = (ImageButton)sender;
            //Get button ID
            string buttonid = button.ID;
            //Call function to get the opposite of this button
            ImageButton Opposite = getOppositeButton(buttonid);

            string path = button.ImageUrl;

            //check if upvote/downvote
            if(buttonid.Contains(up) && path.Contains(g))
            {
                
                button.ImageUrl = "~/Images/upvote-png-clear.png";
                Opposite.ImageUrl = "~/Images/downvote-clear.png";
            }
            else if(buttonid.Contains(up))
            {
                button.ImageUrl = "~/Images/upvote-png-green.png";
                Opposite.ImageUrl = "~/Images/downvote-clear.png";
            }
            else if (buttonid.Contains("down") && path.Contains("clear"))
            {
                //If upvote is not found, assume downvote.
                button.ImageUrl = "~/Images/downvote-clicked.png";
                Opposite.ImageUrl = "~/Images/upvote-png-clear.png";
            }
            else
            {
                button.ImageUrl = "~/Images/downvote-clear.png";
                Opposite.ImageUrl = "~/Images/upvote-png-clear.png";
            }    

            


            
        }

        //This function is used to get the opposite button of another button.
        //For instance, if the button is Upvote1, then Downvote1 is returned.
        protected ImageButton getOppositeButton(string btn)
        {
            string[] split = btn.Split('e');
            if(btn.Contains("up") && split[1] == "1")
            {
                return downvote1;
            }
            else if(btn.Contains("down") && split[1] == "1")
            {
                return upvote1;
            }

            if (btn.Contains("up") && split[1] == "2")
            {
                return downvote2;
            }
            else if (btn.Contains("down") && split[1] == "2")
            {
                return upvote2;
            }

            if (btn.Contains("up") && split[1] == "3")
            {
                return downvote3;
            }
            else if (btn.Contains("down") && split[1] == "3")
            {
                return upvote3;
            }

            if (btn.Contains("up") && split[1] == "4")
            {
                return downvote4;
            }
            else if (btn.Contains("down") && split[1] == "4")
            {
                return upvote4;
            }

            if (btn.Contains("up") && split[1] == "5")
            {
                return downvote5;
            }
            else if (btn.Contains("down") && split[1] == "5")
            {
                return upvote5;
            }

            if (btn.Contains("up") && split[1] == "6")
            {
                return downvote6;
            }
            else if (btn.Contains("down") && split[1] == "6")
            {
                return upvote6;
            }

            if (btn.Contains("up") && split[1] == "7")
            {
                return downvote7;
            }
            else if (btn.Contains("down") && split[1] == "7")
            {
                return upvote7;
            }

            if (btn.Contains("up") && split[1] == "8")
            {
                return downvote8;
            }
            else if (btn.Contains("down") && split[1] == "8")
            {
                return upvote8;
            }

            if (btn.Contains("up") && split[1] == "9")
            {
                return downvote9;
            }
            else if (btn.Contains("down") && split[1] == "9")
            {
                return upvote9;
            }

            if (btn.Contains("up") && split[1] == "10")
            {
                return downvote10;
            }
            else if (btn.Contains("down") && split[1] == "10")
            {
                return upvote10;
            }

            if (btn.Contains("up") && split[1] == "11")
            {
                return downvote11;
            }
            else if (btn.Contains("down") && split[1] == "11")
            {
                return upvote11;
            }

            if (btn.Contains("up") && split[1] == "12")
            {
                return downvote12;
            }
            else if (btn.Contains("down") && split[1] == "12")
            {
                return upvote12;
            }

            if (btn.Contains("up") && split[1] == "13")
            {
                return downvote13;
            }
            else if (btn.Contains("down") && split[1] == "13")
            {
                return upvote13;
            }

            if (btn.Contains("up") && split[1] == "14")
            {
                return downvote14;
            }
            else if (btn.Contains("down") && split[1] == "14")
            {
                return upvote14;
            }

            if (btn.Contains("up") && split[1] == "15")
            {
                return downvote15;
            }
            else if (btn.Contains("down") && split[1] == "15")
            {
                return upvote15;
            }

            if (btn.Contains("up") && split[1] == "16")
            {
                return downvote16;
            }
            else if (btn.Contains("down") && split[1] == "16")
            {
                return upvote16;
            }

            if (btn.Contains("up") && split[1] == "17")
            {
                return downvote17;
            }
            else if (btn.Contains("down") && split[1] == "17")
            {
                return upvote17;
            }


            if (btn.Contains("up") && split[1] == "18")
            {
                return downvote18;
            }
            else if (btn.Contains("down") && split[1] == "18")
            {
                return upvote18;
            }

            if (btn.Contains("up") && split[1] == "19")
            {
                return downvote19;
            }
            else if (btn.Contains("down") && split[1] == "19")
            {
                return upvote19;
            }
            if (btn.Contains("up") && split[1] == "20")
            {
                return downvote20;
            }
            else if (btn.Contains("down") && split[1] == "20")
            {
                return upvote20;
            }
            return null;
        }

        //was thingking of passing the bill data to a function to make it all dynamic like
        //that way the workload is easier.
        protected void setbilldata()
        {
           
        }


        //Loads Prior Votes of a User
        protected void LoadVotes(string user, string state, string district, string Bill, ImageButton UpButton, ImageButton DownButton)
        {
            //Define the DB Connection
            SqlConnection db = new SqlConnection(VoxPopuliDB.ConnectionString);

            //Define the Command to Grab the Prior Votes
            string commandString = "SELECT " + state + "District" + district + Bill + " FROM VP_Users WHERE Username= @User OR Email= @User";
            SqlCommand getPriorVoteCMD = new SqlCommand(commandString, db);
            getPriorVoteCMD.Parameters.AddWithValue("@User", user);
            db.Open();
            try
            {
                int priorVoteValue = (int)getPriorVoteCMD.ExecuteScalar();

                if(priorVoteValue == -1)
                {
                    DownButton.ImageUrl = "~/Images/downvote-clicked.png";
                    UpButton.ImageUrl = "~/Images/upvote-png-clear.png";


                }
                else if (priorVoteValue == 1)
                {
                    DownButton.ImageUrl = "~/Images/downvote-clear.png";
                    UpButton.ImageUrl = "~/Images/upvote-png-green.png";
                }
                else
                {
                    DownButton.ImageUrl = "~/Images/downvote-clear.png";
                    UpButton.ImageUrl = "~/Images/upvote-png-clear.png";
                }
            }
            catch
            {
                //RepNameHolder.InnerText = "SELECT " + state + "District" + district + Bill + " FROM VP_Users WHERE Username= " + user + " OR Email= " + user + "";
            }
            finally
            {
                db.Close();
            }

        }

    }
}