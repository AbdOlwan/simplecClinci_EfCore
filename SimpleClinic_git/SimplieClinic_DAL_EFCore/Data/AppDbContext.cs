using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimplieClinic_DAL_EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Data
{
    public class AppDbContext:DbContext
    {
        DbSet<Patient> Patients {  get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<Appointment> Appointments { get; set; }
        DbSet<Prescription> Prescriptions { get; set; }
        DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        DbSet<MedicalRecord> MedicalRecords { get; set; }   
        DbSet<Payment> Payments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            //modelBuilder.Ignore<Doctor>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var constr = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
        }
    }
}
