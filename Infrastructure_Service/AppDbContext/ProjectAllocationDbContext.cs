using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure_Service.AppDbContext
{
    public class ProjectAllocationDbContext : DBcontext
    {
     public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectRequest> ProjectRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=project_allocation.db");
        }



    }
}
