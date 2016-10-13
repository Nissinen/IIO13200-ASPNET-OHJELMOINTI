using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class RSSFeed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetFeeds_Click(object sender, EventArgs e)
    {
        //asetetaan XmlDataSource poittaamaan Iltasanomien rss feediin
        xdsFeedit.DataFile = @"http://www.iltasanomat.fi/rss/tuoreimmat.xml";
        xdsFeedit.XPath = @"rss/channel/item";
        GetFeeds();
    }
    protected void GetFeeds()
    {
        try
        {
            //hakee xml:n XMlDocument-olioon
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc = xdsFeedit.GetXmlDocument();
            //rssfeedin title ja julkaisu aika
            XmlNode node1 = xmlDoc.SelectSingleNode("/rss/channel");
            string otsikko = node1["title"].InnerText;
            string jaika = node1["pubDate"].InnerText;

            XmlNodeList nodes = xmlDoc.SelectNodes("/rss/channel/item");

            foreach (XmlNode item in nodes)
            {

            }

            messages.Text = string.Format("<h1> {0} {1} </h1>", otsikko, jaika);
        }
        catch (Exception ex)
        {
            messages.Text = ex.Message;
        }
    }
}