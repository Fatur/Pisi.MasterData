using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.MasterData.Models.Mapping
{
    public class tblUserVerificationMap : EntityTypeConfiguration<tblUserVerification>
    {
        public tblUserVerificationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeId, t.VeryficationKey });

            // Properties
            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.VeryficationKey)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("tblUserVerification");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.VeryficationKey).HasColumnName("VeryficationKey");

            // Relationships
            this.HasRequired(t => t.tblEmployee)
                .WithMany(t => t.tblUserVerifications)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
