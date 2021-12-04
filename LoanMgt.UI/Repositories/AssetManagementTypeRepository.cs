using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class AssetManagementTypeRepository : GenericRepository<AssetManagementType>,IAssetManagementTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public AssetManagementTypeRepository(ApplicationDbContext db): base(db)
        {

        }
    }
}
