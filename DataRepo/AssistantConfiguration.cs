using Microsoft.EntityFrameworkCore;
using EFCoreTasks.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTasks.DataRepo
{
    public class AssistantConfiguration : IEntityTypeConfiguration<Assistant>
    {
        public AssistantConfiguration() { }

        public void Configure(EntityTypeBuilder<Assistant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(b=>b.status).IsRequired();
            builder.Property(b=>b.Name).IsRequired();
            builder.Property(b=>b.Description).HasMaxLength(100);
        }
    }
}
