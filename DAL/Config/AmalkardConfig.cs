using VamBlazor.Client.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Config
{
    internal class AmalkardConfig : IEntityTypeConfiguration<Amalkard>
    {
        public void Configure(EntityTypeBuilder<Amalkard> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AMALKARD");

            builder.Property(e => e.Date)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("date");
            builder.Property(e => e.Mandeh)
                .HasColumnType("numeric(19, 0)")
                .HasColumnName("mandeh");
        }
    }

}
