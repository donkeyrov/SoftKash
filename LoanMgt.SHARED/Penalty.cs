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
    public class Penalty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PenaltyId { get; set; }
        public bool Enabled { get; set; }
        public bool PercentageBased { get; set; }
        public bool FixedAmount { get; set; }
        public string CalculateOn { get; set; }
        public bool WaivePenaltyOnHolidays { get; set; }
        public float InterestRate { get; set; }
        public int GracePeriod { get; set; }
        public float RecurringPenaltyInterestRate { get; set; }
        public int MyProperty { get; set; }
        public int RecurringPeriod { get; set; }
        public int RecurringPeriodType { get; set; }
        public string LoanScheduleDescription { get; set; }
        public bool EnableAfterMaturity { get; set; }
        public bool MaturityPercentageBased { get; set; }
        public bool MaturityFixedAmount { get; set; }
        public string MaturityCalculateOn { get; set; }
        public bool MaturityWaivePenaltyOnHolidays { get; set; }
        public float MaturityPenaltyInterestRate { get; set; }
        public int MaturityGracePeriod { get; set; }
        public float MaturityRecurringPenaltyInterestRate { get; set; }
        public int MaturityRecurringPeriod { get; set; }
        public int MaturityRecurringPeriodType { get; set; }
        public string MaturityLoanScheduleDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
