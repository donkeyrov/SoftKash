using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class CurrencyRepository : GenericRepository<Currency>,ICurrencyRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public CurrencyRepository(ApplicationDbContext db): base(db)
        {

        }
    }
}
