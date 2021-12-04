using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{ 
    [Table("AspNetUserRole")]
    public class UserRole: IdentityUserRole
    {
    }
}
