using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace test1
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_regsubmit_Click(object sender, EventArgs e)
        {
            String FirstName = txtFirstName.Text.ToString();
            String LastName = txtLastName.Text.ToString();
            String UID = txtUid.Text.ToString();
            String Password = txtPassword.Text.ToString();
            String EmailId = txtEmailId.Text.ToString();

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=S:\PedestrianCrossing_WebApplication\USFPedestrianCrossing.mdb");
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT into registration([FirstName],[LastName],[UID],[Password],[Email-ID]) Values(@FirstName,@LastName,@UID,@Password,@EmailId)", conn);
            cmd.Connection = conn;
            if(conn.State == ConnectionState.Open)
            {
                // assigning values to the parameters 
                cmd.Parameters.Add("@FirstName", OleDbType.VarChar).Value = FirstName;
                cmd.Parameters.Add("@LastName", OleDbType.VarChar).Value = LastName;
                cmd.Parameters.Add("@UID", OleDbType.VarChar).Value = UID;
                cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Password;
                cmd.Parameters.Add("@EmailId", OleDbType.VarChar).Value = EmailId;

                try
                {
                    cmd.ExecuteNonQuery();
                    Response.Redirect("LoginForm.aspx");
                    conn.Close();
                }
                catch(OleDbException ex)
                {
                    Response.Write(ex.Source);
                    conn.Close();
                }
            }
            else
            {
                Response.Write("Connection Failed");
            }

        }
    }
}