using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMgt.SHARED
{
    public class AttachmentFiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SourceId { get; set; }
        public string Filename { get; set; }
        public string Path { get; set; }
        public string SourceType { get; set; }        
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
