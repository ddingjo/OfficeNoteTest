using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeNote.Models
{
    public class Cost
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public DateTime DateTime { get; set; }
        [Column(TypeName = "money")]
        public decimal Money { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Message { get; set; }

        public Member Member { get; set; }
    }
}
