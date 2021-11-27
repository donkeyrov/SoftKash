using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{
    public class Collector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CollectorId { get; set; }
        [Required(ErrorMessage = "Please select a branch!")]
        public int BranchId { get; set; }
        [Required(ErrorMessage ="Please enter the collector's name!")]
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Branch Branch { get; set; }
    }
}
