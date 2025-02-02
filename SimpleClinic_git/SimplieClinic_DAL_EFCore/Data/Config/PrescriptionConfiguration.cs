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
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {
       

        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            
            builder.HasKey(p => p.Id);

            builder.Property(p=> p.Id).IsRequired();

            builder.Property(p => p.MedicalRecordID) // Configure the foreign key property
           .IsRequired();


            builder.HasOne(p => p.MedicalRecord)
                   .WithOne(m => m.Prescription)
                   .HasForeignKey<Prescription>(p => p.MedicalRecordID);

            builder.Property(p=>p.MedicationName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p=> p.Dosage)
                .HasMaxLength (50)
                .IsRequired();

            builder.Property(p=>p.Frequency)
                .IsRequired();

            builder.Property(p=>p.StartDate)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.StartDate)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.SpecialInstructions)
               .HasMaxLength(225);
               
            
        }
    }
}
