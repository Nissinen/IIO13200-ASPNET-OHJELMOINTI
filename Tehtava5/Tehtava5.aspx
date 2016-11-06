<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava5.aspx.cs" Inherits="Tehtava5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="srcAsiakas" runat="server" ConnectionString="<%$ ConnectionStrings:DemoxOyConnectionString %>" SelectCommand="SELECT * FROM [asiakas]"></asp:SqlDataSource>
        <asp:Button ID="btnHaeKaikki" runat="server" Text="HaeKaikkiAsiakkaat" OnClick="btnHaeKaikki_Click" />
        <asp:DropDownList ID="ddlCountries" runat="server"></asp:DropDownList>
        <asp:GridView ID="gvAsiakkaat" runat="server">
        </asp:GridView>
        <asp:Label ID="lblMessages" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
