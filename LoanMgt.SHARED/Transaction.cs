using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanMgt.SHARED
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string AccountCode { get; set; }
        public string TransactionType { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public double Balance { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public int TaxTypeId { get; set; }
        public string Reference { get; set; }
        public float UnitPrice { get; set; }
        public double TaxAmount { get; set; }
        public string BatchRef { get; set; }
        public string UserId { get; set; }
        public string CustomerNo { get; set; }
        public int BranchId { get; set; }
        public int BorrowerId { get; set; }
        public bool Reconciled { get; set; }
        public bool Archived { get; set; }
        public string TaxMonth { get; set; }
        public string AccountingYear { get; set; }

        public TaxType TaxType { get; set; }
        public Branch Branch { get; set; }
    }
}
