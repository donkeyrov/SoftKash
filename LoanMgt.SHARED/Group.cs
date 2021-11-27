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
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the group name!")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select the group leader!")]
        public int GroupLeaderId { get; set; }
        public string CollectorName { get; set; }
        public string Details { get; set; }
        public string MeetingSchedule { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Borrower GroupLeader { get; set; }
    }
}
