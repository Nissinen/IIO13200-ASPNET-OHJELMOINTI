﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MoviesFromSQL.aspx.cs" Inherits="MoviesFromSQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Elokuvat SQL</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <!-- DataSource SQLServer -->
    <asp:SqlDataSource ID="srcMovies" runat="server"
         ConnectionString="<%$ ConnectionStrings:Muuvit %>"
         SelectCommand="SELECT [title], [director], [year], [url] FROM [Movies]">
    </asp:SqlDataSource>
    <!-- GV esittää datan -->
    <div>
        <h2 class="w3-container w3-indigo">Elokuvat SQL-Serveriltä</h2>
        <asp:GridView ID="gvMovies" DataSourceID="srcMovies" runat="server"></asp:GridView>
    </div>
    <!-- Data HTML:ssä -->
    <h2 class="w3-container w3-indigo">Elokuvat HTML-taulussa</h2>
    <asp:Repeater ID="Repeater1" DataSourceID="srcMovies" runat="server">
        <ItemTemplate>
            <p><%# Eval("title") %> by <%# Eval("director") %></p>
            <img src="<%# Eval("url") %>" alt="kuva puuttuu" width="200" />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

