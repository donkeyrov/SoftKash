using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    public class TransactionTempRepository:GenericRepository<TransactionTemp>,ITransactionTempRepository
    {
        public TransactionTempRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
