using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/// <summary>
/// refernce was taken from https://www.youtube.com/watch?v=m8nxEdOrXwQ
/// </summary>
namespace test1
{
    public partial class CountDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Timer"] = DateTime.Now.AddSeconds(30).ToString();
            }
        }
        protected void timerTest_tick(object sen,EventArgs e)
        {
            if (DateTime.Compare(DateTime.Now, DateTime.Parse(Session["Timer"].ToString())) < 0)
            {
                litMsg.Text = "Time Left: "  + (((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalSeconds) % 60)
                    .ToString() + "Seconds";
            }
            else
            {
                litMsg.Text = "Time is over";
                Response.Redirect("Location.aspx");
            }
        }
    }
}