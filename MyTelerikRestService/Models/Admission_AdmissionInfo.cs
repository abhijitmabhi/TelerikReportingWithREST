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
    
    public partial class Admission_AdmissionInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Admission_AdmissionInfo()
        {
            this.General_PersonnelQuestion = new HashSet<General_PersonnelQuestion>();
        }
    
        public long Id { get; set; }
        public string LevelOfStudy { get; set; }
        public string MainTab { get; set; }
        public long PersonnelQuestionId { get; set; }
        public string AdditionalDoc { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreateById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
        public long ApplicantId { get; set; }
    
        public virtual Admission_Applicant Admission_Applicant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<General_PersonnelQuestion> General_PersonnelQuestion { get; set; }
    }
}
