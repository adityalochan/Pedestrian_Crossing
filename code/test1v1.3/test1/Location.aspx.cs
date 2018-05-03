using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1
{
    public partial class Location : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(lblUsrName != null)
            {
                lblUsrName.Text = (Session["UserName"].ToString());
            }
            else
            {
                lblUsrName.Text = "";
            }
        }
       
    protected void Button2_cross_Click(object sender, EventArgs e)
        {
            int Min = 1;
            int Max = 3;

            int[] test2 = new int[3];
            Random randNum = new Random();
           
               int value =  randNum.Next(Min, Max);
            

            OleDbConnection conn1 = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=S:\PedestrianCrossing_WebApplication\USFPedestrianCrossing.mdb");
            conn1.Open();
            OleDbCommand command1 = new OleDbCommand("select signal_name,ID,crossing1,crossing2,crossing3,crossing4,coordinate_x,coordinate_y from signals WHERE ID="+ value ,conn1);
            OleDbDataReader reader1 = command1.ExecuteReader();
            
                if (reader1.Read())
                {
                    Session["SignalName"] = reader1[0].ToString();
                    Session["ID"] = reader1[1].ToString();
                    Session["Crossing1"] = reader1[2].ToString();
                    Session["Crossing2"] = reader1[3].ToString();
                    Session["Crossing3"] = reader1[4].ToString();
                    Session["Crossing4"] = reader1[5].ToString();
                    Session["locationx"] = reader1[6].ToString();
                    Session["locationy"] = reader1[7].ToString();
                    Response.Redirect("CrossStreet.aspx");
                }
                else
                {
                    Response.Write("Not Found");
                }
          
            conn1.Close();
        }
    }
}