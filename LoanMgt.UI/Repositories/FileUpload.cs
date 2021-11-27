using Microsoft.AspNetCore.Hosting;

namespace LoanMgt.UI.Repositories
{
    public class FileUpload
    {
        private readonly IWebHostEnvironment _environment;
        public FileUpload(IWebHostEnvironment env)
        {
            _environment = env;
        }

        public string GetWebRootPath()
        {
            return _environment.ContentRootPath;
        }
    }
}
