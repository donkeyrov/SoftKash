using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMgt.SHARED
{
    [NotMapped]
    public class LoanTemp
    {
        public float LoanRate { get; set; }
        public int NumberOfMonths { get; set; }
        public float Capital { get; set; }
        public float OriginationFee { get; set; }
        public float Insurance1 { get; set; }
        public float LegislativeFee { get; set; }
        public float StampDuty { get; set; }
        public float Levy { get; set; }
        public float CreditBureauFee { get; set; }
        public float CapitalizedTotal { get; set; }
        public float InterimInterest { get; set; }
        public float InterestBearingCapital { get; set; }
        public float ServiceFee { get; set; }
        public float CollectionFee { get; set; }
        public float Insurance2 { get; set; }
        public float MonthlyFee { get; set; }
        public float MonthlyInstallment { get; set; }
        public float TotalDue { get; set; }
        public float EffectivePA { get; set; }
        public float TotalReturn { get; set; }
        public float TotalReturnPA { get; set; }

    }
}
