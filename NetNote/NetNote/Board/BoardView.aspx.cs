using NetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetNote.Board
{
    public partial class BoardView : System.Web.UI.Page
    {
        private string _Id; //게시글 번호
        protected void Page_Load(object sender, EventArgs e)
        {
            lnkDelete.NavigateUrl = $"BoardDelete.aspx?Id={Request["Id"]}";
            lnkDelete.NavigateUrl = $"BoardModify.aspx?Id={Request["Id"]}";
            lnkDelete.NavigateUrl = $"BoardReply.aspx?Id={Request["ID"]}";

            _Id = Request["Id"];
            if (_Id == null)
            {
                Response.Redirect("BoardList.aspx");
            }
            if (!Page.IsPostBack)
            {
                DisplayDate();
            }
        }

        private void DisplayDate()
        {
            var repo = new DbRepository();
            var note = repo.GetNoteById(Convert.ToInt32(_Id));

            lblNum.Text = _Id;
            lblName.Text = note.Name;
            lblEmail.Text = string.Format("<a href='mailto:{0}'>{0}</a>",note.Email);
            lblTitle.Text = note.Title;

            string content = note.Content;

            // 인코딩 방식 : Text, Html, Mixed
            string encoding = note.Encoding;
            if (encoding == "Text")
            {
                lblContent.Text = Helpers.HtmlUtility.EncodeWithTabAndSpace(content);
            }
            else if (encoding == "Mixed")
            {
                lblContent.Text = content.Replace("\r\n", "<br />");
            }
            else
            {
                lblContent.Text = content;
            }
            lblReadCount.Text = note.ReadCount.ToString();
            lblHomepage.Text = $"<a href='{note.Homepage}' target='_blank'>{note.Homepage}</a>";
            lblPostDate.Text = note.PostDate.ToString();
            lblPostIP.Text = note.PostIp;
        }
    }
}