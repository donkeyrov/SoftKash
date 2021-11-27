using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class StaffWeeklyReportsRepository: GenericRepository<StaffWeeklyReports>,IStaffWeeklyReportsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public StaffWeeklyReportsRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
