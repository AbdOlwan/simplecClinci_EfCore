using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplieClinic_DAL_EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Data.Config
{
    public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.HasKey(m=>m.ID);

            builder.Property(m => m.ID).IsRequired();

            builder.HasOne(m => m.Patient)
                .WithMany(patient => patient.MedicalRecords)
                .HasForeignKey(m => m.PatientID)
                .IsRequired();

            builder.HasOne(m => m.Doctor)
             .WithMany(doctor => doctor.MedicalRecords)
             .HasForeignKey(m => m.DoctorID)
             .IsRequired();

            builder.Property(m=>m.VisitDate)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(m => m.Description)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(m=>m.Diagnosis)
                .HasMaxLength (50)
                .IsRequired();

            builder.Property(m => m.Notes)
                .HasMaxLength(50);

        }
    }
}
