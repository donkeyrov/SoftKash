using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMgt.SHARED
{
    public class OtherIncome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OtherIncomeId { get; set; }
        public int DrAccountId { get; set; }
        public int CrAccountId { get; set; }
        public DateTime IncomeDate { get; set; }
        public int OtherIncomeTypeId { get; set; }
        public string Reference { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
        public string ReceiptNo { get; set; }
        public bool Posted { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }

        public Account Account { get; set; }
        public OtherIncomeType OtherIncomeType { get; set; }
    }
}
