using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2908CodeToDb
{
    public class DepartmentContext:DbContext
    {
        public DbSet<Dapartment> Departments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dapartment>().Property(u=>u.Name).HasColumnName("DeptName");
        }
    }
}
