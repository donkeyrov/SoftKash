using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class ProfileRepository : GenericRepository<Profile>, IProfileRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public ProfileRepository(ApplicationDbContext db): base(db)
        {
                
        }
    }
}
