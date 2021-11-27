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
    public class OtherIncomeTypeRepository : GenericRepository<OtherIncomeType>, IOtherIncomeTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public OtherIncomeTypeRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
