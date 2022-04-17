using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMgt.SHARED
{
    public class TransactionTemp
    {
        public int TransactionTempId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ManNo { get; set; }
        public string EmployeeNo { get; set; }
        public string Nrc { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public bool Posted { get; set; }
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }       

    }
}
