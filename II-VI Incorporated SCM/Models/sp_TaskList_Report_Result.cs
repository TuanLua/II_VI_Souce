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
    
    public partial class sp_TaskList_Report_Result
    {
        public string Department { get; set; }
        public string TASKNAME { get; set; }
        public int IDTask { get; set; }
        public string Topic { get; set; }
        public string TYPE { get; set; }
        public Nullable<System.DateTime> EstimateEndDate { get; set; }
        public string STATUS { get; set; }
        public Nullable<int> Aging { get; set; }
    }
}