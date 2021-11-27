using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountSettingsRepository : GenericRepository<AccountSettings>, IAccountSettingsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public AccountSettingsRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
