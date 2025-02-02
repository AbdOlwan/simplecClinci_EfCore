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

    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
         builder.HasKey(x => x.Id);
            

         builder
                .Property(d => d.Id)
                .IsRequired();

         builder.Property(d => d.Name)
                .HasColumnName("Name")
                 .HasColumnType("nvarchar(50)")
                 .IsRequired();

        builder.Property(d => d.DateOfBirth)
                .HasColumnName("DateOfBirth")
                 .HasColumnType("date");

        builder.Property(d=>d.Gendor)
                .HasColumnName("Gendor")
                .HasColumnType("char(1)")
                .IsRequired();


        builder.Property(d => d.Phone)
                .HasColumnName("Phone")
                .HasColumnType("nchar(10)")
                .IsRequired();

        builder.Property(d => d.Email)
                 .HasColumnName("Email")
                 .HasColumnType("nchar(50)")
                 .IsRequired();

         builder.Property(d => d.Address)
                 .HasColumnName("Address")
                 .HasColumnType("nchar(50)");

         builder.Property(d => d.specialization)
                  .HasColumnName("specialization")
                  .HasColumnType("nchar(50)")
                  .IsRequired();
        }
    }
}
