using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{
    /// <summary>
    /// 
    /// </summary>
    public class BranchHoliday
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BranchHolidayId { get; set; }
        public int BranchId { get; set; }
        public string HolidayDates { get; set; }
        public bool FridayBranchHoliday { get; set; }
        public bool SaturdayBranchHoliday { get; set; }
        public bool SundayBranchHoliday { get; set; }
        public bool NextDayThatIsNotHoliday { get; set; }
        public bool NextRepaymentCycle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Branch Branch { get; set; }
    }
}
