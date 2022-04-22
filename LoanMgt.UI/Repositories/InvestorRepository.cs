using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    public class InvestorRepository: GenericRepository<Investor>, IInvestorRepository
    {
        public InvestorRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
