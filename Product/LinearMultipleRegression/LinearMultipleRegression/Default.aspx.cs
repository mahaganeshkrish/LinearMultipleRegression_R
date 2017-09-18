using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinearMultipleRegression
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitClick(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(TextBox1.Text);
            double x2 = Convert.ToDouble(TextBox2.Text);
            double x3 = Convert.ToDouble(TextBox3.Text);
            double x4 = Convert.ToDouble(TextBox4.Text);
            double x5 = Convert.ToDouble(TextBox5.Text);
            double x6 = Convert.ToDouble(TextBox6.Text);
            double x7 = Convert.ToDouble(TextBox7.Text);
            double x8 = Convert.ToDouble(TextBox8.Text);
            double x9 = Convert.ToDouble(TextBox9.Text);
            double x10 = Convert.ToDouble(TextBox10.Text);
            double x11 = Convert.ToDouble(TextBox11.Text);
            double x12 = Convert.ToDouble(TextBox12.Text);
            double x13 = Convert.ToDouble(TextBox13.Text);
            double x14 = Convert.ToDouble(TextBox14.Text);
            double x15 = Convert.ToDouble(TextBox15.Text);
            double x16 = Convert.ToDouble(TextBox16.Text);
            double x17 = Convert.ToDouble(TextBox17.Text);
            double x18 = Convert.ToDouble(TextBox18.Text);
            double x19 = Convert.ToDouble(TextBox19.Text);
            double x20 = Convert.ToDouble(TextBox20.Text);
            double x21 = Convert.ToDouble(TextBox21.Text);
            double x22 = Convert.ToDouble(TextBox22.Text);
            double x23 = Convert.ToDouble(TextBox23.Text);
            double x24 = Convert.ToDouble(TextBox24.Text);
            double x25 = Convert.ToDouble(TextBox25.Text);
            double x26 = Convert.ToDouble(TextBox26.Text);
            double x27 = Convert.ToDouble(TextBox27.Text);
            double x28 = Convert.ToDouble(TextBox28.Text);
            double x29 = Convert.ToDouble(TextBox29.Text);
            double x30 = Convert.ToDouble(TextBox30.Text);
            double y = (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15 + x16 + x17 + x18 + x19 + x20 + x21 + x22 + x23 + x24 + x25 + x26 + x27 + x28 + x29 + x30) / 30;
            Label31.Text = y.ToString();
        }
    }
}