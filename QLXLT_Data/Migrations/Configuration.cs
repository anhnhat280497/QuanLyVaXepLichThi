namespace QLXLT_Data.Migrations
{
    using QLXLT_Data.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QLXLT_Data.Data.XLTContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QLXLT_Data.Data.XLTContext context)
        {
            //  This method will be called after migrating to the latest version.
            DataSeeder.Seed(context);
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
