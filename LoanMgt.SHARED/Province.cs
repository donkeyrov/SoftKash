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
    public class Province
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProvinceId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select the country!")]
        public int CountryId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the province code!")]
        public string Code { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the province code!")]
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<Town> Towns { get; set; }
        public Country Country { get; set; }
    }
}
