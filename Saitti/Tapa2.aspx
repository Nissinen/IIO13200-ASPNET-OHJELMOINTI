﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tapa2.aspx.cs" Inherits="Tapa2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kohde 2: Http Post - tapa</h1>
        <p>
             Kutsuvalta Sivulta luetaan viesti: <%=Request.Form["txtMessage"] %>
        </p>
    </div>
    </form>
</body>
</html>
