<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava6View.aspx.cs" Inherits="Tehtava6View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:XmlDataSource ID="srcRecords" runat="server" DataFile="~/App_Data/levykauppa.xml"></asp:XmlDataSource>
    <asp:XmlDataSource ID="srcSubRecords" runat="server" DataFile="~/App_Data/levykauppa.xml"></asp:XmlDataSource>
    <div>
        <asp:DataList ID="dlRecords" runat="server" DataSourceID="srcRecords">
            <ItemTemplate>
                <table>
                  <tr>
                        <td>
                            <img alt="kuva puuttuu" src="Images/<%# Eval("ISBN") %>.jpg" />
                        </td>
                </tr>
                    <tr>
                        <td>
                           <p><b class="headB"><%# Eval("ISBN") %> : <%# Eval("Title") %></b> </p> 
                            <br />
                            <br />
                            <b class="B">Hinta: </b> <%# Eval("Price") %>     
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <p class="B">Kappaleet:</p>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="srcSubRecords">
            <ItemTemplate>
                <table>
                  <tr>
                        <td>
                            <%# Eval("name") %>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <a href="Tehtava6.aspx">Takaisin</a>
    </div>
    </form>
</body>
</html>
