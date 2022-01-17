using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class WepAppProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"server=DESKTOP-U9N2A0J;Database=WepApplicationProject;Trusted_Connection=true");
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<LaboratuarSira> LaboratuarSiras { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
    }
}