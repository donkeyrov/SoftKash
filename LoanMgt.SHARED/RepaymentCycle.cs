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
    public class RepaymentCycle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RepaymentCycleId { get; set; }
        public string Name { get; set; }
        public bool FixedDays { get; set; }
        public bool FixedDates { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime ManualDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        
    }
}
