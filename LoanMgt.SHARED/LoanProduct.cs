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
    public class LoanProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanProductId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the loan product name!")]
        public string Name { get; set; }
        public bool Cash { get; set; }
        public bool Cheque { get; set; }
        public bool OnlineTransfer { get; set; }
        public float MinimumPrincipalAmount { get; set; }
        public float DefaultPrincipalAmount { get; set; }
        public float MaximumPrincipalAmount { get; set; }
        public int InterestMethodId { get; set; }
        public bool InterestIsPercentageBased { get; set; }
        public bool InterestIsFixedAmountPerCycle { get; set; }
        public int LoanInterestPeriodId { get; set; }
        public float MinimumLoanInterestRate { get; set; }
        public float DefaultLoanInterestRate { get; set; }
        public float MaximumLoanInterestRate { get; set; }
        public int LoanDurationId { get; set; }
        public int MinimumLoanDuration { get; set; }
        public int DefaultLoanDuration { get; set; }
        public int MaximumLoanDuration { get; set; }
        public int RepaymentCycleId { get; set; }
        public int MinimumNumberOfRePayments { get; set; }
        public int DefaultNumberOfRePayments { get; set; }
        public int MaximumNumberOfRepayments { get; set; }
        public string RepaymentOrder { get; set; }
        public bool ExtendAfterMaturity { get; set; }
        public bool MaturityInterestIsPercentageBased { get; set; }
        public bool MaturityInterestIsFixedAmount { get; set; }
        public string CalculateInterestOn { get; set; }
        public float InterestRateAfterMaturity { get; set; }
        public int RecurringPeriodAfterMaturity { get; set; }
        public int DurationAfterMaturity { get; set; }
        public int PastMaturityLoanStatus { get; set; }
        public float FirstRepaymentAmount { get; set; }
        public float lastRepaymentAmount { get; set; }
        public float OverrideRepaymentAmountTo { get; set; }
        public bool ProRataInterestCalculation { get; set; }
        public string LoanScheduleDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public DisbursementMethod DisbursementMethod { get; set; }
        public InterestMethod InterestMethod { get; set; }
        public LoanDuration LoanDuration { get; set; }
        public RepaymentCycle RepaymentCycle { get; set; }
        public LoanInterestPeriod LoanInterestPeriod { get; set; }
    }
}
