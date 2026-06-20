using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternJob.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternJob.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<CandidateProfile> CandidateProfiles => Set<CandidateProfile>();
    public DbSet<EmployerProfile> EmployerProfiles => Set<EmployerProfile>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User
        modelBuilder.Entity<User>(e =>
        {
            e.HasKey(u => u.UserId);
            e.Property(u => u.Email).HasMaxLength(150).IsRequired();
            e.HasIndex(u => u.Email).IsUnique();
            e.Property(u => u.PasswordHash).HasMaxLength(255).IsRequired();
            e.Property(u => u.Role).HasMaxLength(20).IsRequired();
            e.Property(u => u.FullName).HasMaxLength(100).IsRequired();
            e.Property(u => u.Phone).HasMaxLength(15);
        });

        // CandidateProfile
        modelBuilder.Entity<CandidateProfile>(e =>
        {
            e.HasKey(c => c.CandidateId);
            e.HasOne(c => c.User)
             .WithOne(u => u.CandidateProfile)
             .HasForeignKey<CandidateProfile>(c => c.UserId);
        });

        // EmployerProfile
        modelBuilder.Entity<EmployerProfile>(e =>
        {
            e.HasKey(ep => ep.EmployerId);
            e.Property(ep => ep.CompanyName).HasMaxLength(200).IsRequired();
            e.HasOne(ep => ep.User)
             .WithOne(u => u.EmployerProfile)
             .HasForeignKey<EmployerProfile>(ep => ep.UserId);
        });
    }
}