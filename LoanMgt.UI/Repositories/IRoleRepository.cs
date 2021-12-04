using LoanMgt.SHARED;

using System.Collections.Generic;

namespace LoanMgt.UI.Repositories
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        public IEnumerable<Role> GetAllRole();
        public Role GetRole(string Id);
        public bool AddRole(Role role);
        public bool UpdateRole(Role role);
        public bool DeleteRole(Role role);
    }
}
