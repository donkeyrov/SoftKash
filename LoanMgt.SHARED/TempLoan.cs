using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMgt.SHARED
{
    [NotMapped]
    public class TempLoan
    {
        public bool Selected { get; set; }
        public string EmployeeNo { get; set; }
        public string OldWageType { get; set; }
        public string NewWageType { get; set; }
        public string EndDate { get; set; }
        public string StartDate { get; set; }
        public string Instalment { get; set; }
        public string Cheque { get; set; }
        public string ZLSCH { get; set; }
        public string Nrc { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
    }
}
