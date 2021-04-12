using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmStandardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();

        }

        protected void BtnServer_Click(object sender, EventArgs e)
        {
            //lblDateTime.Text = DateTime.Now.ToString();
            var result = $@"유저아이디 : {TxtUserID.Text}
                            패스워드 : {TxtUserPassword.Text}
                            이름 : {TxtUserName}";
            
            Response.Write(result);
        }
    }
}