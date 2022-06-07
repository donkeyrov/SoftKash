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
    public interface ISequenceRepository : IGenericRepository<Sequence>
    {
        public Sequence GetByName(string name);

        public Sequence Increment(Sequence sequence);

    }
}
