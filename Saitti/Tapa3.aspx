<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tapa3.aspx.cs" Inherits="Tapa3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kohde 3: Session State - tapa</h1>
        <p>
             Sessiosta luetaan viesti: <%=Session["viesti"] %>
        </p>
    </div>
    </form>
</body>
</html>
