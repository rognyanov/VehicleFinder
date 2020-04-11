using System.Configuration;
using System.Data.Entity;

namespace VehicleFinder.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base(ConfigurationManager.ConnectionStrings["default"].ConnectionString)
        {

        }
    }
}
