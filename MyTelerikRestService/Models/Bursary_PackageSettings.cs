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
    
    public partial class Bursary_PackageSettings
    {
        public long Id { get; set; }
        public string PackageCode { get; set; }
        public string PackageDescription { get; set; }
        public System.DateTime Validity { get; set; }
        public string PaymentDueIn { get; set; }
        public string StudentType { get; set; }
        public bool Status { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long LastChangedById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public bool IsDeleted { get; set; }
    }
}
