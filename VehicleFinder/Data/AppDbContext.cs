namespace VehicleFinder.Data
{
    using System.Configuration;
    using System.Data.Entity;
    using VehicleFinder.Models;

    public sealed class AppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Extra> Extra { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        public AppDbContext()
            : base(ConfigurationManager.ConnectionStrings["default"].ConnectionString)
        {

        }
    }
}
