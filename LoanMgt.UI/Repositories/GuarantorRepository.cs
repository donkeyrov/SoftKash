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
    public class GuarantorRepository : GenericRepository<Guarantor>, IGuarantorRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public GuarantorRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
