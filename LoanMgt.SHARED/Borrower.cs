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
    public class Borrower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowerId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the firstname!")]
        public string Firstname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the lastname!")]
        public string Lastname { get; set; }
        public string BusinessName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the Employee Number!")]
        public string EmployeeNo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the NRC!")]
        [Index("IDX_NRC",IsUnique =true)]
        public string NRC { get; set; }
        public int? GenderId { get; set; }
        public int? TitleId { get; set; }
        public string? Mobile { get; set; }
        [Index("IDX_Email", IsUnique = true)]
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public int? GroupId { get; set; }
        public int TownId { get; set; }
        public int ProvinceId { get; set; }
        public string? ZipCode { get; set; }
        public string? LandLine { get; set; }
        public int? WorkingStatusId { get; set; }
        public float? CreditScore { get; set; }
        public byte[]? Photo { get; set; }
        public int? StatusId { get; set; }        
        public string? Details { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Gender Gender { get; set; }
        public Title Title { get; set; }
        public Town Town { get; set; }
        public Province Province { get; set; }
        public AccountType AccountType { get; set; }
        public Status Status { get; set; }
        //public Group Group { get; set; }
        public WorkingStatus WorkingStatus { get; set; }

    }
}
