<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Oppilaat.aspx.cs" Inherits="Oppilaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Oppilaat:</h2>
        <div>
            <asp:Button ID="btnGet3" Text="Hae 3 Oppilasta" runat="server" OnClick="btnHae3_Click" />
            <asp:Button ID="btnGetAll" Text="Hae Kaikki Oppilaat" runat="server" OnClick="btnHaeKaikki_Click" />
            <asp:Button ID="btnGetFromMysli" Text="Hae MySQL tietokannasta" runat="server" OnClick="btnGetFromMysli_Click" />
        </div>
        <div id="tulos">
            <asp:GridView ID="gvStudents" runat="server"></asp:GridView>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
