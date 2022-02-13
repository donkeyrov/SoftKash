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
    public class Loan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanId { get; set; }
        public int  LoanProductId { get; set; }
        public int BorrowerId { get; set; }
        public int LoanNumber { get; set; }
        public int DisbursementMethodId { get; set; }        
        public float PrincipalAmount { get; set; }
        public DateTime LoanReleaseDate { get; set; }  
        public int InterestMethodId { get; set; }
        public bool InterestIsPercentageBased { get; set; }
        public bool InterestIsFixedAmountPerCycle { get; set; }
        public int LoanInterestPeriodId { get; set; }
        public float LoanInterestRate { get; set; }
        public int LoanPeriod { get; set; }
        public int LoanDurationId { get; set; }        
        public int RepaymentCycleId { get; set; }
        public int NumberOfRePayments { get; set; }
        public DateTime InterestStartDate { get; set; }
        public DateTime FirstRePaymentDate { get; set; }
        public bool CalculateFirstRePaymentProRata { get; set; }
        public bool AdjustFirstRepayment { get; set; }
        public bool DoNotAdjustRemainingPayments { get; set; }
        public float FirstRepaymentAmount { get; set; }
        public float lastRepaymentAmount { get; set; }
        public bool OverrideMaturityDate { get; set; }
        public bool OverrideRepaymentAmount { get; set; }
        public bool AddAutomaticPayments { get; set; }
        public string TimeToPostBetween { get; set; }
        public bool ExttendAfterMaturity { get; set; }
        public bool InterestPercentageBased { get; set; }
        public bool InterestFixedAmount { get; set; }
        public string CalculateInterestOn { get; set; }
        public float InterestRateAfterMaturity { get; set; }
        public int RecurringPeriodAfterMaturity { get; set; }
        public int DDurationAfterMaturity { get; set; }
        public int LoanStatusId { get; set; }
        public string LoanTitle { get; set; }
        public string Description { get; set; }
        public int ApproverStage { get; set; }
        public string FirstApprover { get; set; }
        public DateTime FirstApproverDate { get; set; }
        public string SecondApprover { get; set; }
        public DateTime SecondApproverDate { get; set; }
        public string ThirdApprover { get; set; }
        public DateTime ThirdApproverDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public LoanProduct LoanProduct { get; set; }
        public DisbursementMethod DisbursementMethod { get; set; }
        public InterestMethod InterestMethod { get; set; }
        public LoanDuration LoanDuration { get; set; }
        public RepaymentCycle RepaymentCycle { get; set; }
        public LoanStatus LoanStatus { get; set; }
        public Borrower Borrower { get; set; }
    }
}
