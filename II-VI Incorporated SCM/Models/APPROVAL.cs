//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace II_VI_Incorporated_SCM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class APPROVAL
    {
        public int ID { get; set; }
        public string NCR_NUMBER { get; set; }
        public string QUALITY { get; set; }
        public string ENGIEERING { get; set; }
        public string MFG { get; set; }
        public string PURCHASING { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string Comment { get; set; }
    }
}
