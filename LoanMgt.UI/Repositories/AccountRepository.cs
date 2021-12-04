using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanMgt.SHARED;
using LoanMgt.UI.Data;
using Microsoft.EntityFrameworkCore;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountRepository: GenericRepository<Account>, IAccountRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public AccountRepository(ApplicationDbContext db) : base(db)
        {
                
        }

        public IEnumerable<Account> GetAllWithType()
        {
            return dbContext.Set<Account>().Include("AccountType").ToList();
        }
    }
}
