using EFCoreTasks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTasks.DataRepo
{
    public class StudentsProjectConfiguration : IEntityTypeConfiguration<StudentProjects>
    {
        public void Configure(EntityTypeBuilder<StudentProjects> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(p => p.Student).WithMany(p => p.StudentProjects).HasForeignKey(p => p.StudentId);
            builder.HasOne(p => p.Project).WithMany(p => p.StudentProjects).HasForeignKey(p => p.ProjectId);
        }
    }
}
