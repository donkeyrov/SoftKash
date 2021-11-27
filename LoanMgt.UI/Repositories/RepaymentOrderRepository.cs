using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class RepaymentOrderRepository : GenericRepository<RepaymentOrder>, IRepaymentOrderRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public RepaymentOrderRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
