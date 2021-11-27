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
    public class LoanFeeRepository : GenericRepository<LoanFee>, ILoanFeeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public LoanFeeRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
