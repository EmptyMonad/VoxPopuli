using System;
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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
          
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
            SqlCommand getBill314VoteCMD = new SqlCommand("SELECT vote_position FROM Bill314 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill315VoteCMD = new SqlCommand("SELECT vote_position FROM Bill315 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill316VoteCMD = new SqlCommand("SELECT vote_position FROM Bill316 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill317VoteCMD = new SqlCommand("SELECT vote_position FROM Bill317 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill318VoteCMD = new SqlCommand("SELECT vote_position FROM Bill318 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill319VoteCMD = new SqlCommand("SELECT vote_position FROM Bill319 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill320VoteCMD = new SqlCommand("SELECT vote_position FROM Bill320 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill321VoteCMD = new SqlCommand("SELECT vote_position FROM Bill321 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill322VoteCMD = new SqlCommand("SELECT vote_position FROM Bill322 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill323VoteCMD = new SqlCommand("SELECT vote_position FROM Bill323 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill324VoteCMD = new SqlCommand("SELECT vote_position FROM Bill324 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill325VoteCMD = new SqlCommand("SELECT vote_position FROM Bill325 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill326VoteCMD = new SqlCommand("SELECT vote_position FROM Bill326 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill327VoteCMD = new SqlCommand("SELECT vote_position FROM Bill327 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill328VoteCMD = new SqlCommand("SELECT vote_position FROM Bill328 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill329VoteCMD = new SqlCommand("SELECT vote_position FROM Bill329 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill330VoteCMD = new SqlCommand("SELECT vote_position FROM Bill330 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill331VoteCMD = new SqlCommand("SELECT vote_position FROM Bill331 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill332VoteCMD = new SqlCommand("SELECT vote_position FROM Bill332 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill333VoteCMD = new SqlCommand("SELECT vote_position FROM Bill333 WHERE state='TX' AND district ='1'", db);
            SqlCommand getBill334VoteCMD = new SqlCommand("SELECT vote_position FROM Bill334 WHERE state='TX' AND district ='1'", db);




            //Bill315
            SqlCommand getBill315Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='315'", db);
            SqlCommand getBill315ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='315'", db);
            SqlCommand getBill315Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='315'", db);
            SqlCommand getBill315Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='315'", db);

            //Billl316
            SqlCommand getBill316Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='316'", db);
            SqlCommand getBill316ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='316'", db);
            SqlCommand getBill316Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='316'", db);
            SqlCommand getBill316Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='316'", db);


            //Bill317
            SqlCommand getBill317Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='317'", db);
            SqlCommand getBill317ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='317'", db);
            SqlCommand getBill317Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='317'", db);
            SqlCommand getBill317Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='317'", db);


            //Bill 318
            SqlCommand getBill318Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='318'", db);
            SqlCommand getBill318ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='318'", db);
            SqlCommand getBill318Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='318'", db);
            SqlCommand getBill318Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='318'", db);

            //Bill 319

            SqlCommand getBill319Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='319'", db);
            SqlCommand getBill319ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='319'", db);
            SqlCommand getBill319Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='319'", db);
            SqlCommand getBill319Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='319'", db);


            //Bill 320
            SqlCommand getBill320Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='320'", db);
            SqlCommand getBill320ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='320'", db);
            SqlCommand getBill320Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='320'", db);
            SqlCommand getBill320Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='320'", db);


            //Bill 321
            SqlCommand getBill321Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='321'", db);
            SqlCommand getBill321ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='321'", db);
            SqlCommand getBill321Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='321'", db);
            SqlCommand getBill321Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='321'", db);


            //Bill 322
            SqlCommand getBill322Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='322'", db);
            SqlCommand getBill322ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='322'", db);
            SqlCommand getBill322Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='322'", db);
            SqlCommand getBill322Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='322'", db);


            //Bill 323
            SqlCommand getBill323Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='323'", db);
            SqlCommand getBill323ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='323'", db);
            SqlCommand getBill323Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='323'", db);
            SqlCommand getBill323Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='323'", db);


            //Bill 324
            SqlCommand getBill324Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='324'", db);
            SqlCommand getBill324ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='324'", db);
            SqlCommand getBill324Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='324'", db);
            SqlCommand getBill324Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='324'", db);

            //Bill 325
            SqlCommand getBill325Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='325'", db);
            SqlCommand getBill325ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='325'", db);
            SqlCommand getBill325Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='325'", db);
            SqlCommand getBill325Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='325'", db);


            //Bill 326
            SqlCommand getBill326Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='326'", db);
            SqlCommand getBill326ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='326'", db);
            SqlCommand getBill326Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='326'", db);
            SqlCommand getBill326Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='326'", db);


            //Bill 327
            SqlCommand getBill327Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='327'", db);
            SqlCommand getBill327ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='327'", db);
            SqlCommand getBill327Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='327'", db);
            SqlCommand getBill327Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='327'", db);


            //Bill 328
            SqlCommand getBill328Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='328'", db);
            SqlCommand getBill328ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='328'", db);
            SqlCommand getBill328Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='328'", db);
            SqlCommand getBill328Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='328'", db);


            //Bill 329
            SqlCommand getBill329Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='329'", db);
            SqlCommand getBill329ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='329'", db);
            SqlCommand getBill329Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='329'", db);
            SqlCommand getBill329Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='329'", db);


            //Bill 330
            SqlCommand getBill330Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='330'", db);
            SqlCommand getBill330ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='330'", db);
            SqlCommand getBill330Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='330'", db);
            SqlCommand getBill330Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='330'", db);


            //Bill 331
            SqlCommand getBill331Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='331'", db);
            SqlCommand getBill331ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='331'", db);
            SqlCommand getBill331Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='331'", db);
            SqlCommand getBill331Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='331'", db);


            //Bill 332
            SqlCommand getBill332Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='332'", db);
            SqlCommand getBill332ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='332'", db);
            SqlCommand getBill332Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='332'", db);
            SqlCommand getBill332Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='332'", db);


            //Bill 333
            SqlCommand getBill333Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='333'", db);
            SqlCommand getBill333ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='333'", db);
            SqlCommand getBill333Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='333'", db);
            SqlCommand getBill333Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='333'", db);

            SqlCommand getBill334Name = new SqlCommand("SELECT BillTitle FROM BillInfo WHERE RollCallNumber='334'", db);
            SqlCommand getBill334ID = new SqlCommand("SELECT BillID FROM BillInfo WHERE RollCallNumber='334'", db);
            SqlCommand getBill334Result = new SqlCommand("SELECT Result FROM BillInfo WHERE RollCallNumber='334'", db);
            SqlCommand getBill334Link = new SqlCommand("SELECT BillLink FROM BillInfo WHERE RollCallNumber='334'", db);













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
                string Bill315Vote = (string)getBill315VoteCMD.ExecuteScalar();
                string Bill316Vote = (string)getBill316VoteCMD.ExecuteScalar();
                string Bill317Vote = (string)getBill317VoteCMD.ExecuteScalar();
                string Bill318Vote = (string)getBill318VoteCMD.ExecuteScalar();
                string Bill319Vote = (string)getBill319VoteCMD.ExecuteScalar();
                string Bill320Vote = (string)getBill320VoteCMD.ExecuteScalar();
                string Bill321Vote = (string)getBill321VoteCMD.ExecuteScalar();
                string Bill322Vote = (string)getBill322VoteCMD.ExecuteScalar();
                string Bill323Vote = (string)getBill323VoteCMD.ExecuteScalar();
                string Bill324Vote = (string)getBill324VoteCMD.ExecuteScalar();
                string Bill325Vote = (string)getBill325VoteCMD.ExecuteScalar();
                string Bill326Vote = (string)getBill326VoteCMD.ExecuteScalar();
                string Bill327Vote = (string)getBill327VoteCMD.ExecuteScalar();
                string Bill328Vote = (string)getBill328VoteCMD.ExecuteScalar();
                string Bill329Vote = (string)getBill329VoteCMD.ExecuteScalar();
                string Bill330Vote = (string)getBill330VoteCMD.ExecuteScalar();
                string Bill331Vote = (string)getBill331VoteCMD.ExecuteScalar();
                string Bill332Vote = (string)getBill332VoteCMD.ExecuteScalar();
                string Bill333Vote = (string)getBill333VoteCMD.ExecuteScalar();
                string Bill334Vote = (string)getBill334VoteCMD.ExecuteScalar();

                //Execute Commands for Bill Information


                //Bill 315
                string Bill315Name = (string)getBill315Name.ExecuteScalar();
                string Bill315ID = (string)getBill315ID.ExecuteScalar();
                string Bill315Link = (string)getBill315Link.ExecuteScalar();
                string Bill315Result = (string)getBill315Result.ExecuteScalar();

                //Bill316
                string Bill316Name = (string)getBill316Name.ExecuteScalar();
                string Bill316ID = (string)getBill316ID.ExecuteScalar();
                string Bill316Link = (string)getBill316Link.ExecuteScalar();
                string Bill316Result = (string)getBill316Result.ExecuteScalar();

                //Bill317
                string Bill317Name = (string)getBill317Name.ExecuteScalar();
                string Bill317ID = (string)getBill317ID.ExecuteScalar();
                string Bill317Link = (string)getBill317Link.ExecuteScalar();
                string Bill317Result = (string)getBill317Result.ExecuteScalar();

                //Bill318
                string Bill318Name = (string)getBill318Name.ExecuteScalar();
                string Bill318ID = (string)getBill318ID.ExecuteScalar();
                string Bill318Link = (string)getBill318Link.ExecuteScalar();
                string Bill318Result = (string)getBill318Result.ExecuteScalar();

                //Bill319
                string Bill319Name = (string)getBill319Name.ExecuteScalar();
                string Bill319ID = (string)getBill319ID.ExecuteScalar();
                string Bill319Link = (string)getBill319Link.ExecuteScalar();
                string Bill319Result = (string)getBill319Result.ExecuteScalar();

                //Billl320
                string Bill320Name = (string)getBill320Name.ExecuteScalar();
                string Bill320ID = (string)getBill320ID.ExecuteScalar();
                string Bill320Link = (string)getBill320Link.ExecuteScalar();
                string Bill320Result = (string)getBill320Result.ExecuteScalar();

                //Bill321
                string Bill321Name = (string)getBill321Name.ExecuteScalar();
                string Bill321ID = (string)getBill321ID.ExecuteScalar();
                string Bill321Link = (string)getBill321Link.ExecuteScalar();
                string Bill321Result = (string)getBill321Result.ExecuteScalar();

                //Bill322
                string Bill322Name = (string)getBill322Name.ExecuteScalar();
                string Bill322ID = (string)getBill322ID.ExecuteScalar();
                string Bill322Link = (string)getBill322Link.ExecuteScalar();
                string Bill322Result = (string)getBill322Result.ExecuteScalar();

                //Bill 323
                string Bill323Name = (string)getBill323Name.ExecuteScalar();
                string Bill323ID = (string)getBill323ID.ExecuteScalar();
                string Bill323Link = (string)getBill323Link.ExecuteScalar();
                string Bill323Result = (string)getBill323Result.ExecuteScalar();

                //Bill 324
                string Bill324Name = (string)getBill324Name.ExecuteScalar();
                string Bill324ID = (string)getBill324ID.ExecuteScalar();
                string Bill324Link = (string)getBill324Link.ExecuteScalar();
                string Bill324Result = (string)getBill324Result.ExecuteScalar();

                //Bill 325

                string Bill325Name = (string)getBill325Name.ExecuteScalar();
                string Bill325ID = (string)getBill325ID.ExecuteScalar();
                string Bill325Link = (string)getBill325Link.ExecuteScalar();
                string Bill325Result = (string)getBill325Result.ExecuteScalar();

                //Bill 326
                string Bill326Name = (string)getBill326Name.ExecuteScalar();
                string Bill326ID = (string)getBill326ID.ExecuteScalar();
                string Bill326Link = (string)getBill326Link.ExecuteScalar();
                string Bill326Result = (string)getBill326Result.ExecuteScalar();

                //Bill 327
                string Bill327Name = (string)getBill327Name.ExecuteScalar();
                string Bill327ID = (string)getBill327ID.ExecuteScalar();
                string Bill327Link = (string)getBill327Link.ExecuteScalar();
                string Bill327Result = (string)getBill327Result.ExecuteScalar();

                //Bill 328
                string Bill328Name = (string)getBill328Name.ExecuteScalar();
                string Bill328ID = (string)getBill328ID.ExecuteScalar();
                string Bill328Link = (string)getBill328Link.ExecuteScalar();
                string Bill328Result = (string)getBill328Result.ExecuteScalar();

                //Bill 329
                string Bill329Name = (string)getBill329Name.ExecuteScalar();
                string Bill329ID = (string)getBill329ID.ExecuteScalar();
                string Bill329Link = (string)getBill329Link.ExecuteScalar();
                string Bill329Result = (string)getBill329Result.ExecuteScalar();

                //Bill 330
                string Bill330Name = (string)getBill330Name.ExecuteScalar();
                string Bill330ID = (string)getBill330ID.ExecuteScalar();
                string Bill330Link = (string)getBill330Link.ExecuteScalar();
                string Bill330Result = (string)getBill330Result.ExecuteScalar();

                //Bill 331
                string Bill331Name = (string)getBill331Name.ExecuteScalar();
                string Bill331ID = (string)getBill331ID.ExecuteScalar();
                string Bill331Link = (string)getBill331Link.ExecuteScalar();
                string Bill331Result = (string)getBill331Result.ExecuteScalar();

                //Bill 332
                string Bill332Name = (string)getBill332Name.ExecuteScalar();
                string Bill332ID = (string)getBill332ID.ExecuteScalar();
                string Bill332Link = (string)getBill332Link.ExecuteScalar();
                string Bill332Result = (string)getBill332Result.ExecuteScalar();

                //Bill 333
                string Bill333Name = (string)getBill333Name.ExecuteScalar();
                string Bill333ID = (string)getBill333ID.ExecuteScalar();
                string Bill333Link = (string)getBill333Link.ExecuteScalar();
                string Bill333Result = (string)getBill333Result.ExecuteScalar();

                string Bill334Name = (string)getBill334Name.ExecuteScalar();
                string Bill334ID = (string)getBill334ID.ExecuteScalar();
                string Bill334Link = (string)getBill334Link.ExecuteScalar();
                string Bill334Result = (string)getBill334Result.ExecuteScalar();










                //Replace HTML Elements Based off Information Pulled From The Database
                RepNameHolder.InnerHtml = repFirstName + " " + repLastName;
                twitterHandle.InnerHtml = "@" + repTwitter;

                Bill1.PostBackUrl = Bill334Link;
                billname1.InnerHtml = Bill334Name;
                BillID1.InnerHtml = "Bill ID: " + Bill334ID;
                result1.InnerHtml = "Bill Result: " + Bill334Result;
                repvote1.InnerHtml = repFirstName + " " + repLastName + " Voted: " + Bill334Vote;

                










            }
            catch
            {

            }

            finally
            {
                db.Close();
            }




            //Now, We Will Need to Populate Prior Votes From The User. Implementing LoadVotes function

            
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

           //*/ if (btn.Contains("up") && split[1] == "7")
           // {
           //     return downvote7;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // }

           // if (btn.Contains("up") && split[1] == "1")
           // {
           //     return downvote1;
           // }
           // else if (btn.Contains("down") && split[1] == "1")
           // {
           //     return upvote1;
           // } 
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
            SqlCommand getPriorVote = new SqlCommand("SELECT " + state + "District" + district + "Bill" + Bill + " FROM VP_Users WHERE Username OR Email = " + user + "", db);

            db.Open();
            try
            {
                int priorVoteValue = (int)getPriorVote.ExecuteScalar();

                if(priorVoteValue == -1)
                {
                    DownButton.ImageUrl = "";
                    UpButton.ImageUrl = "";


                }
                else if (priorVoteValue ==1)
                {
                    DownButton.ImageUrl = "";
                    UpButton.ImageUrl = "";
                }
                else
                {
                    DownButton.ImageUrl = "";
                    UpButton.ImageUrl = "";
                }
            }
            catch
            {

            }
            finally
            {

            }

        }

    }
}