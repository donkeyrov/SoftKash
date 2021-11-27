using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanMgt.SHARED
{
    public class ProfileModule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileModuleId { get; set; }
        [Required]
        public int ProfileId { get; set; }
        [Required]
        public int MenuId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public Menu Menu { get; set; }
        public Profile Profile { get; set; }
    }
}
