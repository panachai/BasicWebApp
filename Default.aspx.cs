using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private HttpCookie ckName = new HttpCookie("Name");
    private HttpCookie ckLast = new HttpCookie("Last");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //set value cookie
        ckName.Value = tbName.Text;
        ckLast.Value = tbSur.Text;

        //add object cookie
        Response.Cookies.Add(ckName);
        Response.Cookies.Add(ckLast);

        Response.RedirectPermanent("view.aspx");

        /*
        //send parameter
        String url = "view.aspx?fn=" + tbName.Text + "&ln=" + tbSur.Text;
        Response.RedirectPermanent(url);
        */


    }
}