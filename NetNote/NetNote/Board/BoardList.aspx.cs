using NetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetNote.Board
{
    public partial class BoardList : System.Web.UI.Page
    {
        private DbRepository _repo;

        // 검색 모드이면 true , 기본 fale
        public bool SearchMode { get; set; } = false;

        public int RecordCount = 0;

        public BoardList()
        {
            _repo = new DbRepository(); //SqlConnection 생성
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SearchMode)
            {
                RecordCount = _repo.GetCountAll();
            }

            LblTotalRecord.Text = $"페이지 로드 수 : {RecordCount}";

            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            if (!SearchMode)
            {
                GrvNotes.DataSource = _repo.GetAll(0);
            }

            GrvNotes.DataBind(); // 데이터 바인딩 완료
        }
    }
}