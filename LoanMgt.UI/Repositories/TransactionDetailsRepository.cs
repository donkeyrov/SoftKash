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
    public class TransactionDetailsRepository : GenericRepository<TransactionDetails>, ITransactionDetailsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public TransactionDetailsRepository(ApplicationDbContext db) : base(db)
        {
                
        }
    }
}
