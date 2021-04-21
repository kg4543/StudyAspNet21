using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Myportpolio.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="이름을 입력하세요.")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "이메일을 입력하세요.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "메시지를 입력하세요.")]
        [DataType(DataType.Text)]
        public string Contents { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime RegDate { get; set; }
    }
}
