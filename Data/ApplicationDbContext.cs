using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;
using Assessment2.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Assessment2.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{


    // Properties of ApplicationDbContext to reference our Model classes.
    public DbSet<Appointment>? Appointments { get; set; }
    public DbSet<Availability>? Availabilities { get; set; }
    public DbSet<HistoryDates>? HistoryDates { get; set; }
    public DbSet<Patient>? Patients { get; set; }
    public DbSet<Doctor>? Doctors { get; set; }
    public DbSet<Administrator>? Administrators { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        HistoryDateSeeders.Seed(modelBuilder);
        PatientSeeders.Seed(modelBuilder);

        modelBuilder.Entity<Doctor>()
            .HasIndex(g => g.Email)
            .IsUnique();

        modelBuilder.Entity<Administrator>()
            .HasIndex(e => e.Email)
            .IsUnique();
    }

}
