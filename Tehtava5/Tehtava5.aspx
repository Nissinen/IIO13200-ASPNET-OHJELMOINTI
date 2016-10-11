<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava5.aspx.cs" Inherits="Tehtava5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" Text="Hae Json teksti" ID="btnGetJson" OnClick="btnGetJson_Click" />
        <asp:Button ID="btnGetPerson" Text="Hae Json ja muuta olioksi" runat="server" OnClick="btnGetPerson_Click" />
        <asp:Button ID="btnGetPolitics" Text="hae hallistus" runat="server" OnClick="btnGetPolitics_Click" />
        <h2>Tulokset</h2>
        <asp:Literal ID="ltResult" Text="..." runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
