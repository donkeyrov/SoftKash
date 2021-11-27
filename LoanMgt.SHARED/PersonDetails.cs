using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanMgt.SHARED
{
    public class PersonDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonDetailsId { get; set; }
        [Required]
        public string NRC { get; set; }
        [Required]
        public int TitleId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int GenderId { get; set; }
        public int CountryId { get; set; }
        public int TownId { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string ResidentialArea { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }        
        [DataType(DataType.PhoneNumber)]        
        public string CountryOfbirth { get; set; }
        public string TownOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportNo { get; set; }        
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public Title Title { get; set; }
        public Gender Gender { get; set; }
        public Country Country { get; set; }
        public Town Town { get; set; }
    }
}
