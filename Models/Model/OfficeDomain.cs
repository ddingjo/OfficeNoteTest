using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeNote.Models
{
    public class OfficeDomain
    {
        public int ID { get; set; }
        [DisplayName("도메인"), Required, StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로 입력하세요")]
        public Uri Url { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpiryDT { get; set; }
        [DisplayName("등록한 사이트"), Required, StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로 입력하세요")]
        public string RegisterSite { get; set; }
        [DisplayName("메모"), StringLength(200, ErrorMessage = "{0}은(는) {1}자 미만으로 입력하세요")]
        public string Memo { get; set; }
    }
}
