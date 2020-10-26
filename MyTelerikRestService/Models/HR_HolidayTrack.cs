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
    
    public partial class HR_HolidayTrack
    {
        public long Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public byte TypeEnumId { get; set; }
        public Nullable<System.DateTime> WorkStartTime { get; set; }
        public Nullable<System.DateTime> WorkEndTime { get; set; }
        public bool IsMakeup { get; set; }
        public Nullable<System.DateTime> MakeUpForDate { get; set; }
        public long HolidayCalendarId { get; set; }
        public string Remarks { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreateById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual HR_HolidayCalendar HR_HolidayCalendar { get; set; }
    }
}
