using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqliteCodeFirst.Data
{
    public class MyDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            var model = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            _ = sqlGenerator.Generate(model.StoreModel);
        }


        public DbSet<Tables.Employee> Employees { get; set; }
        public DbSet<Tables.Detail> Details { get; set; }
        public DbSet<Tables.WorkHours> WorkHours { get; set; }
        public DbSet<Tables.SaledDetail> SaledDetails { get; set; }
        public DbSet<Tables.Client> Clients { get; set; }
        public DbSet<Tables.Vehicle> Vehicles { get; set; }





        // public DbSet<Tables.Role> Roles { get; set; }
        //public DbSet<Tables.Order> Orders { get; set; }
    }
}