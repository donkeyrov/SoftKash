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
    public class Town
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TownId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select the province!")]
        public int ProvinceId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the town code!")]
        public string Code { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the town name!")]
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<Branch> Branches { get; set; }
        public Province Province { get; set; }
    }
}
