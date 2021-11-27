using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{
    public class AccountSettings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountSettingsId { get; set; }
        public string CompanyName { get; set; }
        public int CountryId { get; set; }
        public int CurrencyId { get; set; }
        public string DateFormat { get; set; }
        public int MonthlyLoanRepaymentCycle { get; set; }
        public int YearlyLoanRepaymentCycle { get; set; }
        public int DaysInMonthInterestCalculation { get; set; }
        public int DaysInYearInterestCalculation { get; set; }
        public bool LoansDueToday { get; set; }
        public bool LoansExpiringtoday { get; set; }
        public bool LoansPastMaturityDate { get; set; }
        public bool NewLoansAdded { get; set; }
        public bool NewRepaymentsAdded { get; set; }
        public byte[] Logo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
