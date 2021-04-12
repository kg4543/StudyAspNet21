<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRequest.aspx.cs" Inherits="FirstWebApp.FrmRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>리퀘스트 객체</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            아이디 : <asp:TextBox ID="TxtUserID" runat="server"></asp:TextBox><br />
            암호 : <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox><br />
            이름 : <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
            나이 : <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox><br />
            <asp:Button ID="BtnSubmit" Text="전송" runat="server" OnClick="BtnSubmit_Click" /><br />
            <asp:Label ID="LblResult" runat="server"></asp:Label><br />
            <asp:Label ID="LblIpAddress" runat="server"></asp:Label><br />
        </div>
    </form>
</body>
</html>
