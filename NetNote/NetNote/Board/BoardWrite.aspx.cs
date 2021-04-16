using NetNote.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        private string _BaseDir = ""; // D:\GitRepository\StudyAspNet21\NetNote\NetNote\Files
        private string _FileName = ""; //파일명
        private int _FileSize = 0; //파일 사이즈


        protected void Page_Load(object sender, EventArgs e)
        {
            _Id = Request["Id"]; // Get / Post

            if (!Page.IsPostBack)
            {
               ViewState["Mode"] = Request["Mode"]; //ViewState 해당페이지에서 계속 값 유지

                if (ViewState["Mode"].ToString() == "Edit") FormType = BoardWriteFormType.Modify;
                else if (ViewState["Mode"].ToString() == "Reply") FormType = BoardWriteFormType.Reply;
                else FormType = BoardWriteFormType.Write;

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
            var repo = new DbRepository();
            Note note = repo.GetNoteById(Convert.ToInt32(_Id));

            txtTitle.Text = $"{note.Title} 답변";
            txtContent.Text = $"\n\n 작성일 : {note.PostDate}\n작성자 : '{note.Name}' \n---------------------------\n>" +
                              $"{note.Content.Replace("\n","\n>")}\n---------------------------\nReply\n";
        }

        private void DisplayDataForModify()
        {
            var repo = new DbRepository();
            Note note = repo.GetNoteById(Convert.ToInt32(_Id));

            txtName.Text = note.Name;
            txtEmail.Text = note.Email;
            txtHomepage.Text = note.Homepage;
            txtTitle.Text = note.Title;
            txtContent.Text = note.Content;

            string encoding = note.Encoding;
            if (encoding == "Text") rdoEncoding.SelectedIndex = 0;
            else if (encoding == "Mixed") rdoEncoding.SelectedIndex = 2;
            else rdoEncoding.SelectedIndex = 1;
        }

        protected void chkUpload_CheckedChanged(object sender, EventArgs e)
        {
            pnlFile.Visible = !pnlFile.Visible;
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            if (ImageTextCorrect())
            {
                if (ViewState["Mode"].ToString() == "Edit") FormType = BoardWriteFormType.Modify;
                else if (ViewState["Mode"].ToString() == "Reply") FormType = BoardWriteFormType.Reply;
                else FormType = BoardWriteFormType.Write;

                UploadFile();

                Note note = new Note();
                note.Id = Convert.ToInt32(_Id); //값이 안나면 0
                note.Name = txtName.Text;
                note.Email = txtEmail.Text;
                note.Homepage = txtHomepage.Text;
                note.Title = txtTitle.Text;
                note.Content = txtContent.Text;
                note.FileName = _FileName;
                note.FileSize = _FileSize;
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
                        note.ModifyIp = Request.UserHostAddress;
                        note.FileName = ViewState["FileName"].ToString();
                        note.FileSize = Convert.ToInt32(ViewState["FileSize"]);
                        if (repo.UpdateNote(note) > 0) Response.Redirect($"BoardView.aspx?Id={_Id}");
                        else lblError.Text = "업데이트 실패 , 암호를 확인하세요!!";
                        break;
                    case BoardWriteFormType.Reply:
                        note.ParentNum = Convert.ToInt32(_Id);
                        repo.ReplyNote(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                    default:
                        repo.Add(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                }
            }
        }

        /// <summary>
        /// 추가 : 파일업로드 처리
        /// </summary>
        private void UploadFile()
        {
            _BaseDir = Server.MapPath("../Files"); //D:\GitRepository\StudyAspNet21\NetNote\NetNote\Files
            _FileName = "";
            _FileSize = 0;

            if (txtFileName.PostedFile != null)
            {
                if (txtFileName.PostedFile.FileName.Trim().Length > 0 && 
                    txtFileName.PostedFile.ContentLength > 0)
                {
                    if (FormType == BoardWriteFormType.Modify) //수정일 경우만
                    {
                        ViewState["FileName"] = Helpers.FileUtility.GetFileNameWithNumbering(_BaseDir, Path.GetFileName(txtFileName.PostedFile.FileName));
                        ViewState["FileSize"] = txtFileName.PostedFile.ContentLength;
                        // 업로드
                        txtFileName.PostedFile.SaveAs(Path.Combine(_BaseDir, ViewState["FileName"].ToString()));
                    }
                    else // Write,Reply
                    {
                        // 폴더에 이미 동일한 이름을 파일이 있을 경우 파일 이름(1)을 붙여서 저장 
                        _FileName = Helpers.FileUtility.GetFileNameWithNumbering(_BaseDir,Path.GetFileName(txtFileName.PostedFile.FileName));
                        _FileSize = txtFileName.PostedFile.ContentLength;
                        // 업로드
                        txtFileName.PostedFile.SaveAs(Path.Combine(_BaseDir,_FileName));
                    }
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