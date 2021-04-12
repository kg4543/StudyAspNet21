<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRichControl.aspx.cs" Inherits="FirstWebApp.FrmRichControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar runat="server" ID="CalMain" BackColor="#ffccff" BorderColor="#ff6666"
                BorderWidth="1" DayNameFormat="Shortest" OnSelectionChanged="CalMain_SelectionChanged">
                <DayHeaderStyle BackColor="Honeydew" Font-Bold="true" Height="10" />
            </asp:Calendar>
        </div>
    </form>
</body>
</html>
