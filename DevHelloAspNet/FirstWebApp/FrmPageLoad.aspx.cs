using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace FirstWebApp
{
    public partial class FrmPageLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "제목";
            Page.Title = "새 제목";

            HtmlLink cssLink = new HtmlLink();
            cssLink.Href = "Content/main.css";
            cssLink.Attributes.Add("rel", "stylesheet");
            cssLink.Attributes.Add("type", "text/css");

            HtmlHead htmlHead = Page.Header;
            htmlHead.Controls.Add(cssLink);

            //제일 중요
            if (!Page.IsPostBack)
            {
                Response.Write("[1] 폼이 최초로드되었습니다. <br />");
            }
            else
            {
                Response.Write("[2] 폼이 다시로드되었습니다. <br />");
            }

            Response.Write("[3] 항상 실행 <br />");
        }

        protected void BtnPostBack_Click(object sender, EventArgs e)
        {
            var strScript = @"<script> window.alert('PostBack!'); </script>";
            //Response.Write(strScript);
            ClientScript.RegisterClientScriptBlock(this.GetType(), "PostScript", strScript);
        }

        protected void BtnNewLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmPageLoad.aspx");
        }
    }
}