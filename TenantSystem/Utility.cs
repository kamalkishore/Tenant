using System.Configuration;

namespace TenantSystem
{
    public static class Utility
    {
       public static string ConnectionString = ConfigurationManager.ConnectionStrings["Tenant"].ToString();
    }
}
