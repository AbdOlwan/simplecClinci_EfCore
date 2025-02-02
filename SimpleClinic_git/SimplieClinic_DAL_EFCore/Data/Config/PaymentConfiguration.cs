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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.Property(p => p.PaymentDate)
                .HasColumnName("PaymentDate")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.Paymentmethod)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p=> p.AmountPaid)
                .IsRequired();

            builder.Property(p => p.Note)
                .HasMaxLength(50);

            builder.HasOne(p => p.Patient)
                .WithMany(patient => patient.Payments)
                .HasForeignKey(p => p.PatientID);



        }
    }
}
