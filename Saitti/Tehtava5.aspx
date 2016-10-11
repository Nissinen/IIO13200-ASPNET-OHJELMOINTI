<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava5.aspx.cs" Inherits="Tehtava5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="Button1" Text="hae Junat" runat="server" OnClick="btnGetTrains_Click" />
    <asp:DropDownList ID="lbValinta" runat="server"></asp:DropDownList>
    <h2>Tulokset</h2>
    <asp:GridView ID="gvJunat" runat="server"></asp:GridView>
    <asp:Literal ID="ltResult" Text="..." runat="server"></asp:Literal>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

