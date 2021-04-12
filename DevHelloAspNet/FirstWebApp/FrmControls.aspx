<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmControls.aspx.cs" Inherits="FirstWebApp.FrmControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>대체컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="CtlHidden" runat="server" />
            <asp:Button ID="BtnOK" runat="server" Text="히든필드값 출력" OnClick="BtnOK_Click" /><br />
            <asp:HyperLink ID="LnkMicrosoft" NavigateUrl="https://www.microsoft.com" Text="마이크로소프트" runat="server"/><br />
            <asp:Image ID="ImgChange" runat="server" ImageUrl="~/Images/ASP-NET-Banners1.png" /> <br />
            <asp:Button ID="BtnChane" Text="Change" runat="server" OnClick="BtnChane_Click" /> <br />
            <table style="border: 1px solid black;">
                <thead>
                    <tr>
                        <td>쿠키</td>
                        <td>민트초코</td>
                        <td>마카롱</td>
                    </tr>
                </thead>
                    <tr>
                        <td>12개</td>
                        <td>5개</td>
                        <td>7개</td>
                    </tr>
            </table> <br />
            <asp:DropDownList ID="CboPhoneNum" runat="server">
                <asp:ListItem Text="010" />
                <asp:ListItem>019</asp:ListItem>
                <asp:ListItem Value="018" />
                <asp:ListItem Value="070">070</asp:ListItem>
            </asp:DropDownList>
            <asp:ListBox ID="LsbHobby" runat="server" SelectionMode="Multiple">
                <asp:ListItem>축구</asp:ListItem>
                <asp:ListItem Text="농구" />
            </asp:ListBox>
        </div>
    </form>
</body>
</html>
