using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{
    [Table("AspNetRole")]
    public class Role : IdentityRole
    {
    }
}
