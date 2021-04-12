using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Expires = -1;
            Response.Buffer = true;
            Response.Write("[1] 현재 글이 보여짐");
            Response.Flush(); //버퍼내용 출력
            Response.Write("[3] 현재 글은");
            Response.Clear(); //버퍼내용 지움
            Response.End();
            Response.Write("[5] 출력이 안됨");
        }

        protected void BtnClick_Click(object sender, EventArgs e)
        {
            LblResult.Text = $"안녕하세요...{TxtDisplay.Text}!";
            Response.Write("반갑습니다.<br />");
        }
    }
}