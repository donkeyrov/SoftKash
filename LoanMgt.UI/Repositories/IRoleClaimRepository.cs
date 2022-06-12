using System.Collections.Generic;
using LoanMgt.SHARED;

namespace LoanMgt.UI.Repositories
{
    public interface IRoleClaimRepository : IGenericRepository<RoleClaim>
    {
        public bool DeleteClaimsByRole(string roleId);

        public bool AddRoleClaims(List<RoleClaim> roleClaims);  

        public IEnumerable<RoleClaim> GetAllRoleClaims();
        public RoleClaim GetRoleClaims(string Id);
    }
}
