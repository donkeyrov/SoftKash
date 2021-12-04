using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanMgt.SHARED
{
    public class TransactionCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionCodeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int DebitAccountId { get; set; }
        public int CreditAccountId { get; set; }
        public bool Active { get; set; }
        public Account DebitAccount { get; set; }
        public Account CreditAccount { get; set; }
    }
}
