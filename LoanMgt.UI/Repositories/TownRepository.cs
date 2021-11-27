using LoanMgt.SHARED;
using Microsoft.EntityFrameworkCore;
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
    public class TownRepository : GenericRepository<Town>, ITownRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public TownRepository(ApplicationDbContext db) : base(db)
        {

        }

        public IEnumerable<Town> GetAllWithProvinces()
        {
            return dbContext.Set<Town>().Include(p => p.Province).ThenInclude(c => c.Country).ToList();
        }
    }
}
