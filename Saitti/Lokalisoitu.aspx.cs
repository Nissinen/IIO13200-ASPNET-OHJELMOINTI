﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lokalisoitu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHello_Click(object sender, EventArgs e)
    {
        //haetaan resursseista kulttuurin mukainen tervehdys
        string msg;
        msg = GetLocalResourceObject("Tervehdys").ToString();
        lblMessage.Text = msg;
    }
}