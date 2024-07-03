using EFCoreTasks.Models;
using System;
using Microsoft.EntityFrameworkCore;
using EFCoreTasks.DataRepo;

namespace EFCoreTasks.Data
{
    public class AppDBContext : DbContext 
    {
        DbSet<Teacher> Teachers { get; set; }

        DbSet<Project> Projects { get; set; }

        DbSet<Assistant> Assistants { get; set; }
        DbSet<Student>Students { get; set; }  

        DbSet<StudentProjects> StudentProjects { get; set; }

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
        }
    }
}
