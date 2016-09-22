<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tiedonvälitys demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Source - sivu</h1>
            <p>
                Lähetettävä viesti: <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
                <!-- tässä valmis lista josta voi valitaan sopivan lauseen  -->
                <asp:DropDownList runat="server" ID="ddlMessages" AutoPostBack="true" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged" ></asp:DropDownList>
                <br />
                <!-- tapa1: Query string-->
                <asp:Button runat="server" ID="btnQueryString" Text="Use Query String" OnClick="btnQueryString_Click" />
                <br />
                <!-- tapa2: Http POST-->
                <asp:Button runat="server" ID="btnHttpPost" Text="Use Http Post" PostBackUrl="~/Tapa2.aspx" />
                 <br />
                <!-- tapa3: Session-->
                <asp:Button runat="server" ID="btnSessionState" Text="Use Session State" OnClick="btnSessionState_Click" />
                <br />
                <!-- tapa4: Cookie-->
                <asp:Button runat="server" ID="btnCookie" Text="Use Cookie" OnClick="btnCookie_Click" PostBackUrl="~/Tapa4.aspx" />
                <br />
                <!-- tapa5: Public property-->
                <asp:Button runat="server" ID="btnProperty" Text="Use Property" OnClick="btnProperty_Click" />
            </p>
        </div>
    </form>
</body>
</html>
