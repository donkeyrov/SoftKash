using LoanMgt.SHARED;
using LoanMgt.UI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRoleRepository : GenericRepository<UserRole>,IUserRoleRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public UserRoleRepository(ApplicationDbContext db):base(db)
        {

        }

        public bool AddUserRoles(List<UserRole> userRoles)
        {
            try
            {
                using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
                {
                    foreach (var userRole in userRoles)
                    {
                        command.CommandText = $"INSERT INTO AspNetUserRoles VALUES('{userRole.UserId}','{userRole.RoleId}')";
                        command.CommandType = CommandType.Text;
                        this.dbContext.Database.OpenConnection();
                        int n = command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteRolesByUserID(string userId)
        {
            try
            {
                using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = $"DELETE FROM AspNetUserRoles WHERE UserId = '{userId}'";
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

        public IEnumerable<UserRole> GetAllUserRoles()
        {
            List<UserRole> userRoles = new List<UserRole>();
            UserRole userRole;

            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM AspNetUserRoles";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        userRole = new UserRole()
                        {
                            RoleId = result.GetString("RoleId"),
                            UserId = result.GetString("UserId")
                        };
                        userRoles.Add(userRole);
                    }
                }
            }
            return userRoles;
        }

    }
}
