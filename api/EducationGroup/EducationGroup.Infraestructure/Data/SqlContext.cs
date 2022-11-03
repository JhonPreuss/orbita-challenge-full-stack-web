using EducationGroup.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EducationGroup.Infraestructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses{ get; set; }

        public override int SaveChanges()
        {
            foreach (var entry  in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RecordDate") != null ))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("RecordDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("RecordDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}
