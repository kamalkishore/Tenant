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
    
    public partial class Building
    {
        public Building()
        {
            this.Tenants = new HashSet<Tenant>();
        }
    
        public int BuildingId { get; set; }
        public Nullable<int> BuildingName { get; set; }
        public Nullable<int> NumberOfFloor { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual ICollection<Tenant> Tenants { get; set; }
    }
}