using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Oppilaat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHae3_Click(object sender, EventArgs e)
    {
        DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
        gvStudents.DataSource = dt;
        gvStudents.DataBind();

    }

    protected void btnHaeKaikki_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["Oppilaat"].ConnectionString;
        string viesti;
        try
        {
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetAllStudentsFromSQLServer(cs,"oppilaat" , out viesti);
            gvStudents.DataSource = dt;
            gvStudents.DataBind();
            lblMessages.Text = viesti;
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }

    protected void btnGetFromMysli_Click(object sender, EventArgs e)
    {
        try
        {
            string cs = ConfigurationManager.ConnectionStrings["Mysli"].ConnectionString;
            gvStudents.DataSource = JAMK.ICT.Data.DBPlacebo.GetDataFromMysql(cs);
            gvStudents.DataBind();
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}