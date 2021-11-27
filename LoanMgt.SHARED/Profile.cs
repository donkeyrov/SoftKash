using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{
    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Description { get; set; }
        [DefaultValue(true)]
        public bool Active { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }        
        public List<ProfileModule> ProfileModules { get; set; }
    }
}
