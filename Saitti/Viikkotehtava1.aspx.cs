using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Viikkotehtava1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLaske_Click(object sender, EventArgs e)
    {
        try
        {
            lblMessages.Text = "";
            double leveys = Convert.ToDouble(txtLeveys.Text);
            double korkeus = Convert.ToDouble(txtKorkeus.Text);
            double karminLeveys = Convert.ToDouble(txtKarmi.Text);
            double pintaAla = (korkeus / 1000) * (leveys / 1000); //neliömetreinä
            double piiri = (leveys * 2 / 1000 + korkeus * 2 / 1000);
            double kate = Convert.ToDouble(ConfigurationManager.AppSettings["kate"]) / 100;
            double nelioHinta = Convert.ToDouble(ConfigurationManager.AppSettings["nelioHinta"]);
            double alumiininHinta = Convert.ToDouble(ConfigurationManager.AppSettings["alumiininHinta"]);
            double tyomenekki = Convert.ToDouble(ConfigurationManager.AppSettings["tyomenekki"]);

            double hinta = (1 + kate) * ((pintaAla * nelioHinta) + (piiri * alumiininHinta) + tyomenekki);

            lblPintaAla.Text = Convert.ToString(pintaAla);
            lblPiiri.Text = Convert.ToString(piiri);
            lblHinta.Text = Convert.ToString(hinta);
        }
        catch (Exception)
        {
            lblMessages.Text = "Input numbers only!";
        }
    }
}