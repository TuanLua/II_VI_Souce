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
    
    public partial class ChangeItem
    {
        public string CRID { get; set; }
        public string UserSubmit { get; set; }
        public string Brief { get; set; }
        public Nullable<System.DateTime> DateSubmit { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string CRPriority { get; set; }
        public string Reason { get; set; }
        public string Comment { get; set; }
        public string Attachment { get; set; }
        public string MRBChairmanID { get; set; }
        public Nullable<System.DateTime> ChairmanConfirmDate { get; set; }
        public string MRBWHID { get; set; }
        public Nullable<System.DateTime> MRBWHConfirmDate { get; set; }
        public string ChairmanComment { get; set; }
        public string OtherArtifactsImpacted { get; set; }
        public string CRType { get; set; }
        public string RefNumber { get; set; }
        public string CRStatus { get; set; }
    }
}
