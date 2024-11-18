using System;
using System.Configuration;
namespace DVLD_DataAccess
{
    static class clsDataAccessSettings
    {
      static  string connectionString = ConfigurationManager.ConnectionStrings["LicenseDb"].ConnectionString;
        public static string ConnectionString = connectionString;



    }
}
