using LoanMgt.SHARED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITownRepository : IGenericRepository<Town>
    {
        public IEnumerable<Town> GetAllWithProvinces();
    }
}
