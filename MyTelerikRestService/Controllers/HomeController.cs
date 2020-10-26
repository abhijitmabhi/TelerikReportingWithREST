using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MyTelerikRestService.Models;
using Telerik.Reporting.Services.WebApi;

namespace MyTelerikRestService.Controllers
{
    public class HomeController : ReportsControllerBase
    {
        public void Index()
        {
            using (var context = new SmartCampusDBEntities())
            {
                var query = context.Admission_Applicant.Select(a => a).ToList();
            }

             
            
        }
    }
}