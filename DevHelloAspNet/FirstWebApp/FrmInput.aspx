<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmInput.aspx.cs" Inherits="FirstWebApp.FrmInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>유효성검사</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtUserId" runat="server" />
            <asp:RequiredFieldValidator ID="ValUserId" runat="server" ControlToValidate="TxtUserId"
                ErrorMessage="아이디를 입력하세요" Display="Static" />(필수) <br />
            <asp:TextBox ID="TexPassword" runat="server" />
            <asp:RequiredFieldValidator ID="ValPassword" runat="server" ControlToValidate="TxtPassword"
                ErrorMessage="패스워드를 입력하세요" Display="Dynamic" />(필수) <br />

            <asp:Button ID="BtnLogin" Text="Login" runat="server" Onclick="BtnLogin_Click"/>
        </div>
    </form>
</body>
</html>
