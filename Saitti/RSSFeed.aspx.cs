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
        GetFeeds();
    }
    protected void btnGetFeedsYle_Click(object sender, EventArgs e)
    {
        xdsFeedit.DataFile = @"http://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss";
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
           // string jaika = node1["pubDate"].InnerText;

            XmlNodeList nodes = xmlDoc.SelectNodes("/rss/channel/item");
            string rsscategory = "";
            string rsstitle = "";
            string rsslink = "";
            HyperLink hl = new HyperLink();

            messages.Text = string.Format("<h1> {0} </h1>", otsikko);

            foreach (XmlNode item in nodes)
            {
                rsscategory = item["category"].InnerText;
                rsstitle = item["title"].InnerText;
                rsslink = item["link"].InnerText;
                hl.Text = rsstitle;
                hl.NavigateUrl = rsslink;
                messages.Text += string.Format("{2}: <a href='{0}'>{1}</a><br>", rsslink, rsstitle,rsscategory);
            }
        }
        catch (Exception ex)
        {
            messages.Text = ex.Message;
        }
    }
}