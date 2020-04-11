namespace VehicleFinder.Migrations
{
    using System.Data.Entity.Migrations;
    using VehicleFinder.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VehicleFinder.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VehicleFinder.Data.AppDbContext context)
        {
            context.Extras.AddOrUpdate(new Extra() { Name = "Dashcam" });
            context.Extras.AddOrUpdate(new Extra() { Name = "Heated Seats" });
            context.Extras.AddOrUpdate(new Extra() { Name = "Leather Upholstery" });
            context.Extras.AddOrUpdate(new Extra() { Name = "Navigation" });
            context.Extras.AddOrUpdate(new Extra() { Name = "Panoramic Roof" });
            context.Extras.AddOrUpdate(new Extra() { Name = "Reversing Camera" });
        }
    }
}
