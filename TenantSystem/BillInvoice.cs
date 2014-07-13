using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
    public class BillInvoice
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public double CurrentMonthPayamentAmount { get; set; }
        public double PendingAmount { get; set; }
        public double LastBillPaid { get; set; }
        public DateTime LastBillPaidDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
