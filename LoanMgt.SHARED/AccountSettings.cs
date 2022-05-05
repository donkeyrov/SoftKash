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
        public string CompanyCode { get; set; }
        public int MoxPeriodNonPerforming { get; set; }
        public int DefaultBankAcc { get; set; }
        public int DefaultCashAcc { get; set; }
        public int DefaultReceivablesAcc { get; set; }
        public int DefaultPayablesAcc { get; set; }
        public int DefaultBadDebtAcc { get; set; }
        public int DefaultTaxAcc { get; set; }
        public int DefaultSalesAccount { get; set; }
        public int DefaultPurchasesAcc { get; set; }
        public byte[] Logo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
