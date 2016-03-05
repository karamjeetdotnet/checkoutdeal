using CheckoutDealDAL.Entities;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutDealDAL.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DealContext: DbContext
    {
        public DealContext() :  base()
        {

        }

        public DealContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolDBContext, SchoolDataLayer.Migrations.Configuration>("SchoolDBConnectionString"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().MapToStoredProcedures();
        }
        public DbSet<User> Users { get; set; }
    }
    public class DealMigration : DbMigration
    {

        public override void Up()
        {
            throw new NotImplementedException();
        }
    }
    public class Deal1Migration : EntityTypeConfiguration<DealContext>
    {

    }
    internal sealed class Configuration : DbMigrationsConfiguration<DealContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DealContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
