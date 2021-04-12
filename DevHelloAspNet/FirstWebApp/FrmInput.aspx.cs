using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmInput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.SetFocus(TxtUserId);
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Response.Write("<script>alert('통과!');</script>");
            }
        }
    }
}