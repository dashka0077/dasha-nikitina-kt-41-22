using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DashaNikitinaKt_41_22.Models;

public class WorkloadConfiguration : IEntityTypeConfiguration<Workload>
{
    public void Configure(EntityTypeBuilder<Workload> builder)
    {
        builder.ToTable("Workloads");
        builder.HasKey(w => w.Id);

        builder.Property(w => w.Hours).IsRequired();

        // Связь "многие-к-одному" с преподавателями
        builder.HasOne(w => w.Teacher)
               .WithMany(t => t.Workloads)
               .HasForeignKey(w => w.TeacherId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}