using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    public class ExpenseRepository: GenericRepository<Expense>,IExpenseRepository
    {
        public ExpenseRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
