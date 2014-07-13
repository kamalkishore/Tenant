using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
    public class DataBaseConnection
    {
        readonly string _conString = ConfigurationManager.ConnectionStrings["Tenant"].ToString();
        /// <summary>
        /// Add the tenant
        /// </summary>
        /// <param name="tenant"></param>
        public bool AddTenant(Tenant tenant)
        {
            //add tenant

            using (var connection = new SqlConnection(_conString))
            {
                var cmd = new SqlCommand("INSERT INTO TenantDetails (FirstName,Lastname, PhoneNumber) VALUES (@fName,@lName, @PhoneNo)")
                {
                    CommandType = CommandType.Text,
                    Connection = connection
                };
                cmd.Parameters.AddWithValue("@fName", tenant.FirstName);
                cmd.Parameters.AddWithValue("@lName", tenant.LastName);
                cmd.Parameters.AddWithValue("@PhoneNo", tenant.PhoneNumber);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            return true;
        }


        /// <summary>
        /// Update the tenant
        /// </summary>
        /// <param name="tenant"></param>
        public bool Update(Tenant tenant)
        {
            //add tenant
            return true;
        }

        /// <summary>
        /// Delete the tenant
        /// </summary>
        /// <param name="tenant"></param>
        public bool Delete(Tenant tenant)
        {
            //add tenant
            return true;
        }

        public Tenant GetTenant()
        {
            return null;
        }
    }
}
