using VamBlazor.Client.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    internal class DargstConfig : IEntityTypeConfiguration<Dargst>
    {
        public void Configure(EntityTypeBuilder<Dargst> builder)
        {
            builder.HasKey(e => new { e.ReqNo, e.GstNo });
            builder.ToTable("DARGST", tb => tb.HasTrigger("DargstTriger"));

            builder.Property(e => e.ReqNo).HasColumnName("req_no");
            builder.Property(e => e.GstNo).HasColumnName("gst_no");
            builder.Property(e => e.DateG)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(space((1)))")
                .IsFixedLength()
                .HasColumnName("date_g");
            builder.Property(e => e.DateP)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(space((1)))")
                .IsFixedLength()
                .HasColumnName("date_p");
            builder.Property(e => e.Gstmblg)
                .HasDefaultValue(0L)
                .HasColumnName("gstmblg");
            builder.Property(e => e.Pasandaz)
                .HasDefaultValue(0L)
                .HasColumnName("pasandaz");
            builder.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(space((1)))")
                .IsFixedLength()
                .HasColumnName("status");

            builder.HasOne(d => d.ReqNoNavigation).WithMany(p => p.Dargsts)
                .HasForeignKey(d => d.ReqNo)
                .HasConstraintName("FK_DARGST_PVAM");

        }
    }
}
