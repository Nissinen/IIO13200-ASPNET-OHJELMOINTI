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
        if (!IsPostBack) {
            Panel1.Visible = false;
            DataTable dt = new DataTable();
        string ConnString = ConfigurationManager.ConnectionStrings["DemoxOyConnectionString"].ConnectionString;
        string select = "Select maa from asiakas";
        try
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand MyCommand = new SqlCommand(select, conn);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(MyCommand);
            
            da.Fill(dt);

            ddlCountries.DataBind();

            conn.Close();
            da.Dispose();
        }
        catch (Exception ex)
        {
                lblMessages.Text = ex.Message;
            }
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (!ddlCountries.Items.Contains(new ListItem(dt.Rows[i]["maa"].ToString())))
            {
                ddlCountries.Items.Add(Convert.ToString(dt.Rows[i]["maa"]));
            }
        }
        ddlCountries.Items.Insert(0, string.Empty);
        }
    }

    protected void btnHaeKaikki_Click(object sender, EventArgs e)
    {
        gvAsiakkaat.Visible = true;
        lblMessages.Text = "";
        string ConnString = ConfigurationManager.ConnectionStrings["DemoxOyConnectionString"].ConnectionString;
        string select = "Select * from asiakas ORDER by maa";
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
            lblMessages.Text = ex.Message;
        }
    }

    protected void btnHaeMaasta_Click(object sender, EventArgs e)
    {
        gvAsiakkaat.Visible = true;
        lblMessages.Text = "";
        string ConnString = ConfigurationManager.ConnectionStrings["DemoxOyConnectionString"].ConnectionString;
        string select = "Select * from asiakas WHERE maa='" + ddlCountries.SelectedValue.ToString() + "'";
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
            lblMessages.Text = ex.Message;
        }
    }

    protected void btnHaeMaittain_Click(object sender, EventArgs e)
    {

        gvAsiakkaat.Visible = false;
        string ConnString = ConfigurationManager.ConnectionStrings["DemoxOyConnectionString"].ConnectionString;
        string select = "Select * from asiakas ORDER by maa";
        DataTable dt = new DataTable();
        try
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand MyCommand = new SqlCommand(select, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(MyCommand);

            da.Fill(dt);

            conn.Close();
            da.Dispose();
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
        string maa = Convert.ToString(dt.Rows[0]["maa"]);
        string check = "";
        lblMessages.Text = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string name = Convert.ToString(dt.Rows[i]["asnimi"]);
            string yhthlo = Convert.ToString(dt.Rows[i]["yhteyshlo"]);
            maa = Convert.ToString(dt.Rows[i]["maa"]);

            if (check != Convert.ToString(dt.Rows[i]["maa"]))
            {
                lblMessages.Text += string.Format("<br> <h1> {1} </h1> {0} {2}", name, maa, yhthlo);
            }
            else
            {
                lblMessages.Text += string.Format("<br> {0} {1}", name, yhthlo);
            }
            check = Convert.ToString(dt.Rows[i]["maa"]);
        }
    }

    protected void btnLuo_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        gvAsiakkaat.Visible = false;
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        string ConnString = ConfigurationManager.ConnectionStrings["DemoxOyConnectionString"].ConnectionString;
        string insert = "Insert into asiakas(astunnus, asnimi, yhteyshlo, maa, postinro, postitmp, ostot, asvuosi) values('" + txtAsTunnus.Text + "','" + txtAsNimi.Text + "','" + txtAsYhtHlo.Text + "','" + txtMaa.Text +
            "','" + txtPostiNro.Text + "','" + txtPostiTmp.Text + "','" + txtOstot.Text + "','" + txtAsVuosi.Text + "')";

        try
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand MyCommand = new SqlCommand(insert, conn);
            SqlDataReader MyReader;
            conn.Open();
            MyReader = MyCommand.ExecuteReader();
            conn.Close();
            lblMessages.Text = "Palaute lähetetty onnistuneesti.";
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
        Panel1.Visible = false;
        gvAsiakkaat.Visible = true;
    }
}