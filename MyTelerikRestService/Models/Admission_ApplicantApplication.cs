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
    
    public partial class Admission_ApplicantApplication
    {
        public long Id { get; set; }
        public long ApplicantId { get; set; }
        public long ProgrammeId { get; set; }
        public long StudyIntakeId { get; set; }
        public long LevelOfStudyId { get; set; }
        public long SemesterId { get; set; }
        public long FeeTypeId { get; set; }
        public long StudyModeId { get; set; }
        public byte TypeEnumId { get; set; }
        public long ApplicationStatusId { get; set; }
        public bool IsAgree { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long LastChangedById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Admission_Applicant Admission_Applicant { get; set; }
    }
}
