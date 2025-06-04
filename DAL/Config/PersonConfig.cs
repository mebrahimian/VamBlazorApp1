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
    internal class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(e => e.Code);

            builder.ToTable("PERSON");

            builder.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("code")
                .IsRequired();
            builder.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasColumnName("address");

            builder.Property(e => e.CardBank)
                 .HasMaxLength(16)
                 .IsUnicode(false);
            builder.Property(e => e.City)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("city");
            builder.Property(e => e.Family)
                .HasMaxLength(30)
                .HasColumnName("family");
            builder.Property(e => e.Father)
                .HasMaxLength(20)
                .HasColumnName("father");
            builder.Property(e => e.HesabBank)
                .HasMaxLength(16)
                .IsUnicode(false);
            builder.Property(e => e.IdDi)
                .ValueGeneratedOnAdd()
                .HasColumnName("id___di");
            builder.Property(e => e.IssueNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("issue_no");
            builder.Property(e => e.Mellicode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("mellicode");
            builder.Property(x => x.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            builder.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("sex");
            builder.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            builder.Property(e => e.Tel)
                .HasMaxLength(30)
                .HasColumnName("tel");



        }
    }
 
}
