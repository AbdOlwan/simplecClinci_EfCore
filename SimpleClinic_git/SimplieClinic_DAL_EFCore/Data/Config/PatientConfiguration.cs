using Microsoft.EntityFrameworkCore;
using SimplieClinic_DAL_EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplieClinic_DAL_EFCore.Data.Config
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {


        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(d => d.Id)
                .IsRequired();

            builder.Property(d => d.Name)
                .HasMaxLength(50)
                       .IsRequired();

            builder.Property(d => d.DateOfBirth)
                  .HasColumnName("DateOfBirth")
                  .HasColumnType("date");

            builder.Property(d => d.Gendor)
                 .HasMaxLength(1)
                 .IsRequired();


            builder.Property(d => d.Phone)
                 .HasMaxLength(10)
                 .IsRequired();

            builder.Property(d => d.Email)
                 .HasMaxLength(50)
                 .IsRequired();

            builder.Property(d => d.Address)
                 .HasMaxLength(50);

            


        }
    }
}
