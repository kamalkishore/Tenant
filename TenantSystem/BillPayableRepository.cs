using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
    public class BillPayableRepository
    {
        public bool Add(BillPayable billPayable)
        {
            using (var connection = new SqlConnection(Utility.ConnectionString))
            {
                var cmd = new SqlCommand("INSERT INTO BillPayable (tenantId, unitConsumed, pricePerUnit, amountPayable, createdDate) VALUES (@tenantId, @unitConsumed, @pricePerUnit, @amountPayable, @createdDate)")
                {
                    CommandType = CommandType.Text,
                    Connection = connection
                };
                cmd.Parameters.AddWithValue("@tenantId", billPayable.TenantId);
                cmd.Parameters.AddWithValue("@unitConsumed", billPayable.UnitConsumed);
                cmd.Parameters.AddWithValue("@pricePerUnit", billPayable.PricePerUnit);
                cmd.Parameters.AddWithValue("@amountPayable", billPayable.AmountPayable);
                cmd.Parameters.AddWithValue("@createdDate", billPayable.CreatedDate);
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
