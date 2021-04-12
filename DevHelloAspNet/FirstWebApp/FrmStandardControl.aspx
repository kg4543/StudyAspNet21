<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStandardControl.aspx.cs" Inherits="FirstWebApp.FrmStandardControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>표준컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>표준컨트롤</h1>

            <asp:TextBox ID="TxtUserID" runat="server" TextMode="MultiLine"/>
            <asp:TextBox ID="TxtUserPassword" runat="server" TextMode="MultiLine"/>
            <asp:TextBox ID="TxtUserName" runat="server" TextMode="MultiLine"/><br />

            <asp:Label ID="lblDateTime" runat="server" Text="Sample" /><br />
            <input type="button" value="Input" id="BtnInput" />
            <input type="button" value="Relese" id="BtnHtml" runat="server" />
            <asp:Button Text="Login" runat="server" ID="BtnServer" OnClick="BtnServer_Click" /><br />

            <asp:TextBox ID="TxtSingleLine" runat="server" TextMode="MultiLine" height="150" Width="500" /><br />
        </div>
    </form>
</body>
</html>
