<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava8.aspx.cs" Inherits="Tehtava8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/style.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <div class="right">
            <asp:Repeater ID="Repeater1" runat="server" >
              <ItemTemplate>
                   <asp:Image ID="Image1" Width="150px" ImageUrl='<%# Container.DataItem  %>' runat="server" /> 
             </ItemTemplate>
             </asp:Repeater>
        </div>
        <div class="left">
            <asp:ListBox CssClass="lb" ID="lbTeatterit" runat="server" OnSelectedIndexChanged="lbTeatterit_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
            <asp:ListView ID="ListView1" runat="server"></asp:ListView>
            <br />
            <asp:Label ID="errMsg" runat="server"></asp:Label>
        </div>
        
    </div>
    </form>
</body>
</html>
