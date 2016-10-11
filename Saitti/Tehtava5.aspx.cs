using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAMK.IT;
using Newtonsoft.Json;
using System.Data;

public partial class Tehtava5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            getStations();
        }
    }
    protected string GetStationsFromVR()
    {

        string url = "http://rata.digitraffic.fi/api/v1/metadata/stations";
        using (WebClient wc = new WebClient())
        {
            var json = wc.DownloadString(url);
            return json;
        }
    }
    protected string GetJsonFromVR(string city) { 
    
        string url = "http://rata.digitraffic.fi/api/v1/live-trains?station=" + city;
        using (WebClient wc = new WebClient())
        {
            var json = wc.DownloadString(url);
            return json;
        }
    }
    protected List<Station> ConvertJsonToStations(string json)
    {
        List<Station> asemat = JsonConvert.DeserializeObject<List<Station>>(json);
        return asemat;
    }
    protected List<Train> ConvertJsonToTrains(string json)
    {
        List<Train> junat = JsonConvert.DeserializeObject<List<Train>>(json);
        return junat;
    }

    protected void btnGetTrains_Click(object sender, EventArgs e)
    {
        string data = GetJsonFromVR(lbValinta.SelectedValue.ToString());
        List<Train> junat = ConvertJsonToTrains(data);
        DataTable test = new DataTable();
        test.Columns.Add("Train Number");
        test.Columns.Add("Cancelled");
        test.Columns.Add("Date");
        test.Columns.Add("Train type");
        foreach (var item in junat)
        {
            test.Rows.Add(item.trainNumber, item.cancelled , item.departureDate, item.trainType);
        }

        gvJunat.DataSource = test;
        gvJunat.DataBind();

    }
    protected void getStations()
    {
        string data = GetStationsFromVR();
        List<Station> asemat = ConvertJsonToStations(data);
        foreach (var asema in asemat)
        {
            lbValinta.Items.Add(new ListItem(asema.stationName, asema.stationShortCode));
        }
    }
}