using NetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetNote.Board
{
    public partial class BoardWrite : System.Web.UI.Page
    {
        public BoardWriteFormType FormType { get; set; } = BoardWriteFormType.Write; //기본값(글 쓰기)

        private string _Id; // 리스트에서 넘겨주는 번호
        protected void Page_Load(object sender, EventArgs e)
        {
            _Id = Request["Id"]; // Get / Post

            if (!Page.IsPostBack)
            {
                switch (FormType)
                {
                    case BoardWriteFormType.Write:
                        LblTitleDescription.Text = "글 쓰기 - 다음 필드들을 입력하세요";
                            break;
                    case BoardWriteFormType.Modify:
                        LblTitleDescription.Text = "글 수정 - 다음 필드들을 수정하세요";
                        DisplayDataForModify();
                        break;
                    case BoardWriteFormType.Reply:
                        LblTitleDescription.Text = "글 답변 - 다음 필드들을 입력하세요";
                        DisplayDataForReply();
                        break;
                }
            }
        }

        private void DisplayDataForReply()
        {
            throw new NotImplementedException();
        }

        private void DisplayDataForModify()
        {
            throw new NotImplementedException();
        }

        protected void chkUpload_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            if (ImageTextCorrect())
            {
                Note note = new Note();
                note.Id = Convert.ToInt32(_Id); //값이 안나면 0
                note.Name = txtName.Text;
                note.Email = txtEmail.Text;
                note.Homepage = txtHomepage.Text;
                note.Title = txtTitle.Text;
                note.Content = txtContent.Text;
                note.FileName = "";
                note.FileSize = 0;
                note.Password = txtPassword.Text;
                note.PostIp = Request.UserHostAddress;
                note.Encoding = rdoEncoding.SelectedValue;

                DbRepository repo = new DbRepository();

                switch (FormType)
                {
                    case BoardWriteFormType.Write:
                        repo.Add(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                    case BoardWriteFormType.Modify:
                        break;
                    case BoardWriteFormType.Reply:
                        break;
                }
            }
        }

        private bool ImageTextCorrect()
        {
            if (Page.User.Identity.IsAuthenticated) // 이미 로그인
            {
                return true;
            }
            else
            {
                if (Session["ImageText"] != null)
                {
                    return (txtImageText.Text == Session["ImageText"].ToString());
                }
            }
            return false;
        }
    }
}