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
    public class CollateralType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CollateralTypeId { get; set; }
        public string Name { get; set; }        
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
