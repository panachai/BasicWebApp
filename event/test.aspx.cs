using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("sssss1");
    }

 

    protected void Button1_Click(object sender, EventArgs e)
    {
        lbResult.Text = tbName.Text + " " + lsProduct.SelectedItem.Text+" : Chang by event OnClick ";
    }

    protected void lsProduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbResult.Text = tbName.Text + " " + lsProduct.SelectedItem.Text+" : Chang by event Selected ";
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        lbResultC.Text = "You choose : " + cl1.SelectedDate.Date.ToString();
    }
}