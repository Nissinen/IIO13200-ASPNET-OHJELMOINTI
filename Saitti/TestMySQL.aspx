<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TestMySQL.aspx.cs" Inherits="TestMySQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:SqlDataSource ID="srcMysli" runat="server" ProviderName="MySql.Data.MySqlClient" ConnectionString="<%$ ConnectionStrings:Mysli %>" SelectCommand="SELECT * FROM Pelaaja" 
        DeleteCommand="DELETE FROM Pelaaja WHERE PelaajaID=@PelaajaID"
        UpdateCommand="UPDATE Pelaaja SET Nimi=@Nimi, Seura=@Seura, Pelipaikka=@Pelipaikka, Nro=@Nro, Maalit=@Maalit, Syotot=@Syotot WHERE (PelaajaID=@PelaajaID)">
    </asp:SqlDataSource>
    <h2>Pelaajat liigassa</h2>
    <asp:GridView ID="gvPlayers" runat="server" DataSourceID="srcMysli">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

