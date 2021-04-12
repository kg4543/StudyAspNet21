<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FirstWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hellow ASP.NET!</h1>

        </div>
        <input id="TxtOther" name="TxtOther" type="text" runat="server" /> <br />

        <asp:TextBox ID="TxtDisplay" runat="server"></asp:TextBox>
        <asp:Button ID="BtnClick" runat="server" Text="클릭" OnClick="BtnClick_Click" /> <br/>
        <asp:Label ID="LblResult" runat="server"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
