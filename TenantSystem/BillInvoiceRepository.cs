using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TenantSystem
{
    public class BillInvoiceRepository
    {
        public bool Add(BillInvoice billInvoice)
        {
            using (var connection = new SqlConnection(Utility.ConnectionString))
            {
                var cmd =
                    new SqlCommand(
                        "INSERT INTO BillInvoice (tenantId, curentMonthPayableAmount, PendingAmount, LastBillPaidAmount, LastBillPaidDate, createdDate) VALUES (@tenantId, @currentMonthPayableAmount, @PendingAmount, @LastBillPaidAmount, @LastBillPaidDate, @createdDate)")
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

        public DataTable GetInvoiceDetails(int tenantId)
        {
            DataTable dt;
            //BillInvoice billInvoice;
            using (var connection = new SqlConnection(Utility.ConnectionString))
            {
                var cmd = new SqlCommand("Select * from TenantElectricityInvoice where tenantid = @tid")
                    {
                        CommandType = CommandType.Text,
                        Connection = connection
                    };
                cmd.Parameters.AddWithValue("@tId", tenantId);
                //onnection.Open();.
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                dt = dataSet.Tables[0];
                //billInvoice = GetMostRecentInvoice(dataSet);
            }

            return dt;
        }


        private BillInvoice GetMostRecentInvoice(DataSet ds)
        {
            return (from DataRow row in ds.Tables[0].Rows
                    select new BillInvoice()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            TenantId = Convert.ToInt32(row["TenantId"]),
                            CurrentMonthPayamentAmount = Convert.ToInt32(row["CurentMonthPayableAmount"]),
                            LastBillPaid = Convert.ToDouble(row["LastBillPaidAmount"]),
                            PendingAmount = Convert.ToDouble(row["PendingAmount"]),
                            LastBillPaidDate = Convert.ToDateTime(row["LastBillPaidDate"])
                        }).FirstOrDefault();
        }
    }
}
