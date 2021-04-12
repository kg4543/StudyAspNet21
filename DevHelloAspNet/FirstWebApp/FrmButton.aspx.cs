using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                TxtNum.Text = "0";
            // 제일 처음만 로드할 때 초기화
        }

        protected void BtnInc_Click(object sender, EventArgs e)
        {
            TxtNum.Text = $"{(int.Parse(TxtNum.Text) + 1)}";
        }

        protected void BtnDec_Click(object sender, EventArgs e)
        {
            TxtNum.Text = $"{(int.Parse(TxtNum.Text) - 1)}";
        }

        protected void BtnLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.naver.com");
        }

        protected void BtnImage_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}