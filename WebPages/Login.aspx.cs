using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web.UI;
using System.Security.Cryptography;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;

namespace VoxPopuli.WebPages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string uservalue = txtUsername.Text;
            string encryptedpassvalue = Encrypt(txtPassword.Text);
            SqlConnection db = new SqlConnection(VoxPopuliDB.ConnectionString);
            SqlCommand user_signin_cmd = new SqlCommand("SELECT COUNT(*) FROM VP_Users WHERE Username= @Username AND Password= @Password OR Email= @Email AND Password= @Password", db);
            user_signin_cmd.Parameters.AddWithValue("@Username", uservalue);
            user_signin_cmd.Parameters.AddWithValue("@Password", encryptedpassvalue);
            user_signin_cmd.Parameters.AddWithValue("@Email", uservalue);
            db.Open();
            try

            {
                int nID = (int)user_signin_cmd.ExecuteScalar();
                if (nID > 0)
                {

                    lblInvalid.Visible = false;
                    //HttpCookie cookie = new HttpCookie("Userinfo");
                    //cookie["Name"] = txtUsername.Text;

                    //Response.Cookies.Add(cookie);

                    Response.Redirect("~/WebPages/MainPage.aspx");
                }
                else
                {
                    lblInvalid.Visible = true;
                }






            }
            catch
            {
                lblInvalid.Text = "SQl User Check could not be executed";
                lblInvalid.Visible = true;
            }
            finally
            {
                db.Close();
            }
        }

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