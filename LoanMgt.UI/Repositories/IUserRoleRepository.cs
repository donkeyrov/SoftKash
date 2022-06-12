using LoanMgt.SHARED;
using System.Collections.Generic;

namespace LoanMgt.UI.Repositories
{
    public interface IUserRoleRepository : IGenericRepository<UserRole>
    {
        public bool DeleteRolesByUserID(string userId);

        public bool AddUserRoles(List<UserRole> userRoles);

        public IEnumerable<UserRole> GetAllUserRoles();
    }
}
