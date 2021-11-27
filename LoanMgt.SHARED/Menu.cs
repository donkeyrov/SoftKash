using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuId { get; set; }
        [Required]
        public string Name { get; set; }
        public int ParentMenuId { get; set; }
        public string SubText { get; set; }
        public string Target { get; set; }
        [DefaultValue("")]
        public string MenuURL { get; set; }
        [DefaultValue(true)]
        public bool Active { get; set; }
        public int Order { get; set; }
        public string IconName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

    }
}
