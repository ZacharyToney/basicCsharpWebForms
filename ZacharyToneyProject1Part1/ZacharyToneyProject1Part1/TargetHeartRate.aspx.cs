using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZacharyToneyProject1Part1
{
    public partial class TargetHeartRate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var restingHeartRate = Convert.ToInt32(TextBox2.Text);
            var age = Convert.ToInt32(TextBox3.Text);

            var maxHeartRate = 220 - age;
            var sub = maxHeartRate - restingHeartRate;
            var final = (sub * 0.6) + restingHeartRate;

            Label1.Text = "Your target heart rate is: " + final;



        }
    }
}