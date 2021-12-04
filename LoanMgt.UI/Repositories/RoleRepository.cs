using LoanMgt.SHARED;
using LoanMgt.UI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;

namespace LoanMgt.UI.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class RoleRepository : GenericRepository<Role>,IRoleRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public RoleRepository(ApplicationDbContext db):base(db)
        {

        }

        public bool AddRole(Role role)
        {
            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "INSERT INTO AspNetRoles(Id,Name,NormalizedName,ConcurrencyStamp) VALUES('"+ role.Id +"','"+ role.Name +"','"+ role.NormalizedName +"','"+ role.ConcurrencyStamp +"')";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();
                int n = command.ExecuteNonQuery();

                if (n > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool DeleteRole(Role role)
        {
            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "DELETE FROM AspNetRoles WHERE Id= '" + role.Id + "'";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();
                int n = command.ExecuteNonQuery();

                if (n > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<Role> GetAllRole()
        {
            List<Role> roles = new List<Role>();
            Role role;

            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM AspNetRoles";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        role = new Role()
                        {
                            Name = result.GetString("name"),
                            Id = result.GetString("id"),
                            ConcurrencyStamp = result.GetString("ConcurrencyStamp"),
                            NormalizedName = result.GetString("NormalizedName")
                        };
                        roles.Add(role);
                    }
                }
            }
            return roles;
        }

        public Role GetRole(string Id)
        {
            Role role = null;
            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM AspNetRoles WHERE Id= '"+Id+"'";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    if (result.Read())
                    {
                        role = new Role()
                        {
                            Name = result.GetString("name"),
                            Id = result.GetString("id"),
                            ConcurrencyStamp = result.GetString("ConcurrencyStamp"),
                            NormalizedName = result.GetString("NormalizedName")
                        };
                        
                    }
                }
            }
            return role;
        }

        public bool UpdateRole(Role role)
        {
            using (var command = this.dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "UPDATE AspNetRoles SET Name = '"+ role.Name +"', NormalizedName='"+role.NormalizedName +"'  WHERE Id= '" + role.Id + "'";
                command.CommandType = CommandType.Text;
                this.dbContext.Database.OpenConnection();
                int n = command.ExecuteNonQuery();
                
                if(n > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
