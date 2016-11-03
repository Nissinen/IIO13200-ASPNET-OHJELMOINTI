<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookShop.aspx.cs" Inherits="BookShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGetBooks" runat="server" Text="Hae kirjat" OnClick="btnGetBooks_Click" />
    <asp:Button ID="btnGetCustomers" runat="server" Text="Hae asiakkaat" OnClick="btnGetCustomers_Click" />
    <h1 style="w3-container">KirjakaupanX kirjat</h1>
    <asp:GridView ID="gvBooks" runat="server"></asp:GridView>
    <h1 style="w3-container">KirjakaupanX asiakkaat</h1>
    <asp:GridView ID="gvCustomers" runat="server"></asp:GridView>
    <asp:DropDownList ID="ddlCustomers" runat="server" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    <br />
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
    <br />
    <asp:DropDownList ID="ddlOrders" runat="server" AutoPostBack="true"></asp:DropDownList>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

