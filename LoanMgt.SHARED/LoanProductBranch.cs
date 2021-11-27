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
    public class LoanProductBranch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanProductBranchId { get; set; }
        [Required]
        public int BranchId { get; set; }
        [Required]
        public int LoanProductId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Branch Branch { get; set; }
        public LoanProduct LoanProduct { get; set; }
    }
}
