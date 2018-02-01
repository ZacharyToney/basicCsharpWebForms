using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZacharyToneyProject1Part4
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var p = Convert.ToDouble(TextBox1.Text);
            var d = Convert.ToDouble(TextBox2.Text);
            var r = Convert.ToDouble(TextBox3.Text);
            var n = Convert.ToDouble(TextBox4.Text);

            var i = r / 1200;
            n = n * 12;
            var m = ((p - d) * i * Math.Pow((1 + i),n)) / (Math.Pow((1 + i) , n) - 1);

            Label5.Text = "Your monthly car payment will be: $" + m;
        }
    }
}