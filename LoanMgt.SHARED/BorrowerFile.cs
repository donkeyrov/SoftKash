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
    public class BorrowerFile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowerFileId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select a borrower!")]
        public int BorrowerId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the file name!")]
        public string FileName { get; set; }
        public string ActualFile { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Borrower Borrower { get; set; }
    }
}
