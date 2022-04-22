using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMgt.SHARED
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExpenseId { get; set; }
        public int AccountId { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int ExpenseTypeId { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
        public string InvoiceNo { get; set; }        
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }

        public Account Account { get; set; }
        public ExpenseType ExpenseType { get; set; }
    }
}
