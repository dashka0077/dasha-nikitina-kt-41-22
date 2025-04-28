using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DashaNikitinaKt_41_22.Models;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Departments");
        builder.HasKey(d => d.Id);

        builder.Property(d => d.Name).IsRequired().HasMaxLength(100);

        // Связь "один-к-одному" с заведующим кафедрой
        builder.HasOne(d => d.HeadOfDepartment)
               .WithMany()
               .HasForeignKey(d => d.HeadOfDepartmentId)
               .OnDelete(DeleteBehavior.Restrict); // Запрет удаления заведующего, если он связан с кафедрой
    }
}