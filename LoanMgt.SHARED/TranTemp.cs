using System.ComponentModel.DataAnnotations.Schema;

namespace LoanMgt.SHARED
{
    [NotMapped]
    public class TranTemp
    {
        public int TransactionDetailsId { get; set; }
        public int TransactionCodeId { get; set; }
        public string CustomerNo { get; set; }
        public string Details { get; set; }
        public double Amount { get; set; }
    }
}
