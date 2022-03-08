using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OfficeNote.Models
{
    public class PartnerInfo
    {
        public int Id { get; set; }
        [Required, DisplayName("접속 도메인")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public Uri Domain { get; set; }

        [Required, DisplayName("사이트 이름")]
        [StringLength(10, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string SiteName { get; set; }

        [Required, DisplayName("로그인 아이디")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string LoginId { get; set; }
        [Required, DisplayName("로그인 비밀번호")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string LoginPW { get; set; }
        [Required]
        public bool IsWebServerLogin { get; set; }
        [DisplayName("1차 로그인 아이디")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string WebServerLoginId { get; set; }
        [DisplayName("1차 로그인 비밀번호")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string WebServerLoginPW { get; set; }
        [DisplayName("로그인 패치")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string LoginPath { get; set; }
        [DisplayName("로그인 캡챠 패치")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string LoginCaptchaPath { get; set; }
        [DisplayName("수익금 확인 패치")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string ProfitPath { get; set; }
        [DisplayName("출금신청 패치")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string WithdrawPath { get; set; }
        [DisplayName("비밀번호 변경 패치")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string PasswdChangePath { get; set; }
        [DisplayName("공지사항 패치")]
        [StringLength(50, ErrorMessage = "{0}은(는) {1}자 미만으로입력하세요")]
        public string NoticePath { get; set; }
    }
}
