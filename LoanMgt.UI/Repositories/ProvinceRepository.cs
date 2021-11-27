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
    public class ProvinceRepository : GenericRepository<Province> , IProvinceRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public ProvinceRepository(ApplicationDbContext db) : base(db)
        {

        }

        public IEnumerable<Province> GetAllWithCountry()
        {
            return dbContext.Set<Province>().Include("Country").ToList();
        }
    }
}
