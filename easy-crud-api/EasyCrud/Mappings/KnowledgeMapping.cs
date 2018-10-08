using EasyCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCrud.Mappings
{
    public class KnowledgeMapping
    {
        public KnowledgeMapping(EntityTypeBuilder<Knowledge> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);

            entityBuilder.Property(t => t.Others)
                 .HasColumnType("varchar(300)")
                 .HasMaxLength(300)
                 .IsRequired();

        }
    }
}
