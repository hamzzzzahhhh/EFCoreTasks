using EFCoreTasks.Models;
using System;
using Microsoft.EntityFrameworkCore;
using EFCoreTasks.DataRepo;

namespace EFCoreTasks.Data
{
    public class AppDBContext : DbContext 
    {
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Student>Students { get; set; }  

        public DbSet<StudentProjects> StudentProjects { get; set; }

        public DbSet<Employee> employees { get; set; }

        public DbSet<View1> view1 { get; set; }

        public DbSet<RoomInfo> Rooms { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //new StudentConfiguration().Configure(modelBuilder.Entity<Student>());

            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            //new TeacherConfiguration().Configure(modelBuilder.Entity<Teacher>());

            modelBuilder.ApplyConfiguration(new TeacherConfiguration());

            //new AssistantConfuguration().Configure(modelBuilder.Entity<Assistant>());

            modelBuilder.ApplyConfiguration(new AssistantConfiguration());

            //new ProjectConfiguration().Configure(modelBuilder.Entity<Project>());

            modelBuilder.ApplyConfiguration(new ProjectConfiguration());

            modelBuilder.ApplyConfiguration(new StudentsProjectConfiguration());

            modelBuilder.Entity<View1>().ToView(nameof(view1));

            modelBuilder.ApplyConfiguration(new EmployeesConfiguration());

            modelBuilder.Entity<Employee>().HasData(
           new Employee { Id = 1, Name = "Alice" },
           new Employee { Id = 2, Name = "Bob", ManagerID = 1 },
           new Employee { Id = 3, Name = "Charlie", ManagerID = 1 },
           new Employee { Id = 4, Name = "David", ManagerID = 2 }
       );

            base.OnModelCreating(modelBuilder);
        }
    }
}
