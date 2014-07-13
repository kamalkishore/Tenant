using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
    public class BillInvoiceRepository
    {
        public bool Add(BillInvoice billInvoice)
        {
            using (var connection = new SqlConnection(Utility.ConnectionString))
            {
                var cmd = new SqlCommand("INSERT INTO BillInvoice (tenantId, currentMonthPayableAmount, PendingAmount, LastBillPaidAmount, LastBillPaidDate, createdDate) VALUES (@tenantId, @currentMonthPayableAmount, @PendingAmount, @LastBillPaidAmount, @LastBillPaidDate, @createdDate)")
                {
                    CommandType = CommandType.Text,
                    Connection = connection
                };
                cmd.Parameters.AddWithValue("@tenantId", billInvoice.TenantId);
                cmd.Parameters.AddWithValue("@currentMonthPayableAmount", billInvoice.CurrentMonthPayamentAmount);
                cmd.Parameters.AddWithValue("@PendingAmount", billInvoice.PendingAmount);
                cmd.Parameters.AddWithValue("@LastBillPaidAmount", billInvoice.LastBillPaid);
                cmd.Parameters.AddWithValue("@LastBillPaidDate", billInvoice.LastBillPaidDate);
                cmd.Parameters.AddWithValue("@createdDate", billInvoice.CreatedDate);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            return true;

            return true;
        }

        public bool Update(BillPayable billPayable)
        {
            return true;
        }

        public bool Delete(BillPayable billPayable)
        {
            return true;
        }

        public bool Get()
        {
            return true;
        }
    }
}
