using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton_Command(Object sender, CommandEventArgs e)
    {
        Response.Redirect("Tehtava6View.aspx?Data=" + e.CommandArgument);
    }
}