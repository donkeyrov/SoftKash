using LoanMgt.SHARED;
using LoanMgt.UI.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LoanMgt.UI.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext db): base(db)
        {

        }

        public bool DeleteUser(string id)
        {
            try
            {
                using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "DELETE FROM AspNetUsers WHERE Id = '" + id + "'";
                    command.CommandType = CommandType.Text;
                    this.dbContext.Database.OpenConnection();
                    int n = command.ExecuteNonQuery();

                    if (n > 0)
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;

        }
    }
}
