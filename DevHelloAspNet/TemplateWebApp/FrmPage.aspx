<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPage.aspx.cs" Inherits="TemplateWebApp.FrmPage" %>

<%@ Register Src="~/Navigator.ascx" TagPrefix="nav" TagName="Navigator" %>
<%@ Register Src="~/Copyright.ascx" TagPrefix="cpy" TagName="Copyright" %>
<%@ Register Src="~/Category.ascx" TagPrefix="cat" TagName="Category" %>
<%@ Register Src="~/Catalog.ascx" TagPrefix="ctl" TagName="Catalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>웹페이지뼈대</title>
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.css"  />
    <style>
        div {
        
        }
    </style>
 </head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12" style="background-color: deeppink">
                    <nav:Navigator runat="server" ID="UcNavigator" />
                </div>
            </div>
            <div class="row" style="height: 200px;">
                <div class="col-md-4" style="background-color: hotpink">
                    <cat:Category runat="server" />
                </div>
                <div class="col-md-8" style="background-color: pink">
                    <ctl:Catalog runat="server" />
                </div>
            </div>
                <div class="row">
                    <div class="col-md-12" style="background-color: lightpink">
                        <cpy:Copyright runat="server" />
                    </div>
                </div>
        </div>
    </form>
</body>
</html>
