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
    
    public partial class tbl_SQE_SupplierLog
    {
        public string Supplier_Code { get; set; }
        public string Supplier_Name { get; set; }
        public string Status { get; set; }
        public string Material_Supplied { get; set; }
        public string Other_Supplied { get; set; }
        public Nullable<bool> Strategic { get; set; }
        public string Business_type { get; set; }
        public string Other_Type { get; set; }
        public string Commodity { get; set; }
        public string Other_Commodity { get; set; }
        public string Address { get; set; }
        public Nullable<bool> Survey_Require { get; set; }
        public Nullable<System.DateTime> Survey_Date { get; set; }
        public Nullable<double> Servey_Score { get; set; }
        public Nullable<byte> Supplier_Level { get; set; }
        public Nullable<System.DateTime> Approval_Date { get; set; }
        public Nullable<System.DateTime> Re_Examined { get; set; }
        public Nullable<System.DateTime> Re_Evaluation { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public string Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_At { get; set; }
    }
}
