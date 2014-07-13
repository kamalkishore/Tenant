using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantSystem
{
    public static class Utility
    {
       public static string ConnectionString = ConfigurationManager.ConnectionStrings["Tenant"].ToString();
    }
}
