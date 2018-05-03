using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1
{
    public partial class CrossStreet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["SignalName"].ToString() != "")
            {
                lblSignalName.Text = Session["SignalName"].ToString();
            }
            else
            {
                lblSignalName.Text = "no signal found";
            }

            if (Session["Crossing1"].ToString() != "")
            {
                Button1_Crossing1.Text = Session["Crossing1"].ToString();
            }
            else
            {
                Button1_Crossing1.Text = "No Crossing";
            }

            if (Session["Crossing2"].ToString() != "")
            {
                Button2_Crossing2.Text = Session["Crossing2"].ToString();
            }
            else
            {
                Button2_Crossing2.Text = "No Crossing";
            }

            if (Session["Crossing3"].ToString() != "")
            {
                Button3_Crossing3.Text = Session["Crossing3"].ToString();
            }
            else
            {
                Button3_Crossing3.Text = "No Crossing";
            }

            if (Session["Crossing4"].ToString() != "")
            {
                Button4_Crossing4.Text = Session["Crossing4"].ToString();
            }
            else
            {
                Button4_Crossing4.Text = "No Crossing";
            }
        }

        protected void Button1_Crossing1_Click(object sender, EventArgs e)
        {
            if (Button1_Crossing1.Text != "No Crossing")
            {
                Response.Redirect("CountDown.aspx");
            }
            else
            {
                Button1_Crossing1.Text = "Invalid";
            }
        }

        protected void Button2_Crossing2_Click(object sender, EventArgs e)
        {
            if (Button2_Crossing2.Text != "No Crossing")
            {
                Response.Redirect("CountDown.aspx");
            }
            else
            {
                Button2_Crossing2.Text = "Invalid";
            }
        }

        protected void Button3_Crossing3_Click(object sender, EventArgs e)
        {
            if (Button3_Crossing3.Text != "No Crossing")
            {
                Response.Redirect("CountDown.aspx");
            }
            else
            {
                Button3_Crossing3.Text = "Invalid";
            }
        }

        protected void Button4_Crossing4_Click(object sender, EventArgs e)
        {
            if (Button4_Crossing4.Text != "No Crossing")
            {
                Response.Redirect("CountDown.aspx");
            }
            else
            {
                Button4_Crossing4.Text = "Invalid";
            }
        }

        protected void Button1_searchlocation_Click(object sender, EventArgs e)
        {
                    Response.Redirect("GoogleMap.aspx");
        }
    }
}