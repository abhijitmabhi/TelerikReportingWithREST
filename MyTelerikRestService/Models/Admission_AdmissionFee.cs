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
    
    public partial class Admission_AdmissionFee
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FeeType { get; set; }
        public string ProgrammeId { get; set; }
        public string IntakeId { get; set; }
        public string PaymentDueIn { get; set; }
        public string TypeOfFee { get; set; }
        public int LocalStudent { get; set; }
        public int InternationalStudent { get; set; }
        public bool WithTax { get; set; }
        public string Remarks { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long LastChangedById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public bool IsDeleted { get; set; }
    }
}
