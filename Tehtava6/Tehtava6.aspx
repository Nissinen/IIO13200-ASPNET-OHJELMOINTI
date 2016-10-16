<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava6.aspx.cs" Inherits="Tehtava6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/style.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:XmlDataSource ID="srcRecords" runat="server" DataFile="~/App_Data/levykauppa.xml" XPath="//record"></asp:XmlDataSource>
    
    <div>
        <h2 class="w3-container w3-indigo">Albumit XML-tiedosta</h2>

        <asp:DataList ID="dlRecords" runat="server" DataSourceID="srcRecords">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                            <img alt="kuva puuttuu" src="Images/<%# Eval("ISBN") %>.jpg" />
                        </td>
                        <td>
                           <p><b class="headB"><%# Eval("ISBN") %> : <%# Eval("Title") %></b> </p> 
                            <br />
                            <b class="B">ISBN: </b><asp:LinkButton Text=<%# Eval("ISBN") %> runat="server" CommandArgument=<%# Eval("ISBN") %> OnCommand="LinkButton_Command"></asp:LinkButton>
                            <br />
                            <b class="B">Hinta: </b> <%# Eval("Price") %>
                            
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>

    </form>
</body>
</html>
