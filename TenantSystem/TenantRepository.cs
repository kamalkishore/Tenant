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
    public class TenantRepository
    {
        public static List<Tenant> TenantList;

       

        public TenantRepository()
        {
            TenantList = new List<Tenant>();
        }

        /// <summary>
        /// Add the tenant
        /// </summary>
        /// <param name="tenant"></param>
        public bool Add(Tenant tenant)
        {
            //add tenant
            //var dataBaseConnection = new DataBaseConnection();
            //dataBaseConnection.AddTenant(tenant);

            using (var connection = new SqlConnection(Utility.ConnectionString))
            {
                var cmd = new SqlCommand("INSERT INTO Tenant (FirstName,Lastname, PhoneNumber) VALUES (@fName,@lName, @PhoneNo)")
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

        public List<Tenant> GetAllTenant()
        {
            using (var connection = new SqlConnection(Utility.ConnectionString))
            {
                var cmd = new SqlCommand("Select * from Tenant order by tenantid desc")
                {
                    CommandType = CommandType.Text,
                    Connection = connection
                };
                //onnection.Open();
                var da = new SqlDataAdapter(cmd);
                var dataSet = new DataSet();
                da.Fill(dataSet);
                return GetTenants(dataSet);
            }
        }

        private List<Tenant> GetTenants(DataSet ds)
        {
            TenantList.Clear();
            foreach (var t in from DataRow row in ds.Tables[0].Rows select new Tenant
                {
                    Id = Convert.ToInt32(row["TenantId"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString()
                })
            {
                TenantList.Add(t);
            }
            return TenantList;
        }
        public Tenant GetTenant(int tenantId)
        {
            using (var connection = new SqlConnection(Utility.ConnectionString))
            {
                var cmd = new SqlCommand("Select * from TenantDetails where TenantId = @id")
                {
                    CommandType = CommandType.Text,
                    Connection = connection
                };
                cmd.Parameters.Add("@id", tenantId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            return null;
        }
    }
}
