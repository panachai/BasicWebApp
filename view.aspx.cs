using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //pull cookie from system
        HttpCookie ckName = Request.Cookies["Name"];
        HttpCookie ckLast = Request.Cookies["Last"];

        if ((ckName.Value != null) && (ckLast.Value != null))
        {
            lbName.Text = ckName.Value;
            lbSur.Text = ckLast.Value;
        }
        
        /*
        //use in receive parameter
        lbName.Text = Request.QueryString["fn"];
        lbSur.Text = Request.QueryString["ln"];
        */
    }
}