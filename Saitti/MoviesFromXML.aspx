<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MoviesFromXML.aspx.cs" Inherits="MoviesFromXML" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>XML Movies</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <!-- XMLDatasource määrittely -->
    <asp:XmlDataSource ID="srcMovies" runat="server" DataFile="~/App_Data/Movies.xml" XPath="//Movie"></asp:XmlDataSource>
    <!-- Näytetään data GV-kontrollissa-->
    <div>
        <h2 class="w3-container w3-indigo">Elokuvat XML-tiedosta</h2>
        <asp:GridView ID="gvMovies" DataSourceID="srcMovies" runat="server"></asp:GridView>
    </div>
    <!-- Näytetään Movie-data HTML:ssä repeater-controllilla -->
    <h2 class="w3-container w3-indigo">Elokuvat HTML-taulussa</h2>
    <asp:Repeater ID="Repeater1" DataSourceID="srcMovies" runat="server">
        <HeaderTemplate>
            <table border="1" style="width:50%">
                <tr>
                    <td>
                        Nimi
                    </td>
                    <td>
                        Ohjaaja
                    </td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <%# Eval("Name") %>
                </td>
                <td>
                    <%# Eval("Director") %>
                </td>
            </tr>
           <!-- <p><%# Eval("Name") %> by <%# Eval("Director") %></p>-->
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

