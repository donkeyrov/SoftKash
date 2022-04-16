using System;
using System.Collections.Generic;
using System.Data;
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
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public TransactionRepository(ApplicationDbContext db) : base(db)
        {
            
        }

        public IEnumerable<Transaction> TransactionTotals()
        {
            List<Transaction> transactions = new List<Transaction>();

            try
            {                
                using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "select  a.EmployeeNo [AccountCode], isnull(sum(Debit),0) [Debit],isnull(sum(Credit),0) [Credit], isnull(sum(Debit) - sum(credit),0) [Balance],a.BorrowerId [TransactionId] " +
                                            " from borrowers a left join transactions b on a.EmployeeNo = b.AccountCode group by a.BorrowerId,a.EmployeeNo ";
                    command.CommandType = CommandType.Text;
                    this.dbContext.Database.OpenConnection();
                    var reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        var tran = new Transaction()
                        {

                            AccountCode = reader.GetString(0),
                            Debit = (double)reader.GetValue(1),
                            Credit = (double)reader.GetValue(2),
                            Balance = (double)reader.GetValue(3),
                            TransactionId = (int)reader.GetValue(4)
                        };
                        transactions.Add(tran);
                    }
                }
                return transactions;
            }
            catch (Exception ex)
            {
                return transactions;
            }            
        }
    }
}
