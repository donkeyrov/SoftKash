using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    public class ExpenseTypeRepository: GenericRepository<ExpenseType>,IExpenseTypeRepository
    {
        public ExpenseTypeRepository(ApplicationDbContext db): base(db)
        {

        }
    }
}
