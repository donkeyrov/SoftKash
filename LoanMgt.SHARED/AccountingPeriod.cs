using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMgt.SHARED
{
    public class AccountingPeriod
    {
        public int AccountingPeriodId { get; set; }
        public string  Code { get; set; }
        public string Year { get; set; }
        public string TaxMonth { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Closed { get; set; }
    }
}
