using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SimplieClinic_DAL_EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Data.Config
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.Id);


            builder
                   .Property(a => a.Id)
                   .IsRequired();

            builder.HasOne(a => a.Patient)
                .WithMany(patient => patient.Appointments)
                .HasForeignKey(a => a.PatientID)
                .IsRequired();

            builder.HasOne(a=>a.Doctor)
                .WithMany(doctor=>doctor.Appointments)
                .HasForeignKey(a=>a.DoctorID)
                .IsRequired();

            builder.Property(a => a.appointDate)
                .HasColumnName("appointDate")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(a => a.appointTime)
                 .HasColumnName("appointTime")
                 .HasColumnType("time(7)")
                 .IsRequired();

            builder.HasOne(a => a.AppointmentStatus)
                .WithMany(appstatus => appstatus.Appointment)
                .HasForeignKey(a=> a.appointStatus)
                .IsRequired();


        }
    }
}
