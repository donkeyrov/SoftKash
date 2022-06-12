using System;
using LoanMgt.SHARED;
using LoanMgt.UI.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Collections.Generic;

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

        public IEnumerable<User> GetAllUsers()
        {
            List<User> users = new List<User>();
           
            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM AspNetUsers";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        User user = new User()
                        {
                            Id = result.GetString("Id"),
                            UserName = result.GetString("UserName"),
                            NormalizedUserName = result.GetString("NormalizedUserName"),
                            Email = result.GetString("Email"),
                            NormalizedEmail = result.GetString("NormalizedEmail"),
                            //EmailConfirmed = result.GetFieldValue<bool>("EmailConfirmed"),
                            //PasswordHash = result.GetString("PasswordHash"),
                            //SecurityStamp = result.GetString("SecurityStamp"),
                            //ConcurrencyStamp = result.GetString("ConcurrencyStamp"),
                            //PhoneNumber = result.GetValue("PhoneNumber") != null ? result.GetString("PhoneNumber"): "",
                            //PhoneNumberConfirmed = result.GetFieldValue<bool>("PhoneNumberConfirmed"),
                            //TwoFactorEnabled = result.GetFieldValue<bool>("TwoFactorEnabled"),
                            //LockoutEnd = result.GetFieldValue<DateTimeOffset>("LockoutEnd"),
                            //LockoutEnabled = result.GetFieldValue<bool>("LockoutEnd"),
                            //AccessFailedCount = result.GetFieldValue<int>("LockoutEnd"),
                            //BranchId = result.GetValue("BranchId") != null ? result.GetFieldValue<int>("BranchId") : 0,
                            //Firstname = result.GetValue("Firstname") != null ? result.GetString("Firstname") : "",
                            //Lastname = result.GetValue("Lastname") != null ? result.GetString("Lastname") : "",
                        };
                        users.Add(user);
                    }
                }
            }
            return users;
        }

    }
}
