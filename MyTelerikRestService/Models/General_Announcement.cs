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
    
    public partial class General_Announcement
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public System.DateTime StartDateAnnouncement { get; set; }
        public System.DateTime EndDateAnnouncement { get; set; }
        public System.DateTime StartDatePublish { get; set; }
        public System.DateTime EndDatePublish { get; set; }
        public bool IsActive { get; set; }
        public string RoleId { get; set; }
        public int NumberOfUser { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long LastChangedById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public bool IsDeleted { get; set; }
    }
}