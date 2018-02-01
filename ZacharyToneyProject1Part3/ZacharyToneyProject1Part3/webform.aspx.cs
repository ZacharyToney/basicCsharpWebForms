using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZacharyToneyProject1Part3
{
    public partial class webform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var q = Convert.ToDouble(TextBox1.Text);
            var a = Convert.ToDouble(TextBox2.Text);
            var m = Convert.ToDouble(TextBox3.Text);
            var f = Convert.ToDouble(TextBox4.Text);

            var averageScore = (q * .15) + (a * .40) + (m * .2) + (f * .25);
            var grade = "";

            if (averageScore >= 90)
            {
                grade = "A";
            }
            else if ((averageScore < 90) & (averageScore >= 80))
            {
                grade = "B";
            }
            else if ( (averageScore < 80) & (averageScore >= 70) )
            {
                grade = "C";
            }
            else if((averageScore < 70) & (averageScore >= 60))
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Label1.Text = "Your average score is: " + averageScore + " Your letter grade is: " + grade;
        }
    }
}