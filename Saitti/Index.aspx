﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" MasterPageFile="~/MasterPage.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>IIO13200 .NET Ohjelmointi</title>
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
        <div>
            <h1>IIO13200. NET Ohjelmointi</h1>
            <h2>1.kontaktikerta</h2>
            <p>Super siisti webbisivu</p>
            <h3>Perus HTML kontrolleja</h3>
            <a href="Testi.html">Testi html-sivu</a>
            <asp:LinkButton ID="LinkeButton1" runat="server" PostBackUrl="~/Hello.aspx">LinkButton</asp:LinkButton>
            <p>
                Esimerkki ASP.NET DataKontrollista
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowPhotos.aspx">Show Photos</asp:HyperLink>
            </p>
            <p>
                Esimerkki kuinka koodissa rakennetaan HTML:ää
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ShowCustomers.aspx">Show WineCustomers</asp:HyperLink>
            </p>
            <h3>Tiedon välitys sivulta toiselle:</h3>
            <p>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Source.aspx">Tiedon välitys 6 tapaa</asp:HyperLink>
            </p>
            <h2> Mustang demo</h2>
            <a href="FordMustang.aspx">Ford Mustang sivulle</a>
            <a href="MoviesFromXML.aspx">Movies from xml</a>
        </div>
</asp:Content>

