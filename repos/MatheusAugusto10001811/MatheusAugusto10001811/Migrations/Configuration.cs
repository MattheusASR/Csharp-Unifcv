namespace MatheusAugusto10001811.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MatheusAugusto10001811.Models.MatheusAugusto10001811Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MatheusAugusto10001811.Models.MatheusAugusto10001811Context";
        }

        protected override void Seed(MatheusAugusto10001811.Models.MatheusAugusto10001811Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
