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
    public class TransactionCodeRepository : GenericRepository<TransactionCode>, ITransactionCodeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public TransactionCodeRepository(ApplicationDbContext db): base(db)
        {
            
        }
    }
}
