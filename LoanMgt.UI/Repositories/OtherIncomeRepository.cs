using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    public class OtherIncomeRepository: GenericRepository<OtherIncome>,IOtherIncomeRepository
    {
        public OtherIncomeRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
