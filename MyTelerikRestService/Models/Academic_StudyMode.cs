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
    
    public partial class Academic_StudyMode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Academic_StudyMode()
        {
            this.Academic_StudyIntake = new HashSet<Academic_StudyIntake>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long LastChangedById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Academic_StudyIntake> Academic_StudyIntake { get; set; }
    }
}