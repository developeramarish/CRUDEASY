using EasyCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCrud.Mappings
{
    public class CandidateMapping
    {
        public CandidateMapping(EntityTypeBuilder<Candidate> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);

            entityBuilder.Property(t => t.Name)
                .HasColumnType("varchar(200)")
                .HasMaxLength(200)
                .IsRequired();

            entityBuilder.Property(t => t.Account)
               .HasColumnType("varchar(200)")
               .HasMaxLength(200)
               .IsRequired();

            entityBuilder.Property(t => t.BankName)
               .HasColumnType("varchar(200)")
               .HasMaxLength(200)
               .IsRequired();

            entityBuilder.Property(t => t.Cellphone)
              .HasColumnType("varchar(20)")
              .HasMaxLength(20)
              .IsRequired();

            entityBuilder.Property(t => t.CPFRecipient)
              .HasColumnType("varchar(13)")
              .HasMaxLength(13)
              .IsRequired();

            entityBuilder.Property(t => t.Email)
              .HasColumnType("varchar(25)")
              .HasMaxLength(25)
              .IsRequired();

            entityBuilder.Property(t => t.LinkedinAddress)
              .HasColumnType("varchar(200)")
              .HasMaxLength(200)
              .IsRequired();

            entityBuilder.Property(t => t.Portfolio)
             .HasColumnType("varchar(200)")
             .HasMaxLength(200)
             .IsRequired();

            entityBuilder.Property(t => t.State)
             .HasColumnType("varchar(100)")
             .HasMaxLength(100)
             .IsRequired();

            entityBuilder.Property(t => t.Recipient)
             .HasColumnType("varchar(200)")
             .HasMaxLength(200)
             .IsRequired();

            entityBuilder.Property(t => t.Agency)
             .HasColumnType("varchar(10)")
             .HasMaxLength(10)
             .IsRequired();

            entityBuilder.Property(t => t.City)
             .HasColumnType("varchar(30)")
             .HasMaxLength(30)
             .IsRequired();

            entityBuilder.Property(t => t.Cellphone)
             .HasColumnType("varchar(15)")
             .HasMaxLength(15)
             .IsRequired();
        }
    }
}
