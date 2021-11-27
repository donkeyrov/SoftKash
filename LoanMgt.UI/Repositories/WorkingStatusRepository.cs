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
    public class WorkingStatusRepository : GenericRepository<WorkingStatus>, IWorkingStatusRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public WorkingStatusRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
