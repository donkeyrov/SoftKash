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
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BranchId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name!")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the address!")]
        public string Address { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select the town!")]
        public int TownId { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Details { get; set; }
        public float MinLoanAmount { get; set; }
        public float MaxLoanAmount { get; set; }
        public float MinInterestRate { get; set; }
        public float MaxInterestRate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Town Town { get; set; }
    }
}
