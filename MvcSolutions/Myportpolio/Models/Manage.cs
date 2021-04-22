using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Myportpolio.Models
{
    public class Manage
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "카테로리를 입력하세요.")]
        public string Cate { get; set; }

        [Required(ErrorMessage = "제목을 입력하세요.")]
        [DataType(DataType.Text)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "페이지 내용을 입력하세요.")]
        [DataType(DataType.Text)]
        public string Contents { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegDate { get; set; }
    }
}
