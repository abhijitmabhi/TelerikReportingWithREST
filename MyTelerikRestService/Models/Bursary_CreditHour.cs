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
    
    public partial class Bursary_CreditHour
    {
        public long Id { get; set; }
        public string LevelOfStudy { get; set; }
        public int Amount { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string Remarks { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long LastChangedById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public bool IsDeleted { get; set; }
    }
}