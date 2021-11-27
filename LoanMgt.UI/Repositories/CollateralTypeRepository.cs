using LoanMgt.SHARED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class CollateralTypeRepository : GenericRepository<CollateralType>,ICollateralTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public CollateralTypeRepository(ApplicationDbContext db): base(db)
        {

        }
    }
}
