using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class StaffDailyReportsRepository:GenericRepository<StaffDailyReports>,IStaffDailyReportsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public StaffDailyReportsRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
