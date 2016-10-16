using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava6View : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Request.QueryString["Data"];
        srcRecords.XPath = "//record[@ISBN='" + s +"']";

        srcSubRecords.XPath = srcRecords.XPath + "/song";
    }
}