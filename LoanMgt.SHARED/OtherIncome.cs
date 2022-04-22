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
        public int AccountId { get; set; }
        public DateTime IncomeDate { get; set; }
        public int OtherIncomeTypeId { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
        public string ReceiptNo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }

        public Account Account { get; set; }
        public OtherIncomeType OtherIncomeType { get; set; }
    }
}
