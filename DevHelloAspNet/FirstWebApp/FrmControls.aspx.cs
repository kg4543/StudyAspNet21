using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CboPhoneNum.Items.Add("051");

            LsbHobby.Items.Add("배구");

            if (!Page.IsPostBack)
            {
                CtlHidden.Value = DateTime.Now.ToShortTimeString();
            }
        }

        protected void BtnChane_Click(object sender, EventArgs e)
        {
            if (ImgChange.ImageUrl == "~/Images/ASP-NET-Banners1.png")
            {
                ImgChange.ImageUrl = "~/Images/ASP-NET-Banners2.png";
            }
            else
            {
                ImgChange.ImageUrl = "~/Images/ASP-NET-Banners1.png";
            }
        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            Response.Write(CtlHidden);
        }
    }
}