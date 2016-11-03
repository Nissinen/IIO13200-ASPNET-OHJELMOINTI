<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NaytaPalaute.aspx.cs" Inherits="NaytaPalaute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
    <div>
        <h2 class="w3-container w3-indigo">Palautteet XML:stä</h2>
        <asp:GridView ID="gvPalautteet" runat="server"></asp:GridView>
        <br />
        <h2 class="w3-container w3-indigo">Palautteet MySQL:stä</h2>
        
            <asp:SqlDataSource ID="srcMysli" runat="server" ProviderName="MySql.Data.MySqlClient" ConnectionString="<%$ ConnectionStrings:Mysli %>" SelectCommand="SELECT * FROM palaute"></asp:SqlDataSource>
         <asp:GridView ID="gvMySQLPalautteet" runat="server" DataSourceID="srcMysli">
    </asp:GridView>
             
         <br />
        <a href="Palaute.aspx"> Takaisin antamaan palautetta </a>
    </div>
    </form>
</body>
</html>
