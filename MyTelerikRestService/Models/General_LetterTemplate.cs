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
    
    public partial class General_LetterTemplate
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string LetterContent { get; set; }
        public string SignatureFile { get; set; }
        public string TextAfterSignature { get; set; }
        public string Footer { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreateById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
    }
}
