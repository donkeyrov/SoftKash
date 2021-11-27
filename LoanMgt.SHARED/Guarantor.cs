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
    public class Guarantor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuarantorId { get; set; }
        public int CountryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public string UniqueNumber{ get; set; }
        public string NRC { get; set; }
        public int GenderId { get; set; }
        public int TitleId { get; set; }
        public String Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int TownId { get; set; }
        public int ProvinceId { get; set; }
        public string ZipCode { get; set; }
        public string LandLinePhone { get; set; }
        public int WorkingStatusId { get; set; }
        public byte[] Photo { get; set; }
        public string Details { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
