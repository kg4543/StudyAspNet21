using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = string.Empty;
            string strName = "";
            string strAge = "";

            //Request로 사용자의 입력값을 받아옴
            //strUserId = Request.QueryString["TxtUserID"]; //Get형식 가져올 때
            strUserId = Request["TxtUserId"];
            strPassword = Request.Params["TxtPassword"]; 
            strName = Request.Form["TxtName"]; //POST형식값만 받아옴; 주소창에 입력한 값은 받지 않음
            strAge = Request["TxtAge"]; // 추천형식

            var result = $@"입력하신 아이디는 {strUserId}이고 <br />
                            암호는 {strPassword}입니다.<br /> 이름은 {strName}이고, <br />
                            나이는 {strAge}입니다.<br />";

            LblResult.Text = result;
            LblIpAddress.Text = Request.UserHostAddress;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}