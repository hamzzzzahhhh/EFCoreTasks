using EFCoreTasks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTasks.Data
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasMany(i => i.students).WithOne(i => i.teacher).HasForeignKey("teacher_id");
            builder.HasOne(i => i.assistant).WithOne(i => i.teacher).HasForeignKey<Assistant>(i => i.teacherId);
            builder.Property(b => b.teacherId).IsRequired();
            builder.Property(b => b.teacherName).HasMaxLength(128);
            builder.Property(b => b.teacherDescription).HasMaxLength(128);
        }
    }
}
