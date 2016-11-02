using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NaytaPalaute : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string xmlfilu = "App_Data\\data.xml";

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlfilu)); // huom mappath viittaa webbisaitille
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        gvPalautteet.DataSource = dv;
        gvPalautteet.DataBind();
    }
}