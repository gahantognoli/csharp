﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LinqWhere.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Height="173px" Width="539px">
            </asp:GridView>
        </div>
        <asp:Button ID="btnConsulta" runat="server" OnClick="btnConsulta_Click" Text="Consulta" />
    </form>
</body>
</html>
