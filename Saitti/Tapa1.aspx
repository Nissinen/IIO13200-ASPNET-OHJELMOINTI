<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tapa1.aspx.cs" Inherits="Tapa1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tapa1: Quesry String</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kohde 1: Query String - tapa</h1>
        <p>
            Sivulle lähetettiin parametrinä viesti: <%=Request.QueryString["Data"] %>
        </p>
    </div>
    </form>
</body>
</html>
