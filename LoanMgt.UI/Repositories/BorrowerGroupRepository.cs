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
    public class BorrowerGroupRepository : GenericRepository<BorrowerGroup>, IBorrowerGroupRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public BorrowerGroupRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
