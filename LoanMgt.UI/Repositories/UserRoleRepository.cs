using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRoleRepository : GenericRepository<UserRole>,IUserRoleRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public UserRoleRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
