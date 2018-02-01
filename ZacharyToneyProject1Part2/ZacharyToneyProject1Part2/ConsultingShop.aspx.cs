using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZacharyToneyProject1Part2
{
    public partial class ConsultingShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var service = Convert.ToDecimal(DropDownList1.SelectedValue);
            var discount = Convert.ToDecimal(DropDownList2.SelectedValue);
            var sub = service * discount;

            var final = service - sub;

            Label1.Text = "Total: $" + final;
        }
    }
}