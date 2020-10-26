using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTelerikRestService.Models;

namespace MyTelerikRestService.Controllers
{
    public class ReportManager
    {
        public List<ReportDTO> GetAdmissionApplicant()
        {
            var context = new SmartCampusDBEntities();
            var result = new List<ReportDTO>();

            var query = (from a in context.Admission_Applicant
                select new ReportDTO()
                {
                    FatherName = a.FatherName,
                    FullName = a.FullName
                }).ToList();

            result = query;

            return result;
        }
    }

    public class ReportDTO
    {
        public string FullName { get; set; }
        public string FatherName { get; set; }
    }

}