using Hospital_Appointment_Management_System.Models.Entities;
using Microsoft.EntityFrameworkCore;

public class HospitalDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Schedule> Schedules { get; set; }

    public HospitalDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Role>().ToTable("Roles");
        modelBuilder.Entity<Appointment>().ToTable("Appointments");
        modelBuilder.Entity<Doctor>().ToTable("Doctors");
        modelBuilder.Entity<Schedule>().ToTable("Schedules");

        modelBuilder.Entity<User>()
    .HasOne(u => u.Doctor)
    .WithOne()
  //  .WithOne(d => d.User) 
    .HasForeignKey<User>(u => u.DoctorId)
    .OnDelete(DeleteBehavior.SetNull);


        modelBuilder.Entity<User>()
       .HasOne(u => u.Role)
       .WithMany(r => r.Users)
       .HasForeignKey(u => u.RoleId)
       .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Appointment>()
         .HasOne(a => a.Patient)
         .WithMany(u => u.Appointments)
         .HasForeignKey(a => a.PatientId)
         .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Appointment>()
             .HasOne(a => a.Doctor)
             .WithMany(d => d.Appointments)
             .HasForeignKey(a => a.DoctorId)
             .OnDelete(DeleteBehavior.Restrict);
      

     
        modelBuilder.Entity<Schedule>()
    .HasOne(s => s.Doctor)
    .WithMany(d => d.Schedules)
    .HasForeignKey(s => s.DoctorId)
    .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1,Name = "Admin" },
            new Role { Id = 2,Name = "Doctor" },
            new Role { Id = 3,Name = "Patient" }


        );
    }
}
