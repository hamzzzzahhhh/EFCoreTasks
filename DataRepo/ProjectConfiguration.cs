using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EFCoreTasks.Models;

namespace EFCoreTasks.DataRepo
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public ProjectConfiguration() { }

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(b => b.Id).IsRequired().HasColumnOrder(0);
            builder.Property(b => b.Name).HasColumnOrder(1);
            builder.Property(b => b.Name).HasColumnOrder(2);
            builder.Property(b => b.Description).HasMaxLength(50);
        }
    }
}
