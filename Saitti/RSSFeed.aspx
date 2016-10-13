<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RSSFeed.aspx.cs" Inherits="RSSFeed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGetFeeds" runat="server" Text="Hae Iltasanomat" OnClick="btnGetFeeds_Click" />
    <asp:Button ID="btnGetFeedsYle" runat="server" Text="Hae yle uutiset" OnClick="btnGetFeedsYle_Click" />
    <asp:XmlDataSource ID="xdsFeedit" XPath="rss/channel/item" runat="server"></asp:XmlDataSource>
    <asp:Literal ID="messages" runat="server"></asp:Literal>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

