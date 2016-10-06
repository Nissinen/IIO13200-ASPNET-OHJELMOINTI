<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TestJson.aspx.cs" Inherits="TestJson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button runat="server" Text="Hae Json teksti" ID="btnGetJson" OnClick="btnGetJson_Click" />
    <asp:Button ID="btnGetPerson" Text="Hae Json ja muuta olioksi" runat="server" OnClick="btnGetPerson_Click" />
    <asp:Button ID="btnGetPolitics" Text="hae hallistus" runat="server" OnClick="btnGetPolitics_Click" />
    <h2>Tulokset</h2>
    <asp:Literal ID="ltResult" Text="..." runat="server"></asp:Literal>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

