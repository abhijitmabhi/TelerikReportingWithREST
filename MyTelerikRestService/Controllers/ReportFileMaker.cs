using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using MyTelerikRestService.Models;
using MyTelerikRestService.Reports;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using Report = Telerik.Reporting.Report;

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

            SaveReportProgramatically(reportObj, "C:\\MyReport.pdf");
           

            return irs;
        }

        public void SaveReportProgramatically(Report report, string fileName)
        {
            ReportProcessor reportProcessor = new ReportProcessor();
            Telerik.Reporting.InstanceReportSource instanceReportSource = new Telerik.Reporting.InstanceReportSource();
            instanceReportSource.ReportDocument = report;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, null);

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }
        }

    }
}