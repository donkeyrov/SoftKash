using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanMgt.SHARED
{ 
    [Table("AspNetUserRoles")]
    public class UserRole: IdentityUserRole
    {
    }
}
