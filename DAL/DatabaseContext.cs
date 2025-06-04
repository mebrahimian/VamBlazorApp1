using DAL.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamBlazor.Client.Application.Dtos;
using VamBlazor.Client.Domain.Entities;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public  DbSet<Amalkard> Amalkards { get; set; }

        public  DbSet<AmalkardView> AmalkardViews { get; set; }

        public  DbSet<AmalkardViewGroup> AmalkardViewGroups { get; set; }

        public  DbSet<Bank> Banks { get; set; }

        public  DbSet<Dargst> Dargsts { get; set; }

        public  DbSet<Hesab> Hesabs { get; set; }

        public  DbSet<MojodiMandehVam> MojodiMandehVams { get; set; }

        public  DbSet<Pardar> Pardars { get; set; }

        public  DbSet<Person> Persons { get; set; }

        public  DbSet<Pvam> Pvams { get; set; }

        public  DbSet<Qvam> Qvams { get; set; }

        public  DbSet<Sandogh> Sandoghs { get; set; }

        public  DbSet<SpecificDate> SpecificDates { get; set; }

        public  DbSet<SystemUser> SystemUsers { get; set; }

        public  DbSet<TotalAghsat> TotalAghsats { get; set; }

        public  DbSet<TotalVam> TotalVams { get; set; }

        public  DbSet<User> Users { get; set; }

        public  DbSet<UsersLog> UsersLogs { get; set; }
      
        public DbSet<tblDate> tblDates { get; set; }   
        
        public DbSet<vwPersonFullData> vwPersonFullData { get; set; }
        public DbSet<vwPersonLastGst> vwPersonLastGst { get; set; }
        public DbSet<vwPersonTotalGst> vwPersonTotalGst { get; set; }
        public DbSet<vwReportPersonStatus> vwReportPersonStatus { get; set; }
        public DbSet<vwPersonAllTransactions> vwPersonAllTransactions { get; set; }
        public DbSet<vwPersonStatusCurrent> vwPersonStatusCurrent { get; set; }
      //  public DbSet<sp_PersonStatusUpTo> sp_PersonStatusUpTos { get; set; }
        public DbSet<PersonStatusUpToDto> PersonStatusUpToDtos { get; set; }
        

        //  public DbSet<VwPersonFullData>VwPersonFullData
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DatabaseContext()
        {
        }

        /*
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
   optionsBuilder.UseSqlServer("Data Source=EBRAHMIAN-FIN-B\\SQL2019;Initial Catalog=Vam_New;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
}
*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1256_CI_AS");
            //
            // کانفیک این جداول در فولدر کانفیک است
            // بقیه همین جا
            // 
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new AmalkardConfig());
            modelBuilder.ApplyConfiguration(new DargstConfig());

            modelBuilder.Entity<vwPersonFullData>(entity =>
            {
                entity.HasNoKey()
                  .ToView("vwPersonFullData");

            });

            modelBuilder.Entity<vwPersonLastGst>(entity =>
            {
                entity.HasNoKey()
                  .ToView("vwPersonLastGst");

            });
            modelBuilder.Entity<vwPersonStatusCurrent>(entity =>
            {
                entity.HasNoKey()
                  .ToView("vwPersonStatusCurrent");
                entity.Property(e => e.HesabNo).HasColumnName("hesab_no");
                entity.Property(e => e.City).HasColumnName("city");
                entity.Property(e => e.Sex).HasColumnName("sex");
            });
            modelBuilder.Entity<vwPersonTotalGst>(entity =>
            {
                entity.HasNoKey()
                  .ToView("vwPersonTotalGst");
                entity.Property(e => e.GstNo).HasColumnName("gst_no");
                entity.Property(e => e.GstDate).HasColumnName("date_g");
                entity.Property(e => e.PaidDate).HasColumnName("date_p");
                
            });

            modelBuilder.Entity<vwReportPersonStatus>(entity =>
            {
                entity.HasNoKey()
                    .ToView("vwReportPersonStatus");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
                    
                entity.Property(e => e.FullName).HasMaxLength(100);
                entity.Property(e => e.Vam).HasColumnType("bigint");
                entity.Property(e => e.GstPaid).HasColumnType("bigint");
                entity.Property(e => e.Pasandaz).HasColumnType("bigint");
                entity.Property(e => e.Karmozd).HasColumnType("bigint");
                entity.Property(e => e.ColVamGst).HasColumnType("bigint");
                entity.Property(e => e.ColPasandaz).HasColumnType("bigint");
                entity.Property(e => e.HesabNo).HasColumnName("Hesab_no");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                 
                entity.Property(e => e.SexTitle)
                    .HasMaxLength(5)
                    .IsUnicode(false);
                
            });
            modelBuilder.Entity<vwPersonAllTransactions>(entity =>
            {
                entity.HasNoKey()
                    .ToView("vwPersonAllTransactions");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vam).HasColumnType("bigint");
                entity.Property(e => e.GstPaid).HasColumnType("bigint");
                entity.Property(e => e.Pasandaz).HasColumnType("bigint");
                entity.Property(e => e.Karmozd).HasColumnType("bigint");
                entity.Property(e => e.HesabNo).HasColumnName("Hesab_no");
                entity.Property(e => e.ReqNo).HasColumnName("req_no");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
                                
            });
            modelBuilder.Entity<AmalkardView>(entity =>
            {
                entity.HasNoKey()
                    .ToView("Amalkard_View");
                
                entity.Property(e => e.Babat).HasMaxLength(100);
                entity.Property(e => e.Bed)
                    .HasColumnType("bigint")
                    .HasColumnName("bed");
                entity.Property(e => e.Bes)
                    .HasColumnType("bigint")
                    .HasColumnName("bes");
                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("PCode");
                entity.Property(e => e.Tbl)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmalkardViewGroup>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("Amalkard_View_Group");

                entity.Property(e => e.Bed)
                    .HasColumnType("bigint")
                    .HasColumnName("bed");
                entity.Property(e => e.Bes)
                    .HasColumnType("bigint")
                    .HasColumnName("bes");
                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("PCode");
                entity.Property(e => e.Tbl)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });
            
            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.BankName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

          

            modelBuilder.Entity<Hesab>(entity =>
            {
                entity.HasKey(e => e.HesabNo);

                entity.ToTable("HESAB", tb => tb.HasTrigger("AddNewQvam"));

                entity.Property(e => e.HesabNo)
                    .ValueGeneratedNever()
                    .HasColumnName("hesab_no");
                entity.Property(e => e.Curqty)
                    .HasDefaultValue(0L)
                    .HasColumnName("curqty");
                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date");
                entity.Property(e => e.Firstqty).HasColumnName("firstqty");
                entity.Property(e => e.IdDi).HasColumnName("id___di");
                entity.Property(e => e.Monthqty).HasColumnName("monthqty");
                entity.Property(e => e.P)
                    .HasDefaultValue(0L)
                    .HasColumnName("p");
                entity.Property(e => e.P1)
                    .HasDefaultValue(0L)
                    .HasColumnName("p1");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("pcode");
                entity.Property(e => e.Scode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("scode");
            });

            modelBuilder.Entity<MojodiMandehVam>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("MojodiMandehVam");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("code");
                entity.Property(e => e.Fam).HasMaxLength(74);
                entity.Property(e => e.HesabNo).HasColumnName("Hesab_no");
                entity.Property(e => e.Mojodi).HasColumnType("bigint");
                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("sex");
                entity.Property(e => e.StartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pardar>(entity =>
            {
                entity.HasKey(e => e.IdDi);
                entity.ToTable("PARDAR", tb => tb.HasTrigger("PardarTrigger"));
            
                entity.HasIndex(e => new { e.Date, e.Pcode, e.Action }, "IX_PARDAR").IsClustered();

                entity.Property(e => e.Action)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("action");
                entity.Property(e => e.Babat)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(space((1)))")
                    .HasColumnName("babat");
                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date");
                entity.Property(e => e.IdDi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id___di");
                entity.Property(e => e.Khayer)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(space((1)))")
                    .IsFixedLength();
                entity.Property(e => e.Mblg)
                    .HasDefaultValue(0m)
                    .HasColumnType("bigint")
                    .HasColumnName("mblg");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("pcode");
                entity.Property(e => e.ReqNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(space((1)))")
                    .IsFixedLength()
                    .HasColumnName("req_no");
                entity.Property(e => e.Scode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValue("01")
                    .IsFixedLength()
                    .HasColumnName("scode");
            });

            modelBuilder.Entity<Pvam>(entity =>
            {
                entity.HasKey(e => e.ReqNo);

                entity.ToTable("PVAM", tb => tb.HasTrigger("PVamTrigger"));

                entity.Property(e => e.ReqNo)
                    .ValueGeneratedNever()
                    .HasColumnName("req_no");
                entity.Property(e => e.DateD)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date_d");
                entity.Property(e => e.DateG)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date_g");
                entity.Property(e => e.Gst1)
                    .HasDefaultValue(0L)
                    .HasColumnName("gst1");
                entity.Property(e => e.Gst2)
                    .HasDefaultValue(0L)
                    .HasColumnName("gst2");
                entity.Property(e => e.GstNo)
                    .HasDefaultValue((byte)0)
                    .HasColumnName("gst_no");
                entity.Property(e => e.GstPay)
                    .HasDefaultValue(0)
                    .HasColumnName("gst_pay");
                entity.Property(e => e.Lastdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("lastdate");
                entity.Property(e => e.Mblgmain).HasColumnName("mblgmain");
                entity.Property(e => e.Mblgvam)
                    .HasDefaultValue(0L)
                    .HasColumnName("mblgvam");
                entity.Property(e => e.Mkarmozd).HasColumnName("mkarmozd");
                entity.Property(e => e.Pkarmozd).HasColumnName("pkarmozd");
                entity.Property(e => e.Sabtdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("sabtdate");
                entity.Property(e => e.Scode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValue("01")
                    .IsFixedLength()
                    .HasColumnName("scode");
                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("status");
                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("type");

                entity.HasOne(d => d.ReqNoNavigation).WithOne(p => p.Pvam)
                    .HasForeignKey<Pvam>(d => d.ReqNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVAM_QVAM");
            });

            modelBuilder.Entity<Qvam>(entity =>
            {
                entity.HasKey(e => e.ReqNo);

                entity.ToTable("QVAM");

                entity.Property(e => e.ReqNo)
                    .ValueGeneratedNever()
                    .HasColumnName("REQ_NO");
                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .HasColumnName("DATE");
                entity.Property(e => e.Mblg).HasColumnName("MBLG");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("PCODE");
                entity.Property(e => e.Sabtdate)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(space((8)))")
                    .HasColumnName("SABTDATE");
                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("STATUS");
                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<Sandogh>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("SANDOGH");

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("code");
                entity.Property(e => e.Curqty)
                    .HasColumnType("numeric(19, 0)")
                    .HasColumnName("curqty");
                entity.Property(e => e.Etebar)
                    .HasColumnType("numeric(19, 0)")
                    .HasColumnName("etebar");
                entity.Property(e => e.Firstqty)
                    .HasColumnType("numeric(19, 0)")
                    .HasColumnName("firstqty");
                entity.Property(e => e.Maxetebar)
                    .HasColumnType("numeric(19, 0)")
                    .HasColumnName("maxetebar");
                entity.Property(e => e.Onvan)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("onvan");
                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SpecificDate>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("specificDate");

                entity.Property(e => e.Babat).HasMaxLength(100);
                entity.Property(e => e.Bed)
                    .HasColumnType("bigint")
                    .HasColumnName("bed");
                entity.Property(e => e.Bes)
                    .HasColumnType("bigint")
                    .HasColumnName("bes");
                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("PCode");
                entity.Property(e => e.Tbl)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<TotalAghsat>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("Total_Aghsat");

                entity.Property(e => e.DateG)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date_g");
                entity.Property(e => e.DateP)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date_p");
                entity.Property(e => e.Gstmblg).HasColumnName("gstmblg");
                entity.Property(e => e.HesabNo).HasColumnName("hesab_no");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("PCODE");
                entity.Property(e => e.ReqNo).HasColumnName("req_no");
            });

            modelBuilder.Entity<TotalVam>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("Total_Vams");

                entity.Property(e => e.DateD)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date_d");
                entity.Property(e => e.DateG)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("date_g");
                entity.Property(e => e.DateReq).HasMaxLength(10);
                entity.Property(e => e.Gst1).HasColumnName("gst1");
                entity.Property(e => e.Gst2).HasColumnName("gst2");
                entity.Property(e => e.GstNo).HasColumnName("gst_no");
                entity.Property(e => e.GstPay).HasColumnName("gst_pay");
                entity.Property(e => e.Mblgmain).HasColumnName("mblgmain");
                entity.Property(e => e.Mblgvam).HasColumnName("mblgvam");
                entity.Property(e => e.Mkarmozd).HasColumnName("mkarmozd");
                entity.Property(e => e.Pcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("PCODE");
                entity.Property(e => e.Pkarmozd).HasColumnName("pkarmozd");
                entity.Property(e => e.ReqNo).HasColumnName("req_no");
                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Access)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.EndTime)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Menu1Option)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Menu2Option)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Menu3Option)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Menu4Option)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Name).HasMaxLength(30);
                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.StartTime)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.SubMenu1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.SubMenu2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.SubMenu3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.SubMenu4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.ToolBar)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UsersLog>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("UsersLog");

                entity.Property(e => e.ActionDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("actionDate");
                entity.Property(e => e.ActionTime)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("id");
                entity.Property(e => e.Station)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("station");
                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status");
                entity.Property(e => e.System)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });
            modelBuilder.Entity<tblDate>(entity =>
            {
                 entity.HasKey(e => e.GDate);

                 entity.ToTable("tblDate10");

                 entity.Property(e => e.HDate)
                     .HasMaxLength(8);
                 entity.Property(e => e.HYear)
                     .HasMaxLength(4);
                 entity.Property(e => e.GYear)
                     .HasMaxLength(4);
                 entity.Property(e => e.HYrMth)
                     .HasMaxLength(6);
                 entity.Property(e => e.GYrMth)
                     .HasMaxLength(6);
                 entity.Property(e => e.HMonthName)
                     .HasMaxLength(15);
                 entity.Property(e => e.HWeekDayName)
                     .HasMaxLength(15);
                 entity.Property(e => e.GWeekDayName)
                     .HasMaxLength(15);
                
             });

            modelBuilder.Entity<sp_PersonStatusUpTo>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView(null); // به این معنا که این مدل به یک View یا جدول واقعی نگاشت نمی‌شود
                             
            });
            modelBuilder.Entity<PersonStatusUpToDto>(entity =>
            {
                entity.HasNoKey(); // چون جدول نداره
                entity.ToView(null); // نگاشت به هیچ ویویی
            });

            base.OnModelCreating(modelBuilder);
        }

        
    }


}

