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
    
    public partial class Academic_ExamDocket
    {
        public long Id { get; set; }
        public long ProgrammeId { get; set; }
        public long ExamDocumentId { get; set; }
        public string Intake { get; set; }
        public long StudyIntake { get; set; }
        public string AcademicSemesterNo { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
    }
}
