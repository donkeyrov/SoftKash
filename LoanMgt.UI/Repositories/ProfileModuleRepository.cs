using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    public class ProfileModuleRepository : GenericRepository<ProfileModule>, IProfileModuleRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public ProfileModuleRepository(ApplicationDbContext db) : base(db)
        {
            
        }
    }
}
