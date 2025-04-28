using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DashaNikitinaKt_41_22.Models;

public class AcademicDegreeConfiguration : IEntityTypeConfiguration<AcademicDegree>
{
    public void Configure(EntityTypeBuilder<AcademicDegree> builder)
    {
        builder.ToTable("AcademicDegrees");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
    }
}