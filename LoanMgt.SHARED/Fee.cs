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
    public class Fee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeeId { get; set; }
        public string Name { get; set; }
        public bool Fixedamount { get; set; }
        public bool PercentageBased { get; set; }
        public float Amount { get; set; }
        public bool CalculateOnDuePrincipalAmount { get; set; }
        public bool CalculateOnDueInterestamount { get; set; }
        public bool CalculateOnDuePricipalAndInterest { get; set; }
        public bool DeductFromPrincipalAmount { get; set; }
        public bool Capitalized { get; set; }
        public bool Monthly { get; set; }
        public bool Recurring { get; set; }
        public int TransactionCodeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }



    }
}
