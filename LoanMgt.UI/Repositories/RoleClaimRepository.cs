using System;
using System.Collections.Generic;
using System.Data;
using LoanMgt.SHARED;
using LoanMgt.UI.Data;
using Microsoft.EntityFrameworkCore;

namespace LoanMgt.UI.Repositories
{
    public class RoleClaimRepository: GenericRepository<RoleClaim>,IRoleClaimRepository
    {
        public RoleClaimRepository(ApplicationDbContext db) : base(db)
        {
                
        }
        public bool DeleteClaimsByRole(string roleId)
        {
            try
            {
                using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = $"DELETE FROM AspNetRoleClaims WHERE RoleId = '{roleId}'";
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

        public bool AddRoleClaims(List<RoleClaim> roleClaims)
        {
            try
            {
                dbContext.Set<RoleClaim>().AddRangeAsync(roleClaims);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<RoleClaim> GetAllRoleClaims()
        {
            List<RoleClaim> roleClaims = new List<RoleClaim>();
            RoleClaim roleClaim;

            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM AspNetRoleClaims";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        roleClaim = new RoleClaim()
                        {
                            RoleId = result.GetString("RoleId"),
                            Id = result.GetInt32("Id"),
                            ClaimType = result.GetString("ClaimType"),
                            ClaimValue = result.GetString("ClaimValue")
                        };
                        roleClaims.Add(roleClaim);
                    }
                }
            }
            return roleClaims;
        }

        public RoleClaim GetRoleClaims(string Id)
        {
            RoleClaim roleClaim = null;
            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM AspNetRoleClaims WHERE Id= '" + Id + "'";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    if (result.Read())
                    {
                        roleClaim = new RoleClaim()
                        {
                            RoleId = result.GetString("RoleId"),
                            Id = result.GetInt32("Id"),
                            ClaimType = result.GetString("ClaimType"),
                            ClaimValue = result.GetString("ClaimValue")
                        };

                    }
                }
            }
            return roleClaim;
        }
    }
}
