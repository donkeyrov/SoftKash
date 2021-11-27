using LoanMgt.SHARED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class BranchRepository : GenericRepository<Branch>, IBranchRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public BranchRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
