using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTelerikRestService.Models;
using MyTelerikRestService.Reports;
using Telerik.Reporting;

namespace MyTelerikRestService.Controllers
{
    public class ReportFileMaker
    {
        public ReportSource GetReportDocument()
        {
            Report reportObj;
            var rManager = new ReportManager();
            var irs = new Telerik.Reporting.InstanceReportSource();

            reportObj = new Report1();

            reportObj.DataSource = rManager.GetAdmissionApplicant();

            irs.ReportDocument = reportObj;

            return irs;
        }

        public class ReportDTO
        {
            public string FullName { get; set; }
            public string FatherName { get; set; }
        }
    }
}