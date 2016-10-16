using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Tehtava8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (lbTeatterit.Items.Count < 1)
        {
            try
            {
                XmlDocument doc1 = new XmlDocument();
                doc1.Load("http://www.finnkino.fi/xml/TheatreAreas/");
                XmlElement root = doc1.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("/TheatreAreas/TheatreArea");
                foreach (XmlNode node in nodes)
                {
                    lbTeatterit.Items.Add(new ListItem(node["Name"].InnerText, node["ID"].InnerText));
                }
                errMsg.Text = "";
            }
            catch (Exception ex)
            {
                errMsg.Text = ex.Message;
            }
        }
    }

    protected void lbTeatterit_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            List<String> photos = new List<string>();
            DateTime thisDay = DateTime.Today;
            string date = thisDay.Day.ToString() + "." + thisDay.Month.ToString() + "." + thisDay.Year.ToString();
            XmlDocument doc1 = new XmlDocument();
            string route = "http://www.finnkino.fi/xml/Schedule/?area=" + lbTeatterit.SelectedValue.ToString() + "&dt=" + date;
            doc1.Load(route);
            XmlElement root = doc1.DocumentElement;  
            XmlNodeList nodes = root.SelectNodes("/Schedule/Shows/Show/Images/EventSmallImagePortrait");
            foreach (XmlNode node in nodes)
            {
                    photos.Add(node.InnerText);
            }
            Repeater1.DataSource = photos;
            Repeater1.DataBind();
            errMsg.Text = "";
        }
        catch (Exception ex)
        {
            errMsg.Text = ex.Message;
        }
    }
}