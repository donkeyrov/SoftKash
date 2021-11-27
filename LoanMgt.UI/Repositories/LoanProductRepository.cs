﻿using LoanMgt.SHARED;
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
    public class LoanProductRepository : GenericRepository<LoanProduct>, ILoanProductRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public LoanProductRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
