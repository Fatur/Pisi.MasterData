using System;
using System.Collections.Generic;

namespace Pisi.MasterData.Models
{
    public class tblEmployee
    {
        public tblEmployee()
        {
            this.tblUserVerifications = new List<tblUserVerification>();
        }

        public string EmployeeID { get; set; }
        public string DepartmentID { get; set; }
        public string ClassificationID { get; set; }
        public string LANID { get; set; }
        public string CategoryID { get; set; }
        public string DivisionID { get; set; }
        public bool empIndirectLabour { get; set; }
        public string empRanking { get; set; }
        public string empName { get; set; }
        public string empNickName { get; set; }
        public string DesignationID { get; set; }
        public string empAddress { get; set; }
        public string empBirthPlace { get; set; }
        public Nullable<System.DateTime> empBirthDate { get; set; }
        public string empNPWP { get; set; }
        public string MaritalID { get; set; }
        public Nullable<System.DateTime> empJoin { get; set; }
        public Nullable<System.DateTime> empAkhirPercobaan { get; set; }
        public Nullable<System.DateTime> empContract { get; set; }
        public Nullable<System.DateTime> empAkhirKontrak { get; set; }
        public Nullable<System.DateTime> empResigned { get; set; }
        public string empAlasanBerhenti { get; set; }
        public bool Daily { get; set; }
        public Nullable<decimal> empBase { get; set; }
        public string SexID { get; set; }
        public Nullable<int> empHeight { get; set; }
        public Nullable<int> empWeight { get; set; }
        public string PlaceofHire { get; set; }
        public string RecruitedBy { get; set; }
        public string empPhone { get; set; }
        public Nullable<System.DateTime> empAssureDate { get; set; }
        public string empAssurance { get; set; }
        public bool empJKM { get; set; }
        public bool empJKKesehatan { get; set; }
        public bool empJKK { get; set; }
        public bool empJHTco { get; set; }
        public bool empJHTemp { get; set; }
        public string empAccount { get; set; }
        public string empPersenBank { get; set; }
        public string empPrestasiKerja { get; set; }
        public string ReligionID { get; set; }
        public string empLastEducation { get; set; }
        public string empPrevEmp { get; set; }
        public string empPrevAddress { get; set; }
        public string RaceID { get; set; }
        public string empStaffMemo { get; set; }
        public string empNote { get; set; }
        public Nullable<System.DateTime> empConfirmed { get; set; }
        public string empKTP { get; set; }
        public string SectionID { get; set; }
        public string Card_No { get; set; }
        public Nullable<int> ApplicantID { get; set; }
        public string empUniform { get; set; }
        public string empShoes { get; set; }
        public string empVeilJilbab { get; set; }
        public string LockerID { get; set; }
        public string empSuperior { get; set; }
        public Nullable<short> EducationID { get; set; }
        public string empPhoto { get; set; }
        public string empCurrShift { get; set; }
        public string MealGroupID { get; set; }
        public string empZip { get; set; }
        public string empBlood { get; set; }
        public string WifeID { get; set; }
        public string empPager { get; set; }
        public Nullable<System.DateTime> empBaseDate { get; set; }
        public string CurrencyID { get; set; }
        public string PaymentID { get; set; }
        public string BankID { get; set; }
        public Nullable<short> IdentificationID { get; set; }
        public string empIdentNumber { get; set; }
        public string NationalityID { get; set; }
        public bool empExpatriate { get; set; }
        public bool empTaxArticle26 { get; set; }
        public string empNomorBuktiPPH26 { get; set; }
        public Nullable<System.DateTime> empTglBuktiPPH26 { get; set; }
        public string RecruitmentID { get; set; }
        public string empKelurahan { get; set; }
        public string empKecamatan { get; set; }
        public Nullable<short> empsalaryType { get; set; }
        public string empPostal { get; set; }
        public Nullable<short> PaidID { get; set; }
        public Nullable<decimal> LastBal { get; set; }
        public Nullable<System.DateTime> LastPostLeave { get; set; }
        public Nullable<decimal> LeaQty { get; set; }
        public Nullable<System.DateTime> EmpvalidThru { get; set; }
        public Nullable<short> TransportID { get; set; }
        public Nullable<short> MealID { get; set; }
        public string GroupID { get; set; }
        public Nullable<decimal> empBaseOld { get; set; }
        public string DormitoryID { get; set; }
        public string EmpmentStatusID { get; set; }
        public Nullable<short> TaxID { get; set; }
        public string JobStatusID { get; set; }
        public string empHobby { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public string LevelID { get; set; }
        public Nullable<short> empCatTax { get; set; }
        public string ClusterID { get; set; }
        public Nullable<short> empStatus { get; set; }
        public string Computer { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public string MaritalIDHR { get; set; }
        public Nullable<int> empHRNumChild { get; set; }
        public string empNPWPName { get; set; }
        public string BankID2nd { get; set; }
        public Nullable<decimal> empBankPercent2nd { get; set; }
        public Nullable<decimal> empBankPercent { get; set; }
        public string empAccount2nd { get; set; }
        public Nullable<decimal> empCcyPct1st { get; set; }
        public string CurrencyID2nd { get; set; }
        public Nullable<decimal> empCcyPct2nd { get; set; }
        public string empDesignation { get; set; }
        public string empMobile { get; set; }
        public Nullable<System.DateTime> TglMasukJamsostek { get; set; }
        public Nullable<System.DateTime> tglNoticeResign { get; set; }
        public Nullable<bool> empWarning { get; set; }
        public Nullable<System.DateTime> tglNoticeBook { get; set; }
        public virtual ICollection<tblUserVerification> tblUserVerifications { get; set; }
    }
}
