using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace VoxPopuli.WebPages
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            string EncodedResponse = Request.Form["g-Recaptcha-Response"];
            bool IsCaptchaValid = (ReCaptchaClass.Validate(EncodedResponse) == "true" ? true : false);

            if (IsCaptchaValid)
            {
                //Valid Request
            
            

                //Check Username Requirements
                //Must not contain any spaces must be longer than 5 characters, and no more than 20 characters
                string uservalue = txtboxUsername.Text;
                bool isUserLength = uservalue.Length >= 5 && uservalue.Length <= 20;
                bool userSpaceChar = uservalue.Any(char.IsWhiteSpace);

                //If one these requirements is not met, the error label will be made visible. If they are all met, lable will stay invisible
                if (isUserLength && !userSpaceChar)
                {
                    lblUserReq.Visible = false;
                }
                else
                {
                    lblUserReq.Visible = true;
                }



                //Check Email Format
                //must have the format of something@example.com
                string emailValue = txtboxEmail.Text;
                bool containsAtSymbol = emailValue.Contains("@");
                bool containsPeriod = emailValue.Contains(".");

                if (containsAtSymbol && containsPeriod)
                {
                    lblEmailReq.Visible = false;
                }
                else
                {
                    lblEmailReq.Visible = true;
                }




                //Check Password Requirements
                //Password must be at least 8 characters, no more than 30 characters, , must not contain a space, must contain an uppercase character, a lowercase character, and a digit. 

                string passvalue = txtboxPassword.Text;
                bool isPassLength = passvalue.Length >= 8 && passvalue.Length <= 30;
                bool lowercase = passvalue.Any(char.IsLower);
                bool uppercase = passvalue.Any(char.IsUpper);
                bool digit = passvalue.Any(char.IsDigit);
                bool passSpaceChar = passvalue.Any(char.IsWhiteSpace);


                //If one these requirements is not met, the error label will be made visible. If they are all met, lable will stay invisible
                if (isPassLength && lowercase && uppercase && digit && !passSpaceChar)
                {
                    lblPasswordReq.Visible = false;
                }
                else
                {
                    lblPasswordReq.Visible = true;
                }





                //If All Requirements are Met Check
                if (lblUserReq.Visible == false && lblEmailReq.Visible == false && lblPasswordReq.Visible == false)
                {
                    //First, Check If the Username already exists in DB

                    SqlConnection db = new SqlConnection(SqlDataSource1.ConnectionString);
                    SqlCommand userCheck_cmd = new SqlCommand("SELECT COUNT(*) FROM VP_Users WHERE Username= @Username", db);
                    userCheck_cmd.Parameters.AddWithValue("@Username", uservalue);
                    db.Open();
                    try
                    {
                        //Counts Occurences of Username
                        int nID = (int)userCheck_cmd.ExecuteScalar();

                        //If more than 0 occurences of this username exist
                        if (nID > 0)
                        {

                            lblUsernameExist.Visible = true;
                        }
                        else
                        {
                            lblUsernameExist.Visible = false;


                            //This statement is executed if username was not found. Next, check if Email already exists in DB
                            SqlCommand emailCheck_cmd = new SqlCommand("SELECT COUNT(*) FROM VP_Users WHERE Email= @Email", db);
                            emailCheck_cmd.Parameters.AddWithValue("@Email", emailValue);
                            try
                            {
                                //Count occurences of email in DB
                                int nID2 = (int)emailCheck_cmd.ExecuteScalar();

                                //IF more than 0 occurences of email exist in DB
                                if (nID2 > 0)
                                {
                                    lblEmailExist.Visible = true;

                                }
                                else
                                {
                                    lblEmailExist.Visible = false;
                                    //This statement is executed if username and Email Do no exist in DB. Next, the user information will be used to create a new entry in User table

                                    //Call Encrypt function to encrypt password before entering into DB
                                    string encryptedPassValue = Encrypt(passvalue);
                                    SqlCommand createUser_cmd = new SqlCommand();
                                    createUser_cmd.CommandType = System.Data.CommandType.Text;
                                    createUser_cmd.CommandText = "INSERT INTO VP_Users ([Username],[Password],[Email]) VALUES ('" + uservalue + "','" + encryptedPassValue + "','" + emailValue + "')";
                                    createUser_cmd.Connection = db;
                                    try
                                    {
                                        createUser_cmd.ExecuteNonQuery();
                                        //  HttpCookie cookie = new HttpCookie("Userinfo");
                                        // cookie["Name"] = uservalue;

                                        // Response.Cookies.Add(cookie);
                                        Response.Redirect("../MainPage.aspx");
                                    }
                                    catch
                                    {
                                        lblTest.Text = "Unable to insert user";
                                        lblTest.Visible = true;
                                    }

                                }
                            }
                            catch
                            {
                                lblTest.Text = "Error with email check";
                                lblTest.Visible = true;
                            }

                        }

                    }
                    catch
                    {
                        lblTest.Text = "Error with username check";
                        lblTest.Visible = true;
                    }
                    finally
                    {
                        db.Close();
                    }
                }

            }
            else
            {
                rfvCaptcha.Visible = true;
            }


        }
        protected static string ReCaptcha_Key = "6Lc-4xQdAAAAANtCCYS0lzDT3xZlFQv_1WyJdLWg";
        protected static string ReCaptcha_Secret = "6Lc-4xQdAAAAADYb61HRSmFwU-XEnoHwxQoNWdtt";
        [WebMethod]
        public static string VerifyCaptcha(string response)
        {
            string url = "https://www.google.com/recaptcha/api/siteverify?secret=" + ReCaptcha_Secret + "&response=" + response;
            return (new WebClient()).DownloadString(url);
        }

        //Encrypt Function. Used for password encrypiton.
        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }
    }
}


