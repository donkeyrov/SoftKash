using Microsoft.AspNetCore.Http;
using System.Security.Principal;

namespace LoanMgt.UI.Repositories
{
    public interface IUserContext
    {
        IPrincipal CurrentUser { get; }

        public HttpContext GetContext();
    }
}
