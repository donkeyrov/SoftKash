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
    public class BranchHolidayRepository : GenericRepository<BranchHoliday>,IBranchHolidayRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public BranchHolidayRepository(ApplicationDbContext db) : base(db)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="branchId"></param>
        /// <returns></returns>
        public BranchHoliday GetByBranchId(int branchId)
        {
            var branchHoliday = dbContext.Set<BranchHoliday>().Where(b => b.BranchId == branchId).FirstOrDefault();
            return branchHoliday;
        }
    }
}
