using System.Data.Entity.ModelConfiguration;
using EFCoreTasks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTasks.Data
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder) {
            builder.Property(b => b.age).IsRequired();
        }
    }
}
