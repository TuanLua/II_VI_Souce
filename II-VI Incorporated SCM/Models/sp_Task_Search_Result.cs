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
    
    public partial class sp_Task_Search_Result
    {
        public string Topic { get; set; }
        public string TYPE { get; set; }
        public int IDTask { get; set; }
        public Nullable<int> TopicID { get; set; }
        public string TASKNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string OWNER { get; set; }
        public string ASSIGNEE { get; set; }
        public string APPROVE { get; set; }
        public Nullable<System.DateTime> EstimateStartDate { get; set; }
        public Nullable<System.DateTime> EstimateEndDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public Nullable<int> PROCESS { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string STATUS { get; set; }
        public string PRIORITY { get; set; }
        public Nullable<int> Level { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
    }
}
