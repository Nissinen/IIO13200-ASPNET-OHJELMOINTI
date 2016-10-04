<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava4.aspx.cs" Inherits="Tehtava4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:sqldatasource ID="srcAsiakkaat" runat="server" ConnectionString="<%$ ConnectionStrings:DemoxOyConnectionString %>"
         SelectCommand="SELECT [astunnus], [asnimi], [yhteyshlo], [postitmp] FROM [asiakas]">
    </asp:sqldatasource>
    <div>
        <h1>SQL:llä</h1>
        <asp:gridview ID="gvMovies" DataSourceID="srcAsiakkaat" runat="server"></asp:gridview>
        <h1>DBDemoxOy:llä</h1>
        <asp:gridview ID="gvMovies2" runat="server"></asp:gridview>
    </div>
</asp:Content>

