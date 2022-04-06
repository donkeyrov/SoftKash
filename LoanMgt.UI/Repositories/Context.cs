using Microsoft.AspNetCore.Http;
using System.Security.Principal;

namespace LoanMgt.UI.Repositories
{
    public class Context : IUserContext
    {
        private readonly IHttpContextAccessor accessor;
        public Context(IHttpContextAccessor accessor)
        {
            this.accessor = accessor;
        }

        public IPrincipal CurrentUser => accessor.HttpContext.User;

        public HttpContext GetContext()
        {
            return accessor.HttpContext;
        }
    }
}
