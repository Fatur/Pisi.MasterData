using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Pisi.MasterData.Models.Mapping
{
    public class tblEmployeeMap : EntityTypeConfiguration<tblEmployee>
    {
        public tblEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.EmployeeID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DepartmentID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ClassificationID)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.LANID)
                .HasMaxLength(10);

            this.Property(t => t.CategoryID)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.DivisionID)
                .HasMaxLength(5);

            this.Property(t => t.empRanking)
                .HasMaxLength(50);

            this.Property(t => t.empName)
                .HasMaxLength(40);

            this.Property(t => t.empNickName)
                .HasMaxLength(50);

            this.Property(t => t.DesignationID)
                .HasMaxLength(5);

            this.Property(t => t.empAddress)
                .HasMaxLength(150);

            this.Property(t => t.empBirthPlace)
                .HasMaxLength(50);

            this.Property(t => t.empNPWP)
                .HasMaxLength(25);

            this.Property(t => t.MaritalID)
                .HasMaxLength(5);

            this.Property(t => t.empAlasanBerhenti)
                .HasMaxLength(225);

            this.Property(t => t.SexID)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PlaceofHire)
                .HasMaxLength(50);

            this.Property(t => t.RecruitedBy)
                .HasMaxLength(50);

            this.Property(t => t.empPhone)
                .HasMaxLength(30);

            this.Property(t => t.empAssurance)
                .HasMaxLength(20);

            this.Property(t => t.empAccount)
                .HasMaxLength(20);

            this.Property(t => t.empPersenBank)
                .HasMaxLength(50);

            this.Property(t => t.empPrestasiKerja)
                .HasMaxLength(255);

            this.Property(t => t.ReligionID)
                .HasMaxLength(5);

            this.Property(t => t.empLastEducation)
                .HasMaxLength(100);

            this.Property(t => t.empPrevEmp)
                .HasMaxLength(50);

            this.Property(t => t.empPrevAddress)
                .HasMaxLength(225);

            this.Property(t => t.RaceID)
                .HasMaxLength(5);

            this.Property(t => t.empStaffMemo)
                .HasMaxLength(20);

            this.Property(t => t.empNote)
                .HasMaxLength(4000);

            this.Property(t => t.empKTP)
                .HasMaxLength(30);

            this.Property(t => t.SectionID)
                .HasMaxLength(10);

            this.Property(t => t.Card_No)
                .HasMaxLength(20);

            this.Property(t => t.empUniform)
                .HasMaxLength(50);

            this.Property(t => t.empShoes)
                .HasMaxLength(50);

            this.Property(t => t.empVeilJilbab)
                .HasMaxLength(50);

            this.Property(t => t.LockerID)
                .HasMaxLength(20);

            this.Property(t => t.empSuperior)
                .HasMaxLength(10);

            this.Property(t => t.empPhoto)
                .HasMaxLength(1);

            this.Property(t => t.empCurrShift)
                .HasMaxLength(5);

            this.Property(t => t.MealGroupID)
                .HasMaxLength(50);

            this.Property(t => t.empZip)
                .HasMaxLength(12);

            this.Property(t => t.empBlood)
                .HasMaxLength(3);

            this.Property(t => t.WifeID)
                .HasMaxLength(5);

            this.Property(t => t.empPager)
                .HasMaxLength(30);

            this.Property(t => t.CurrencyID)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.PaymentID)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.BankID)
                .HasMaxLength(8);

            this.Property(t => t.empIdentNumber)
                .HasMaxLength(50);

            this.Property(t => t.NationalityID)
                .HasMaxLength(5);

            this.Property(t => t.empNomorBuktiPPH26)
                .HasMaxLength(50);

            this.Property(t => t.RecruitmentID)
                .HasMaxLength(10);

            this.Property(t => t.empKelurahan)
                .HasMaxLength(20);

            this.Property(t => t.empKecamatan)
                .HasMaxLength(20);

            this.Property(t => t.empPostal)
                .HasMaxLength(5);

            this.Property(t => t.GroupID)
                .HasMaxLength(5);

            this.Property(t => t.DormitoryID)
                .HasMaxLength(10);

            this.Property(t => t.EmpmentStatusID)
                .HasMaxLength(5);

            this.Property(t => t.JobStatusID)
                .HasMaxLength(5);

            this.Property(t => t.empHobby)
                .HasMaxLength(50);

            this.Property(t => t.LevelID)
                .HasMaxLength(10);

            this.Property(t => t.ClusterID)
                .HasMaxLength(5);

            this.Property(t => t.Computer)
                .HasMaxLength(20);

            this.Property(t => t.Operator)
                .HasMaxLength(20);

            this.Property(t => t.MaritalIDHR)
                .HasMaxLength(50);

            this.Property(t => t.empNPWPName)
                .HasMaxLength(50);

            this.Property(t => t.BankID2nd)
                .HasMaxLength(8);

            this.Property(t => t.empAccount2nd)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CurrencyID2nd)
                .HasMaxLength(3);

            this.Property(t => t.empDesignation)
                .HasMaxLength(50);

            this.Property(t => t.empMobile)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tblEmployee");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.ClassificationID).HasColumnName("ClassificationID");
            this.Property(t => t.LANID).HasColumnName("LANID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.empIndirectLabour).HasColumnName("empIndirectLabour");
            this.Property(t => t.empRanking).HasColumnName("empRanking");
            this.Property(t => t.empName).HasColumnName("empName");
            this.Property(t => t.empNickName).HasColumnName("empNickName");
            this.Property(t => t.DesignationID).HasColumnName("DesignationID");
            this.Property(t => t.empAddress).HasColumnName("empAddress");
            this.Property(t => t.empBirthPlace).HasColumnName("empBirthPlace");
            this.Property(t => t.empBirthDate).HasColumnName("empBirthDate");
            this.Property(t => t.empNPWP).HasColumnName("empNPWP");
            this.Property(t => t.MaritalID).HasColumnName("MaritalID");
            this.Property(t => t.empJoin).HasColumnName("empJoin");
            this.Property(t => t.empAkhirPercobaan).HasColumnName("empAkhirPercobaan");
            this.Property(t => t.empContract).HasColumnName("empContract");
            this.Property(t => t.empAkhirKontrak).HasColumnName("empAkhirKontrak");
            this.Property(t => t.empResigned).HasColumnName("empResigned");
            this.Property(t => t.empAlasanBerhenti).HasColumnName("empAlasanBerhenti");
            this.Property(t => t.Daily).HasColumnName("Daily");
            this.Property(t => t.empBase).HasColumnName("empBase");
            this.Property(t => t.SexID).HasColumnName("SexID");
            this.Property(t => t.empHeight).HasColumnName("empHeight");
            this.Property(t => t.empWeight).HasColumnName("empWeight");
            this.Property(t => t.PlaceofHire).HasColumnName("PlaceofHire");
            this.Property(t => t.RecruitedBy).HasColumnName("RecruitedBy");
            this.Property(t => t.empPhone).HasColumnName("empPhone");
            this.Property(t => t.empAssureDate).HasColumnName("empAssureDate");
            this.Property(t => t.empAssurance).HasColumnName("empAssurance");
            this.Property(t => t.empJKM).HasColumnName("empJKM");
            this.Property(t => t.empJKKesehatan).HasColumnName("empJKKesehatan");
            this.Property(t => t.empJKK).HasColumnName("empJKK");
            this.Property(t => t.empJHTco).HasColumnName("empJHTco");
            this.Property(t => t.empJHTemp).HasColumnName("empJHTemp");
            this.Property(t => t.empAccount).HasColumnName("empAccount");
            this.Property(t => t.empPersenBank).HasColumnName("empPersenBank");
            this.Property(t => t.empPrestasiKerja).HasColumnName("empPrestasiKerja");
            this.Property(t => t.ReligionID).HasColumnName("ReligionID");
            this.Property(t => t.empLastEducation).HasColumnName("empLastEducation");
            this.Property(t => t.empPrevEmp).HasColumnName("empPrevEmp");
            this.Property(t => t.empPrevAddress).HasColumnName("empPrevAddress");
            this.Property(t => t.RaceID).HasColumnName("RaceID");
            this.Property(t => t.empStaffMemo).HasColumnName("empStaffMemo");
            this.Property(t => t.empNote).HasColumnName("empNote");
            this.Property(t => t.empConfirmed).HasColumnName("empConfirmed");
            this.Property(t => t.empKTP).HasColumnName("empKTP");
            this.Property(t => t.SectionID).HasColumnName("SectionID");
            this.Property(t => t.Card_No).HasColumnName("Card No");
            this.Property(t => t.ApplicantID).HasColumnName("ApplicantID");
            this.Property(t => t.empUniform).HasColumnName("empUniform");
            this.Property(t => t.empShoes).HasColumnName("empShoes");
            this.Property(t => t.empVeilJilbab).HasColumnName("empVeilJilbab");
            this.Property(t => t.LockerID).HasColumnName("LockerID");
            this.Property(t => t.empSuperior).HasColumnName("empSuperior");
            this.Property(t => t.EducationID).HasColumnName("EducationID");
            this.Property(t => t.empPhoto).HasColumnName("empPhoto");
            this.Property(t => t.empCurrShift).HasColumnName("empCurrShift");
            this.Property(t => t.MealGroupID).HasColumnName("MealGroupID");
            this.Property(t => t.empZip).HasColumnName("empZip");
            this.Property(t => t.empBlood).HasColumnName("empBlood");
            this.Property(t => t.WifeID).HasColumnName("WifeID");
            this.Property(t => t.empPager).HasColumnName("empPager");
            this.Property(t => t.empBaseDate).HasColumnName("empBaseDate");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.PaymentID).HasColumnName("PaymentID");
            this.Property(t => t.BankID).HasColumnName("BankID");
            this.Property(t => t.IdentificationID).HasColumnName("IdentificationID");
            this.Property(t => t.empIdentNumber).HasColumnName("empIdentNumber");
            this.Property(t => t.NationalityID).HasColumnName("NationalityID");
            this.Property(t => t.empExpatriate).HasColumnName("empExpatriate");
            this.Property(t => t.empTaxArticle26).HasColumnName("empTaxArticle26");
            this.Property(t => t.empNomorBuktiPPH26).HasColumnName("empNomorBuktiPPH26");
            this.Property(t => t.empTglBuktiPPH26).HasColumnName("empTglBuktiPPH26");
            this.Property(t => t.RecruitmentID).HasColumnName("RecruitmentID");
            this.Property(t => t.empKelurahan).HasColumnName("empKelurahan");
            this.Property(t => t.empKecamatan).HasColumnName("empKecamatan");
            this.Property(t => t.empsalaryType).HasColumnName("empsalaryType");
            this.Property(t => t.empPostal).HasColumnName("empPostal");
            this.Property(t => t.PaidID).HasColumnName("PaidID");
            this.Property(t => t.LastBal).HasColumnName("LastBal");
            this.Property(t => t.LastPostLeave).HasColumnName("LastPostLeave");
            this.Property(t => t.LeaQty).HasColumnName("LeaQty");
            this.Property(t => t.EmpvalidThru).HasColumnName("EmpvalidThru");
            this.Property(t => t.TransportID).HasColumnName("TransportID");
            this.Property(t => t.MealID).HasColumnName("MealID");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.empBaseOld).HasColumnName("empBaseOld");
            this.Property(t => t.DormitoryID).HasColumnName("DormitoryID");
            this.Property(t => t.EmpmentStatusID).HasColumnName("EmpmentStatusID");
            this.Property(t => t.TaxID).HasColumnName("TaxID");
            this.Property(t => t.JobStatusID).HasColumnName("JobStatusID");
            this.Property(t => t.empHobby).HasColumnName("empHobby");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.LevelID).HasColumnName("LevelID");
            this.Property(t => t.empCatTax).HasColumnName("empCatTax");
            this.Property(t => t.ClusterID).HasColumnName("ClusterID");
            this.Property(t => t.empStatus).HasColumnName("empStatus");
            this.Property(t => t.Computer).HasColumnName("Computer");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.MaritalIDHR).HasColumnName("MaritalIDHR");
            this.Property(t => t.empHRNumChild).HasColumnName("empHRNumChild");
            this.Property(t => t.empNPWPName).HasColumnName("empNPWPName");
            this.Property(t => t.BankID2nd).HasColumnName("BankID2nd");
            this.Property(t => t.empBankPercent2nd).HasColumnName("empBankPercent2nd");
            this.Property(t => t.empBankPercent).HasColumnName("empBankPercent");
            this.Property(t => t.empAccount2nd).HasColumnName("empAccount2nd");
            this.Property(t => t.empCcyPct1st).HasColumnName("empCcyPct1st");
            this.Property(t => t.CurrencyID2nd).HasColumnName("CurrencyID2nd");
            this.Property(t => t.empCcyPct2nd).HasColumnName("empCcyPct2nd");
            this.Property(t => t.empDesignation).HasColumnName("empDesignation");
            this.Property(t => t.empMobile).HasColumnName("empMobile");
            this.Property(t => t.TglMasukJamsostek).HasColumnName("TglMasukJamsostek");
            this.Property(t => t.tglNoticeResign).HasColumnName("tglNoticeResign");
            this.Property(t => t.empWarning).HasColumnName("empWarning");
            this.Property(t => t.tglNoticeBook).HasColumnName("tglNoticeBook");
        }
    }
}
