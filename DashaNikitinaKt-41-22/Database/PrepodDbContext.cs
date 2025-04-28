using Microsoft.EntityFrameworkCore;
using DashaNikitinaKt_41_22.Models;

namespace DashaNikitinaKt_41_22.Database;

public class PrepodDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
    public DbSet<AcademicDegree> AcademicDegrees { get; set; } = null!;
    public DbSet<Position> Positions { get; set; } = null!;
    public DbSet<Discipline> Disciplines { get; set; } = null!;
    public DbSet<Workload> Workloads { get; set; } = null!;

    public PrepodDbContext(DbContextOptions<PrepodDbContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PrepodDbContext).Assembly);
    }
}