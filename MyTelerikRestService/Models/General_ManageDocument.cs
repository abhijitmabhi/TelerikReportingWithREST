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
    
    public partial class General_ManageDocument
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FillWhen { get; set; }
        public string UploadDocuments { get; set; }
        public bool Enable { get; set; }
        public long CreatedById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long LastChangedById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public bool IsDeleted { get; set; }
    }
}
