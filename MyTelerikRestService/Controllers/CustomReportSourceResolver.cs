using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTelerikRestService.Models;
using MyTelerikRestService.Reports;
using Telerik.Reporting.Services;
using Report = Telerik.Reporting.Report;

namespace MyTelerikRestService.Controllers
{
    public class CustomReportSourceResolver : IReportSourceResolver
    {
        public Telerik.Reporting.ReportSource Resolve(string reportId, OperationOrigin operationOrigin, IDictionary<string, object> currentParameterValues)
        {
            var reportGenerator = new ReportFileMaker();
            return reportGenerator.GetReportDocument();
        }
        
    }
}