using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
    public class BillPaymentRepository
    {
        public bool Add(BillPayment billPayment)
        {
            using (var connection = new SqlConnection(Utility.connectionString))
            {
                var cmd = new SqlCommand("INSERT INTO BillPayment (tenantId, paymentDate, amountPaid, createdDate) VALUES (@tenantId, @paymentDate, @amountPaid, @createdDate)")
                {
                    CommandType = CommandType.Text,
                    Connection = connection
                };
                cmd.Parameters.AddWithValue("@tenantId", billPayment.TenantId);
                cmd.Parameters.AddWithValue("@paymentDate", billPayment.PaymentDate);
                cmd.Parameters.AddWithValue("@amountPaid", billPayment.AmountPaid);
                cmd.Parameters.AddWithValue("@createdDate", billPayment.CreatedDate);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
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

        public BillPayment GetLastBillPaid(int tenantId)
        {
            BillPayment billPayment;
            using (var connection = new SqlConnection(Utility.connectionString))
            {
                var cmd = new SqlCommand("Select top 1 * from BillPayment where tenantid = @tid order by id desc")
                {
                    CommandType = CommandType.Text,
                    Connection = connection
                };
                cmd.Parameters.AddWithValue("@tId", tenantId);
                //onnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                billPayment = GetPreviousMonthMeterReading(dataSet);
            }

            return billPayment;
        }

        private BillPayment GetPreviousMonthMeterReading(DataSet ds)
        {
            return (from DataRow row in ds.Tables[0].Rows
                    select new BillPayment()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        TenantId = Convert.ToInt32(row["TenantId"]),
                        AmountPaid = Convert.ToInt32(row["AmountPaid"]),
                        PaymentDate = Convert.ToDateTime(row["PaymentDate"])
                    }).FirstOrDefault() ?? null;
        }
    }
}
