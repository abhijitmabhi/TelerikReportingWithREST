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
    
    public partial class Admission_ApplicantEducation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Admission_ApplicantEducation()
        {
            this.Admission_ApplicantEducationSubject = new HashSet<Admission_ApplicantEducationSubject>();
        }
    
        public long Id { get; set; }
        public byte OrderNo { get; set; }
        public string Name { get; set; }
        public string MajorArea { get; set; }
        public string InstitutionName { get; set; }
        public string Board { get; set; }
        public string Result { get; set; }
        public string Duration { get; set; }
        public int YearOfPassing { get; set; }
        public string Session { get; set; }
        public string Achievement { get; set; }
        public long ApplicantId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreateById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Admission_Applicant Admission_Applicant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admission_ApplicantEducationSubject> Admission_ApplicantEducationSubject { get; set; }
    }
}
