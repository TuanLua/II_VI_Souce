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
    
    public partial class tbl_RP_Advance_Setting
    {
        public long ID { get; set; }
        public long Report_ID { get; set; }
        public long DataSource_ID { get; set; }
        public string Header_Type { get; set; }
        public string Show_Header { get; set; }
        public string Bar_Direct { get; set; }
        public string Enable_Export { get; set; }
        public string File_Name { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public string Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_At { get; set; }
    }
}