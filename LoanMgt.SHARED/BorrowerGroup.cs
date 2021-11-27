using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{
    /// <summary>
    /// 
    /// </summary>
    public class BorrowerGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowerGroupId { get; set; }
        [Required]
        public int BorrowerId { get; set; }
        [Required]
        public int GroupId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Borrower Borrower { get; set; }
        public Group Group { get; set; }
    }
}
