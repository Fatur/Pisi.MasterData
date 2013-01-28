using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.MasterData.Models.Mapping
{
    public class tblMonthMap : EntityTypeConfiguration<tblMonth>
    {
        public tblMonthMap()
        {
            // Primary Key
            this.HasKey(t => t.MonthID);

            // Properties
            this.Property(t => t.MonthID)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.MonSumID)
                .HasMaxLength(10);

            this.Property(t => t.monName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.monMemo)
                .HasMaxLength(50);

            this.Property(t => t.Computer)
                .HasMaxLength(20);

            this.Property(t => t.Operator)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tblMonth");
            this.Property(t => t.MonthID).HasColumnName("MonthID");
            this.Property(t => t.MonSumID).HasColumnName("MonSumID");
            this.Property(t => t.monName).HasColumnName("monName");
            this.Property(t => t.monDay).HasColumnName("monDay");
            this.Property(t => t.monHoliday).HasColumnName("monHoliday");
            this.Property(t => t.monMemo).HasColumnName("monMemo");
            this.Property(t => t.monClose).HasColumnName("monClose");
            this.Property(t => t.monQTY).HasColumnName("monQTY");
            this.Property(t => t.monBonus).HasColumnName("monBonus");
            this.Property(t => t.monExclude).HasColumnName("monExclude");
            this.Property(t => t.Computer).HasColumnName("Computer");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
        }
    }
}
