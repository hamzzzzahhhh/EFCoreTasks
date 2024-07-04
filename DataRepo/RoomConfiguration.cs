using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EFCoreTasks.Models;

namespace EFCoreTasks.DataRepo
{
    public class RoomConfiguration : IEntityTypeConfiguration<RoomInfo>
    {
        public RoomConfiguration() { }

        public void Configure(EntityTypeBuilder<RoomInfo> builder)
        {
            //builder.HasOne(e => e.Student).WithOne(e => e.room).HasForeignKey<RoomInfo>(e => e.StudentId);
        }
    }
}
