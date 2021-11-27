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
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage = "Please enter the country code!")]
        public string Code { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the country name!")]
        public string  Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Province> Provinces { get; set; }
    }
}
