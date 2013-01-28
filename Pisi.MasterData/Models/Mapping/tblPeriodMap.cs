using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.MasterData.Models.Mapping
{
    public class tblPeriodMap : EntityTypeConfiguration<tblPeriod>
    {
        public tblPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            this.Property(t => t.PeriodId)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PeriodName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblPeriod");
            this.Property(t => t.PeriodId).HasColumnName("PeriodId");
            this.Property(t => t.PeriodName).HasColumnName("PeriodName");
        }
    }
}
