using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OfficeNote.Models
{
    public class Member
    {
        public int ID { get; set; }
        [Required, DisplayName("로그인 아이디")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "{0}은(는) {1}자에서 {2}자 까지만 사용 가능합니다. ")]
        public string LoginID { get; set; }
        [Required, DisplayName("로그인 비밀번호")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0}은(는) {1}자에서 {2}자 까지만 사용 가능합니다. ")]
        public string LoginPW { get; set; }
        [Required, DisplayName("이름")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{0}은(는) {1}자에서 {2}자 까지만 사용 가능합니다. ")]
        public string Name { get; set; }
        public DateTime CreateDT { get; set; }
        public int LoginFailCnt { get; set; }

        [Required]
        public string LoginIP { get; set; }

        public ICollection<Cost> Costs { get; set; }
    }
}
