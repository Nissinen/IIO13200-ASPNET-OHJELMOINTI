<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookShop.aspx.cs" Inherits="BookShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div style="w3-row-padding">
        <div class="w3-half">
            <asp:Button ID="btnGetBooks" runat="server" Text="Hae kirjat" OnClick="btnGetBooks_Click" />
            <asp:Button ID="btnGetCustomers" runat="server" Text="Hae asiakkaat" OnClick="btnGetCustomers_Click" />
            <h1 style="w3-container">KirjakaupanX kirjat</h1>
            <asp:GridView ID="gvBooks" runat="server"></asp:GridView>
            <h1 style="w3-container">KirjakaupanX asiakkaat</h1>
            <asp:GridView ID="gvCustomers" runat="server"></asp:GridView>
            
            <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
            <br />
            <asp:DropDownList ID="ddlOrders" runat="server" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="w3-half w3-light-blue">
            <h1>Uuden luonti ja muokkaus</h1>  
            <asp:DropDownList ID="ddlCustomers" runat="server" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="etunimi:"></asp:Label>
            <asp:TextBox ID="txtEtunimi" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="sukunimi:"></asp:Label>
            <asp:TextBox ID="txtSukunimi" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLuoUusiAsiakas" runat="server" Text="Luo uusi asiakas" OnClick="btnLuoUusiAsiakas_Click" />
            <asp:Button ID="btnTallenna" runat="server" Text="Tallenna" OnClick="btnTallenna_Click" />
            <asp:Button ID="btnPoista" runat="server" Text="Poista" OnClick="btnPoista_Click" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

