using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Pisi.MasterData.Models.Mapping;

namespace Pisi.MasterData.Models
{
    public class pisidataContext : DbContext
    {
        static pisidataContext()
        {
            Database.SetInitializer<pisidataContext>(null);
        }

		public pisidataContext()
			: base("Name=pisidataContext")
		{
		}

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<tblMonth> tblMonths { get; set; }
        public DbSet<tblPeriod> tblPeriods { get; set; }
        public DbSet<tblUserVerification> tblUserVerifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tblEmployeeMap());
            modelBuilder.Configurations.Add(new tblMonthMap());
            modelBuilder.Configurations.Add(new tblPeriodMap());
            modelBuilder.Configurations.Add(new tblUserVerificationMap());
        }
    }
}
