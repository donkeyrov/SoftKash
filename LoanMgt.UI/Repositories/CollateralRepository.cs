using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    public class CollateralRepository: GenericRepository<SHARED.Collateral>,ICollateralRepository
    {
        public CollateralRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
