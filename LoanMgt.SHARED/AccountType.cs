using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanMgt.SHARED
{
    public class AccountType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountTypeId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Desciption { get; set; }
        public bool Debit { get; set; }
        public bool Credit { get; set; }
        public bool BalanceSheetAccount { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
