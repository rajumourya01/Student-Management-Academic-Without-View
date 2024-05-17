using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCWithEFCF8.Migrations;

namespace MVCWithEFCF8.Models
{
    public class SchoolDbContext : DbContext

    {
        public SchoolDbContext():base("ConStr")
            {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolDbContext,Configuration>());

            }
        public DbSet<Student> Students { get; set; }

    }
}