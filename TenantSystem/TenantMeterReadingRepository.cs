using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
    public class TenantMeterReadingRepository
    {
        public bool Add(TenantMeterReading tenantMeterReading)
        {
            using (var connection = new SqlConnection(Utility.ConnectionString))
            {
                var cmd = new SqlCommand("INSERT INTO TenantMeterReading (tenantId, meterReading, createdDate) VALUES (@tenantId,@meterReading, @createdDate)")
                    {
                        CommandType = CommandType.Text,
                        Connection = connection
                    };
                cmd.Parameters.AddWithValue("@tenantId", tenantMeterReading.TenantId);
                cmd.Parameters.AddWithValue("@meterReading", tenantMeterReading.MeterReading);
                cmd.Parameters.AddWithValue("@createdDate", tenantMeterReading.CreatedDate);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            return true;
        }

        public bool Update(TenantMeterReading tenantMeterReading)
        {
            return true;
        }

        public bool Delete(TenantMeterReading tenantMeterReading)
        {
            return true;
        }

        public int GetPreviousMonthMeterReading(int tenantId)
        {

            int res = 0;
            using (SqlConnection conn = new SqlConnection(Utility.ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("dbo.GetLastMeterReading", conn))
                {
                    comm.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@tenantId", SqlDbType.Int);
                    p1.Direction = ParameterDirection.Input;
                    // You can call the return value parameter anything, .e.g. "@Result".
                    SqlParameter p2 = new SqlParameter("@lastMeterReading", SqlDbType.Bit);

                    
                    p2.Direction = ParameterDirection.ReturnValue;

                    p1.Value = tenantId;

                    comm.Parameters.Add(p1);
                    comm.Parameters.Add(p2);

                    conn.Open();
                    comm.ExecuteNonQuery();

                    if (p2.Value != DBNull.Value)
                        res = (int)p2.Value;
                }
            }
            return res;


            //TenantMeterReading temp;
            //using (var connection = new SqlConnection(Utility.ConnectionString))
            //{
            //    var cmd = new SqlCommand("Select top 1 * from TenantMeterReading where tenantid = @tid order by tenantid desc")
            //    {
            //        CommandType = CommandType.Text,
            //        Connection = connection
            //    };
            //    cmd.Parameters.AddWithValue("@tId", tenantId);
            //    //onnection.Open();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataSet dataSet = new DataSet();
            //    da.Fill(dataSet);
            //    temp = GetPreviousMonthMeterReading(dataSet);
            //}

            //return (temp==null) ? 0 : temp.MeterReading;
        }

        //private TenantMeterReading GetPreviousMonthMeterReading(DataSet ds)
        //{
        //    return (from DataRow row in ds.Tables[0].Rows
        //            select new TenantMeterReading()
        //                {
        //                    Id = Convert.ToInt32(row["id"]), 
        //                    TenantId = Convert.ToInt32(row["TenantId"]), 
        //                    MeterReading = Convert.ToInt32(row["MeterReading"])
        //                }).FirstOrDefault() ?? null;
        //}
    }
}
