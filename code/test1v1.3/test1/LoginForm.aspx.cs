using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace test1
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_login_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=S:\PedestrianCrossing_WebApplication\USFPedestrianCrossing.mdb");
            conn.Open();
            OleDbCommand command = new OleDbCommand("select UID,Password,FirstName,LastName from registration where [UID]='"+ TextBox1_usrname.Text+"' AND [Password] = '"+ TextBox2_pwd.Text+"'",conn);
            using(OleDbDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Session["UserName"] = reader[2].ToString() + " " + reader[3].ToString();
                    Response.Redirect("Location.aspx");
                }   
                else
                {
                    Response.Write("Not Found");
                }
            }
            conn.Close();
        }

        protected void Button2_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationForm.aspx");
        }

        protected void Button3_downloadapp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://adityaandroidapplication.s3-website.us-east-2.amazonaws.com/");
        }
    }
}