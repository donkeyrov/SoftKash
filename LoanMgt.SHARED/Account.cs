using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanMgt.SHARED
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        [Required]
        public int AccountTypeId { get; set; }
        [Required]
        [DefaultValue(1)]
        public int CurrencyId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string AccountName { get; set; }
        public float Debit { get; set; }
        public float Credit { get; set; }
        public bool Active { get; set; }

        public AccountType AccountType { get; set; }
        public Currency Currency { get; set; }
    }
}
