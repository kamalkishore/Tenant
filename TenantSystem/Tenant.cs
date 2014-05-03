using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
    public class Tenant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public void Save(string conString)
        {
            //SqlConnection con = new SqlConnection(conString);
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TenantDetails (FirstName,Lastname, PhoneNumber) VALUES (@fName,@lName, @PhoneNo)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@fName", FirstName);
                cmd.Parameters.AddWithValue("@lName", LastName);
                cmd.Parameters.AddWithValue("@PhoneNo", PhoneNumber);
                //cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
