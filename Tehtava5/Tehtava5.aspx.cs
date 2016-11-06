using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ConnString = ConfigurationManager.ConnectionStrings["DemoxOyConnectionString"].ConnectionString;
        string select = "Select maa from asiakas";
        try
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand MyCommand = new SqlCommand(select, conn);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(MyCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ddlCountries.DataSource = dt;
            ddlCountries.DataTextField = "maa";
            ddlCountries.DataBind();
            /*        var result = from c in dt select new { c.id, c.lastname };
                //määritellään dropdownlistille mitä se esittää
                ddlCountries.SelectedIndex = -1;
                ddlCountries.DataSource = result.ToList();
                ddlCountries.DataTextField = "lastname";
                ddlCountries.DataValueField = "id";
                ddlCountries.DataBind();
                ddlCountries.Items.Insert(0, string.Empty);*/

            gvAsiakkaat.DataSource = dt;
            gvAsiakkaat.DataBind();
            conn.Close();
            da.Dispose();
        }
        catch (Exception ex)
        {

        }
    }

    protected void btnHaeKaikki_Click(object sender, EventArgs e)
    {
        string ConnString = ConfigurationManager.ConnectionStrings["DemoxOyConnectionString"].ConnectionString;
        string select = "Select * from asiakas";
        try
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand MyCommand = new SqlCommand(select, conn);
            
            conn.Open();
            SqlDataReader MyReader = MyCommand.ExecuteReader();
            gvAsiakkaat.DataSource = MyReader;
            gvAsiakkaat.DataBind();
            conn.Close();
        }
        catch (Exception ex)
        {
            
        }
    }
}