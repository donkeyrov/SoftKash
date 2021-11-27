using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonDetailsRepository : GenericRepository<PersonDetails>, IPersonDetailsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public PersonDetailsRepository(ApplicationDbContext db) : base(db)
        {
                
        }
    }
}
