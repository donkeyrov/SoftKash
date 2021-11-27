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
    public class BankRepository : GenericRepository<Bank>, IBankRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public BankRepository(ApplicationDbContext db) : base(db)
        {     
        }     
    
    }
}
