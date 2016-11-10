using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookShop : System.Web.UI.Page
{
    protected static BookShopEntities ctx;
    protected static bool KustiValittu;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //luodaan konteksti
            ctx = new BookShopEntities();
            FillControls();
        }
    }
    #region METHODS
    protected void GetBooks()
    {
        gvBooks.DataSource = ctx.Books.ToList();
        gvBooks.DataBind();
    }
    protected void GetCustomers()
    {
        gvCustomers.DataSource = ctx.Customers.ToList();
        gvCustomers.DataBind();
    }
    #endregion
    protected void btnGetBooks_Click(object sender, EventArgs e)
    {
        GetBooks();
    }
    protected void FillControls()
    {
        SetButton();
        //ui controllien alustaminen
        var result = from c in ctx.Customers orderby c.lastname select new { c.id, c.lastname };
        //määritellään dropdownlistille mitä se esittää
        ddlCustomers.SelectedIndex = -1;
        ddlCustomers.DataSource = result.ToList();
        ddlCustomers.DataTextField = "lastname";
        ddlCustomers.DataValueField = "id";
        ddlCustomers.DataBind();
        ddlCustomers.Items.Insert(0, string.Empty);
        //11.10
        txtEtunimi.Text = string.Empty;
        txtSukunimi.Text = string.Empty;

    }

    protected void btnGetCustomers_Click(object sender, EventArgs e)
    {
        GetCustomers();
    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlCustomers.SelectedIndex > 0)
        {
            KustiValittu = true;
            SetButton();
            //tyhjäään tilaukset
            ddlOrders.Items.Clear();

            int cid = -1;
            cid = Int32.Parse(ddlCustomers.SelectedValue);
            // haetaan valittu asiakas
            var ret = from c in ctx.Customers where c.id == cid select c;

            var asiakas = ret.FirstOrDefault();
            if(asiakas != null)
            {
                lblMessages.Text = string.Format("Valitsit asiakkaan {0}", asiakas.lastname);
                //jatko 11.10
                txtEtunimi.Text = asiakas.firstname;
                txtSukunimi.Text = asiakas.lastname;
                KustiValittu = true;
                //tutkitaan onko valitulla asiakkaalla tilauksia ja jos on näytetään
                if(asiakas.Orders.Count > 0)
                {
                    lblMessages.Text += string.Format(", tilauksia {0}", asiakas.Orders.Count);
                    //täytetään ddl tilauksilla
                    var ret2 = (from o in asiakas.Orders select new { o.odate }).ToList();
                    ddlOrders.DataSource = ret2;
                    ddlOrders.DataTextField = "odate";
                    ddlOrders.DataBind();
                    //haetaan ja näytetään tilausten tilausrivit
                    foreach (var item in asiakas.Orders)
                    {
                        lblMessages.Text += string.Format("<br> tilaus: {0}", item.odate.ToShortDateString());
                        //loopitetaan tilausen tilausrivit
                        foreach (var or in item.Orderitems)
                        {
                            lblMessages.Text += string.Format("<br> tilattu kirja: {0}", or.Book.name);
                        }
                    }
                   
                }
                else
                {
                    lblMessages.Text += " , ei ole tilauksia.";
                }
            }
        }
        else
        {
            lblMessages.Text = string.Empty;
            KustiValittu = false;
            txtEtunimi.Text = string.Empty;
            txtSukunimi.Text = string.Empty;
            SetButton();
        }
    }

    protected void SetButton()
    {
        btnLuoUusiAsiakas.Enabled = !KustiValittu;
        btnTallenna.Enabled = KustiValittu;
        btnPoista.Enabled = KustiValittu;
    }

    protected void btnLuoUusiAsiakas_Click(object sender, EventArgs e)
    {
        //Tarkistetaan ensin onko ko. asiakasta jo olemassa LINQ lambda-funktiolla
        bool isThere = ctx.Customers.Any(c => (c.firstname.Contains(txtEtunimi.Text) & c.lastname.Contains(txtSukunimi.Text)));
        if (isThere)
        {
            lblMessages.Text = string.Format("Asiakas {0} on jo olemassa", txtSukunimi.Text);
        }
        else
        {
            //luodaan kontekstiin uusi asiakas entiteetti
            Customer cus = new Customer();
            cus.firstname = txtEtunimi.Text;
            cus.lastname = txtSukunimi.Text;
            ctx.Customers.Add(cus);
            ctx.SaveChanges();
            lblMessages.Text = string.Format("uusi asiakas {0} {1} {2} luotu onnistuneesti", cus.id, cus.firstname, cus.lastname);
            //päivitetään controllit
            FillControls();
        }
    }

    protected void btnTallenna_Click(object sender, EventArgs e)
    {
        //haetaan valitun asiakkaan id
        int i = int.Parse(ddlCustomers.SelectedValue);
        if (i > 0)
        {
            var ret = ctx.Customers.Where(c => c.id == i);
            Customer cus = ret.FirstOrDefault();
            if(cus != null)
            {
                if(cus.firstname != txtEtunimi.Text)
                {
                    cus.firstname = txtEtunimi.Text;
                }
                if (cus.lastname != txtSukunimi.Text)
                {
                    cus.lastname = txtSukunimi.Text;
                }
                ctx.SaveChanges();
                FillControls();
            }
        }
    }

    protected void btnPoista_Click(object sender, EventArgs e)
    {
        //Poistetaan valittu asiakas
        if (KustiValittu)
        {
            //huomioi myös business logiikka eli onko oikeasti järkevää vai tulisiko flägätä
            //tässä tapauksessa saa poistaa vian sellaisia asiakkaita joilla ei ole tilauksia.
            int i = int.Parse(ddlCustomers.SelectedValue);
            var ret = ctx.Customers.Where(c => c.id == i);
            Customer cus = ret.FirstOrDefault();
            if (i > 0) { 
                // tutkitaan onko kustilla tialuksia, jos on ei poisteta
                if(cus.Orders.Count == 0)
                {
                    ctx.Customers.Remove(cus);
                    ctx.SaveChanges();

                    KustiValittu = false;
                    FillControls();
                }
                else
                {
                    lblMessages.Text = string.Format("Asiakasta {0} ei voi poistaa, kosaka hänellä on {1} tilausta", cus.lastname, cus.Orders.Count);
                }
            }
        }
    }
}