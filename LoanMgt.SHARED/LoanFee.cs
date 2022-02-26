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
    public class LoanFee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanFeeId { get; set; }
        public int LoanId { get; set; }
        public int FeeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Fee Fee { get; set; }
    }
}
