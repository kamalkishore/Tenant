//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TenantBillReport
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillInvoice
    {
        public int Id { get; set; }
        public Nullable<int> TenantId { get; set; }
        public Nullable<int> CurentMonthPayableAmount { get; set; }
        public Nullable<int> PendingAmount { get; set; }
        public Nullable<int> LastBillPaidAmount { get; set; }
        public Nullable<System.DateTime> LastBillPaidDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual Tenant Tenant { get; set; }
    }
}
