//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTelerikRestService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bursary_Apportionment
    {
        public long Id { get; set; }
        public long ProgrammeId { get; set; }
        public long IntakeId { get; set; }
        public string Semester { get; set; }
        public System.DateTime SemesterPeriod { get; set; }
        public System.DateTime ApportionmentPeriod { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long LastChangedById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public bool IsDeleted { get; set; }
    }
}