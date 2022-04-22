using LoanMgt.SHARED;
using LoanMgt.UI.Data;

namespace LoanMgt.UI.Repositories
{
    public class AttachmentFilesRepository: GenericRepository<AttachmentFiles>,IAttachmentFilesRepository
    {
        public AttachmentFilesRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
