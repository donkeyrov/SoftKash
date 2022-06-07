using Microsoft.AspNetCore.Mvc;
using BoldReports.Web.ReportViewer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using System.IO;
using System.Collections.Generic;
using BoldReports.Web;
using Microsoft.Extensions.Configuration;

namespace LoanMgt.UI.Data
{
    [Route("api/{controller}/{action}/{id?}")]
    public class ReportsAPIController : ControllerBase, IReportController
    {
        // Report viewer requires a memory cache to store the information of consecutive client requests and
        // the rendered report viewer in the server.
        private IMemoryCache _cache;

        // IWebHostEnvironment used with sample to get the application data from wwwroot.
        private IWebHostEnvironment _hostingEnvironment;
        public IConfiguration _configuration { get; }

        public ReportsAPIController(IMemoryCache memoryCache, IWebHostEnvironment hostingEnvironment, IConfiguration configuration)
        {
            _cache = memoryCache;
            _hostingEnvironment = hostingEnvironment;
            _configuration = configuration;
        }
        //Get action for getting resources from the report
        [ActionName("GetResource")]
        [AcceptVerbs("GET")]
        // Method will be called from Report Viewer client to get the image src for Image report item.
        public object GetResource(ReportResource resource)
        {
            return ReportHelper.GetResource(resource, this, _cache);
        }

        // Method will be called to initialize the report information to load the report with ReportHelper for processing.
        [NonAction]
        public void OnInitReportOptions(ReportViewerOptions reportOption)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            // Here, we have loaded the sales-order-detail.rdl report from the application folder wwwroot\Resources. sales-order-detail.rdl should be in the wwwroot\Resources application folder.
            System.IO.FileStream inputStream = new System.IO.FileStream(basePath + @"\resources\" + reportOption.ReportModel.ReportPath + ".rdl", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            MemoryStream reportStream = new MemoryStream();
            inputStream.CopyTo(reportStream);
            reportStream.Position = 0;
            inputStream.Close();
            reportOption.ReportModel.Stream = reportStream;

            DataSourceCredentials dataSourceCredentials = new DataSourceCredentials();

            string connectionString = _configuration.GetSection("DBSettings").GetValue<string>("connectionString");

            //You have to provide the shared data source name used with the report or the data source name available with the report.
            dataSourceCredentials.Name = "DataSource1";
            dataSourceCredentials.IntegratedSecurity = false;
            dataSourceCredentials.UserId = _configuration.GetSection("DBSettings").GetValue<string>("username");
            dataSourceCredentials.Password = _configuration.GetSection("DBSettings").GetValue<string>("pwd");

            dataSourceCredentials.ConnectionString = connectionString;
            reportOption.ReportModel.DataSourceCredentials = new List<DataSourceCredentials> { dataSourceCredentials };
        }

        // Method will be called when report is loaded internally to start the layout process with ReportHelper.
        [NonAction]
        public void OnReportLoaded(ReportViewerOptions reportOption)
        {
        }

        [HttpPost]
        public object PostFormReportAction()
        {
            return ReportHelper.ProcessReport(null, this, _cache);
        }

        // Post action to process the report from the server based on json parameters and send the result back to the client.
        [HttpPost]
        public object PostReportAction([FromBody] Dictionary<string, object> jsonArray)
        {
            return ReportHelper.ProcessReport(jsonArray, this, this._cache);
        }
    }
}
