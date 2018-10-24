namespace Example.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Example.Infrastructure.persistence.entityFramework.CarContext>
    {
        public Configuration()
        {
            //Mapea la entidad y agrega automaticamente las columnas a la base de datos
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Example.Infrastructure.persistence.entityFramework.CarContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
