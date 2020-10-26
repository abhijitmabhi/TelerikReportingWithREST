using System.Linq;
using MyTelerikRestService.Models;

namespace MyTelerikRestService.Controllers
{
    using System.IO;
    using System.Web;
    using Telerik.Reporting.Cache.File;
    using Telerik.Reporting.Services;
    using Telerik.Reporting.Services.WebApi;

	//The class name determines the service URL. 
	//ReportsController class name defines /api/report/ service URL.
    public class ReportsController : ReportsControllerBase
    {
        static ReportServiceConfiguration configurationInstance;

        static ReportsController()
        {

            var resolver = new UriReportSourceResolver(HttpContext.Current.Server.MapPath("~/Reports"))
                .AddFallbackResolver(new TypeReportSourceResolver()
                    .AddFallbackResolver(new CustomReportSourceResolver()));

            configurationInstance = new ReportServiceConfiguration
            {
                HostAppId = "Application1",
                ReportSourceResolver = resolver,
                Storage = new Telerik.Reporting.Cache.File.FileStorage(),
            };
        }

        public ReportsController()
        {
			//Initialize the service configuration
            this.ReportServiceConfiguration = configurationInstance;
        }
    }
}