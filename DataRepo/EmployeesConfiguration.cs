using EFCoreTasks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTasks.DataRepo
{
    public class EmployeesConfiguration : IEntityTypeConfiguration<Employee> 
    {
        public EmployeesConfiguration() { }

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasOne(e=>e.Manager).WithMany(e=>e.subordinates).HasForeignKey(e=>e.ManagerID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
