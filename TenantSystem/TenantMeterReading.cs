using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
     public class TenantMeterReading
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int MeterReading { get; set; }
        public DateTime DateOfMeterReading { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
