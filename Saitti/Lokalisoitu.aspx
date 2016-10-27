<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Lokalisoitu.aspx.cs" Inherits="Lokalisoitu" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>Lokalisointi testi (staattinen)</h1>
    <h2><asp:Label runat="server" Text="<%$ Resources:Tervehdys %>" /></h2>
    <asp:Image runat="server" ImageUrl="<%$ Resources:Lippu %>" Width="100" />
    <br />
    <br />
    <asp:Button runat="server" ID="btnHello" Text="Button" meta:resourcekey="btnHello" OnClick="btnHello_Click" />
    <br />
    <br />
    <asp:Label ID="lblMessage" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

