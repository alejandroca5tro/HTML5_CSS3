﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ejercicio9._2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList ID="CheckBoxList1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem Text="Temporada Alta" Value="0">Temporada Alta</asp:ListItem>
            <asp:ListItem Text="Temporada Media" Value="1">Temporada Media</asp:ListItem>
            <asp:ListItem Text="Temporada Baja" Value="2">Temporada Baja</asp:ListItem>

        </asp:CheckBoxList>

    
    </div>
    </form>
</body>
</html>