using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.StationsFuel.Entities;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// Employee Entity
/// </summary>
public class Employee : Entity<EmployeeId>
{
    private readonly List<Employee> _employees = new List<Employee>();
    private readonly List<Employee> _employees = new List<Employee>();

    private Employee() { }

    public Employee(EmployeeId id, decimal? empNo)
    {
        Id = id;
        EmpNo = empNo;
    }

    /// <summary>
    /// The unique identifier for the Employee
    /// المعرف الفريد لـ Employee
    /// </summary>
    public EmployeeId Id { get; private set; }

    /// <summary>
    /// EmpNo of the Employee
    /// EmpNo الخاص بـ Employee
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// EmpLNm of the Employee
    /// EmpLNm الخاص بـ Employee
    /// </summary>
    public string EmpLNm { get; private set; }

    /// <summary>
    /// EmpFNm of the Employee
    /// EmpFNm الخاص بـ Employee
    /// </summary>
    public string EmpFNm { get; private set; }

    /// <summary>
    /// EmpImg of the Employee
    /// EmpImg الخاص بـ Employee
    /// </summary>
    public string EmpImg { get; private set; }

    /// <summary>
    /// FirstLastName of the Employee
    /// FirstLastName الخاص بـ Employee
    /// </summary>
    public string FirstLastName { get; private set; }

    /// <summary>
    /// FirstFirstName of the Employee
    /// FirstFirstName الخاص بـ Employee
    /// </summary>
    public string FirstFirstName { get; private set; }

    /// <summary>
    /// SecondLastName of the Employee
    /// SecondLastName الخاص بـ Employee
    /// </summary>
    public string SecondLastName { get; private set; }

    /// <summary>
    /// SecondFirstName of the Employee
    /// SecondFirstName الخاص بـ Employee
    /// </summary>
    public string SecondFirstName { get; private set; }

    /// <summary>
    /// ThirdLastName of the Employee
    /// ThirdLastName الخاص بـ Employee
    /// </summary>
    public string ThirdLastName { get; private set; }

    /// <summary>
    /// ThirdFirstName of the Employee
    /// ThirdFirstName الخاص بـ Employee
    /// </summary>
    public string ThirdFirstName { get; private set; }

    /// <summary>
    /// LastLastName of the Employee
    /// LastLastName الخاص بـ Employee
    /// </summary>
    public string LastLastName { get; private set; }

    /// <summary>
    /// LastFirstName of the Employee
    /// LastFirstName الخاص بـ Employee
    /// </summary>
    public string LastFirstName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the Employee
    /// CompanyNumberShort الخاص بـ Employee
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// ClassNumber of the Employee
    /// ClassNumber الخاص بـ Employee
    /// </summary>
    public decimal? ClassNumber { get; private set; }

    /// <summary>
    /// Gender of the Employee
    /// Gender الخاص بـ Employee
    /// </summary>
    public decimal? Gender { get; private set; }

    /// <summary>
    /// ReligionNumber of the Employee
    /// ReligionNumber الخاص بـ Employee
    /// </summary>
    public decimal? ReligionNumber { get; private set; }

    /// <summary>
    /// NationalityNumber of the Employee
    /// NationalityNumber الخاص بـ Employee
    /// </summary>
    public decimal? NationalityNumber { get; private set; }

    /// <summary>
    /// SocialStatus of the Employee
    /// SocialStatus الخاص بـ Employee
    /// </summary>
    public decimal? SocialStatus { get; private set; }

    /// <summary>
    /// BuildingType of the Employee
    /// BuildingType الخاص بـ Employee
    /// </summary>
    public decimal? BuildingType { get; private set; }

    /// <summary>
    /// EmpLangNo of the Employee
    /// EmpLangNo الخاص بـ Employee
    /// </summary>
    public decimal? EmpLangNo { get; private set; }

    /// <summary>
    /// BirthAddressDate of the Employee
    /// BirthAddressDate الخاص بـ Employee
    /// </summary>
    public string BirthAddressDate { get; private set; }

    /// <summary>
    /// BirthGregorianDate of the Employee
    /// BirthGregorianDate الخاص بـ Employee
    /// </summary>
    public string BirthGregorianDate { get; private set; }

    /// <summary>
    /// BirthPlace of the Employee
    /// BirthPlace الخاص بـ Employee
    /// </summary>
    public string BirthPlace { get; private set; }

    /// <summary>
    /// BirthPlaceDetail of the Employee
    /// BirthPlaceDetail الخاص بـ Employee
    /// </summary>
    public string BirthPlaceDetail { get; private set; }

    /// <summary>
    /// DghtrNo of the Employee
    /// DghtrNo الخاص بـ Employee
    /// </summary>
    public decimal? DghtrNo { get; private set; }

    /// <summary>
    /// RetirementPaymentPaid of the Employee
    /// RetirementPaymentPaid الخاص بـ Employee
    /// </summary>
    public decimal? RetirementPaymentPaid { get; private set; }

    /// <summary>
    /// SonNumber of the Employee
    /// SonNumber الخاص بـ Employee
    /// </summary>
    public decimal? SonNumber { get; private set; }

    /// <summary>
    /// ParentStatus of the Employee
    /// ParentStatus الخاص بـ Employee
    /// </summary>
    public decimal? ParentStatus { get; private set; }

    /// <summary>
    /// RelativeLastName of the Employee
    /// RelativeLastName الخاص بـ Employee
    /// </summary>
    public string RelativeLastName { get; private set; }

    /// <summary>
    /// RelativeFirstName of the Employee
    /// RelativeFirstName الخاص بـ Employee
    /// </summary>
    public string RelativeFirstName { get; private set; }

    /// <summary>
    /// CreditType of the Employee
    /// CreditType الخاص بـ Employee
    /// </summary>
    public decimal? CreditType { get; private set; }

    /// <summary>
    /// CreditNumber of the Employee
    /// CreditNumber الخاص بـ Employee
    /// </summary>
    public string CreditNumber { get; private set; }

    /// <summary>
    /// NationalNumber of the Employee
    /// NationalNumber الخاص بـ Employee
    /// </summary>
    public string NationalNumber { get; private set; }

    /// <summary>
    /// PlaceCardIssue of the Employee
    /// PlaceCardIssue الخاص بـ Employee
    /// </summary>
    public string PlaceCardIssue { get; private set; }

    /// <summary>
    /// CreditDate of the Employee
    /// CreditDate الخاص بـ Employee
    /// </summary>
    public DateTime? CreditDate { get; private set; }

    /// <summary>
    /// CreditExpireDate of the Employee
    /// CreditExpireDate الخاص بـ Employee
    /// </summary>
    public DateTime? CreditExpireDate { get; private set; }

    /// <summary>
    /// Notes of the Employee
    /// Notes الخاص بـ Employee
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// GradeNumber of the Employee
    /// GradeNumber الخاص بـ Employee
    /// </summary>
    public decimal? GradeNumber { get; private set; }

    /// <summary>
    /// CtgryNo of the Employee
    /// CtgryNo الخاص بـ Employee
    /// </summary>
    public decimal? CtgryNo { get; private set; }

    /// <summary>
    /// DcsnDate of the Employee
    /// DcsnDate الخاص بـ Employee
    /// </summary>
    public DateTime? DcsnDate { get; private set; }

    /// <summary>
    /// DcsnIssuSd of the Employee
    /// DcsnIssuSd الخاص بـ Employee
    /// </summary>
    public decimal? DcsnIssuSd { get; private set; }

    /// <summary>
    /// RetirementDate of the Employee
    /// RetirementDate الخاص بـ Employee
    /// </summary>
    public DateTime? RetirementDate { get; private set; }

    /// <summary>
    /// OldWorkDay of the Employee
    /// OldWorkDay الخاص بـ Employee
    /// </summary>
    public decimal? OldWorkDay { get; private set; }

    /// <summary>
    /// OldWorkMonth of the Employee
    /// OldWorkMonth الخاص بـ Employee
    /// </summary>
    public decimal? OldWorkMonth { get; private set; }

    /// <summary>
    /// OldWorkYear of the Employee
    /// OldWorkYear الخاص بـ Employee
    /// </summary>
    public decimal? OldWorkYear { get; private set; }

    /// <summary>
    /// RetirementDifferentSideFlag of the Employee
    /// RetirementDifferentSideFlag الخاص بـ Employee
    /// </summary>
    public decimal? RetirementDifferentSideFlag { get; private set; }

    /// <summary>
    /// LinkLastWorkFlag of the Employee
    /// LinkLastWorkFlag الخاص بـ Employee
    /// </summary>
    public decimal? LinkLastWorkFlag { get; private set; }

    /// <summary>
    /// RetirementFlag of the Employee
    /// RetirementFlag الخاص بـ Employee
    /// </summary>
    public decimal? RetirementFlag { get; private set; }

    /// <summary>
    /// StartWorkDate of the Employee
    /// StartWorkDate الخاص بـ Employee
    /// </summary>
    public DateTime? StartWorkDate { get; private set; }

    /// <summary>
    /// CurrentJobDate of the Employee
    /// CurrentJobDate الخاص بـ Employee
    /// </summary>
    public DateTime? CurrentJobDate { get; private set; }

    /// <summary>
    /// DcsnNo of the Employee
    /// DcsnNo الخاص بـ Employee
    /// </summary>
    public decimal? DcsnNo { get; private set; }

    /// <summary>
    /// EmpCrntSt of the Employee
    /// EmpCrntSt الخاص بـ Employee
    /// </summary>
    public decimal? EmpCrntSt { get; private set; }

    /// <summary>
    /// EmpSt of the Employee
    /// EmpSt الخاص بـ Employee
    /// </summary>
    public decimal? EmpSt { get; private set; }

    /// <summary>
    /// EmpJobNo of the Employee
    /// EmpJobNo الخاص بـ Employee
    /// </summary>
    public decimal? EmpJobNo { get; private set; }

    /// <summary>
    /// LevelNumber of the Employee
    /// LevelNumber الخاص بـ Employee
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// LastWorkDate of the Employee
    /// LastWorkDate الخاص بـ Employee
    /// </summary>
    public DateTime? LastWorkDate { get; private set; }

    /// <summary>
    /// CurrentQualification of the Employee
    /// CurrentQualification الخاص بـ Employee
    /// </summary>
    public decimal? CurrentQualification { get; private set; }

    /// <summary>
    /// QualificationStartWork of the Employee
    /// QualificationStartWork الخاص بـ Employee
    /// </summary>
    public decimal? QualificationStartWork { get; private set; }

    /// <summary>
    /// MajorNumber of the Employee
    /// MajorNumber الخاص بـ Employee
    /// </summary>
    public decimal? MajorNumber { get; private set; }

    /// <summary>
    /// EmplymntTyp of the Employee
    /// EmplymntTyp الخاص بـ Employee
    /// </summary>
    public decimal? EmplymntTyp { get; private set; }

    /// <summary>
    /// GroupNumberShort of the Employee
    /// GroupNumberShort الخاص بـ Employee
    /// </summary>
    public decimal? GroupNumberShort { get; private set; }

    /// <summary>
    /// LastStartDate of the Employee
    /// LastStartDate الخاص بـ Employee
    /// </summary>
    public DateTime? LastStartDate { get; private set; }

    /// <summary>
    /// LastMoveDate of the Employee
    /// LastMoveDate الخاص بـ Employee
    /// </summary>
    public DateTime? LastMoveDate { get; private set; }

    /// <summary>
    /// EvaluationList of the Employee
    /// EvaluationList الخاص بـ Employee
    /// </summary>
    public decimal? EvaluationList { get; private set; }

    /// <summary>
    /// QualificationCountry of the Employee
    /// QualificationCountry الخاص بـ Employee
    /// </summary>
    public decimal? QualificationCountry { get; private set; }

    /// <summary>
    /// QualificationYear of the Employee
    /// QualificationYear الخاص بـ Employee
    /// </summary>
    public decimal? QualificationYear { get; private set; }

    /// <summary>
    /// DcsnTyp of the Employee
    /// DcsnTyp الخاص بـ Employee
    /// </summary>
    public decimal? DcsnTyp { get; private set; }

    /// <summary>
    /// DyWage of the Employee
    /// DyWage الخاص بـ Employee
    /// </summary>
    public decimal? DyWage { get; private set; }

    /// <summary>
    /// AccountCode of the Employee
    /// AccountCode الخاص بـ Employee
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// HomeCompanyFlag of the Employee
    /// HomeCompanyFlag الخاص بـ Employee
    /// </summary>
    public decimal? HomeCompanyFlag { get; private set; }

    /// <summary>
    /// HourlyWage of the Employee
    /// HourlyWage الخاص بـ Employee
    /// </summary>
    public decimal? HourlyWage { get; private set; }

    /// <summary>
    /// TaxFlag of the Employee
    /// TaxFlag الخاص بـ Employee
    /// </summary>
    public decimal? TaxFlag { get; private set; }

    /// <summary>
    /// SalaryStatus of the Employee
    /// SalaryStatus الخاص بـ Employee
    /// </summary>
    public decimal? SalaryStatus { get; private set; }

    /// <summary>
    /// WorkDayMonth of the Employee
    /// WorkDayMonth الخاص بـ Employee
    /// </summary>
    public decimal? WorkDayMonth { get; private set; }

    /// <summary>
    /// WorkHoursDay of the Employee
    /// WorkHoursDay الخاص بـ Employee
    /// </summary>
    public decimal? WorkHoursDay { get; private set; }

    /// <summary>
    /// ManagerialNumber of the Employee
    /// ManagerialNumber الخاص بـ Employee
    /// </summary>
    public decimal? ManagerialNumber { get; private set; }

    /// <summary>
    /// QualificationIssue of the Employee
    /// QualificationIssue الخاص بـ Employee
    /// </summary>
    public string QualificationIssue { get; private set; }

    /// <summary>
    /// AttendanceType of the Employee
    /// AttendanceType الخاص بـ Employee
    /// </summary>
    public decimal? AttendanceType { get; private set; }

    /// <summary>
    /// StatusMain of the Employee
    /// StatusMain الخاص بـ Employee
    /// </summary>
    public decimal? StatusMain { get; private set; }

    /// <summary>
    /// MaintenanceSource of the Employee
    /// MaintenanceSource الخاص بـ Employee
    /// </summary>
    public decimal? MaintenanceSource { get; private set; }

    /// <summary>
    /// TicketDeserveCalculationType of the Employee
    /// TicketDeserveCalculationType الخاص بـ Employee
    /// </summary>
    public decimal? TicketDeserveCalculationType { get; private set; }

    /// <summary>
    /// LastTicketPaymentDate of the Employee
    /// LastTicketPaymentDate الخاص بـ Employee
    /// </summary>
    public DateTime? LastTicketPaymentDate { get; private set; }

    /// <summary>
    /// SocialInsuranceNumber of the Employee
    /// SocialInsuranceNumber الخاص بـ Employee
    /// </summary>
    public string SocialInsuranceNumber { get; private set; }

    /// <summary>
    /// PaymentMethod of the Employee
    /// PaymentMethod الخاص بـ Employee
    /// </summary>
    public decimal? PaymentMethod { get; private set; }

    /// <summary>
    /// WorkHoursMonth of the Employee
    /// WorkHoursMonth الخاص بـ Employee
    /// </summary>
    public decimal? WorkHoursMonth { get; private set; }

    /// <summary>
    /// WorkHoursYear of the Employee
    /// WorkHoursYear الخاص بـ Employee
    /// </summary>
    public decimal? WorkHoursYear { get; private set; }

    /// <summary>
    /// WorkDayYear of the Employee
    /// WorkDayYear الخاص بـ Employee
    /// </summary>
    public decimal? WorkDayYear { get; private set; }

    /// <summary>
    /// SalaryPaymentWay of the Employee
    /// SalaryPaymentWay الخاص بـ Employee
    /// </summary>
    public decimal? SalaryPaymentWay { get; private set; }

    /// <summary>
    /// MrpType of the Employee
    /// MrpType الخاص بـ Employee
    /// </summary>
    public decimal? MrpType { get; private set; }

    /// <summary>
    /// MrpResource of the Employee
    /// MrpResource الخاص بـ Employee
    /// </summary>
    public decimal? MrpResource { get; private set; }

    /// <summary>
    /// EmpPswrd of the Employee
    /// EmpPswrd الخاص بـ Employee
    /// </summary>
    public string EmpPswrd { get; private set; }

    /// <summary>
    /// UseSelfServiceSystem of the Employee
    /// UseSelfServiceSystem الخاص بـ Employee
    /// </summary>
    public decimal? UseSelfServiceSystem { get; private set; }

    /// <summary>
    /// Email of the Employee
    /// Email الخاص بـ Employee
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// Website of the Employee
    /// Website الخاص بـ Employee
    /// </summary>
    public string Website { get; private set; }

    /// <summary>
    /// FaxNumber of the Employee
    /// FaxNumber الخاص بـ Employee
    /// </summary>
    public string FaxNumber { get; private set; }

    /// <summary>
    /// TelephoneNumber of the Employee
    /// TelephoneNumber الخاص بـ Employee
    /// </summary>
    public string TelephoneNumber { get; private set; }

    /// <summary>
    /// MobileNumber of the Employee
    /// MobileNumber الخاص بـ Employee
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderBoxNumber of the Employee
    /// PurchaseOrderBoxNumber الخاص بـ Employee
    /// </summary>
    public string PurchaseOrderBoxNumber { get; private set; }

    /// <summary>
    /// AddressShort of the Employee
    /// AddressShort الخاص بـ Employee
    /// </summary>
    public string AddressShort { get; private set; }

    /// <summary>
    /// WorkOffice of the Employee
    /// WorkOffice الخاص بـ Employee
    /// </summary>
    public string WorkOffice { get; private set; }

    /// <summary>
    /// PortDescription of the Employee
    /// PortDescription الخاص بـ Employee
    /// </summary>
    public string PortDescription { get; private set; }

    /// <summary>
    /// EntryVisaNumber of the Employee
    /// EntryVisaNumber الخاص بـ Employee
    /// </summary>
    public string EntryVisaNumber { get; private set; }

    /// <summary>
    /// EntryVisaJob of the Employee
    /// EntryVisaJob الخاص بـ Employee
    /// </summary>
    public decimal? EntryVisaJob { get; private set; }

    /// <summary>
    /// InsuranceNumber of the Employee
    /// InsuranceNumber الخاص بـ Employee
    /// </summary>
    public string InsuranceNumber { get; private set; }

    /// <summary>
    /// MedicalInsuranceNumber of the Employee
    /// MedicalInsuranceNumber الخاص بـ Employee
    /// </summary>
    public string MedicalInsuranceNumber { get; private set; }

    /// <summary>
    /// MedicalInsuranceType of the Employee
    /// MedicalInsuranceType الخاص بـ Employee
    /// </summary>
    public decimal? MedicalInsuranceType { get; private set; }

    /// <summary>
    /// InsuranceSonNumber of the Employee
    /// InsuranceSonNumber الخاص بـ Employee
    /// </summary>
    public decimal? InsuranceSonNumber { get; private set; }

    /// <summary>
    /// InsuranceParentNumber of the Employee
    /// InsuranceParentNumber الخاص بـ Employee
    /// </summary>
    public decimal? InsuranceParentNumber { get; private set; }

    /// <summary>
    /// TicketsDeserve of the Employee
    /// TicketsDeserve الخاص بـ Employee
    /// </summary>
    public decimal? TicketsDeserve { get; private set; }

    /// <summary>
    /// EmpTcktsNo of the Employee
    /// EmpTcktsNo الخاص بـ Employee
    /// </summary>
    public decimal? EmpTcktsNo { get; private set; }

    /// <summary>
    /// TicketsCost of the Employee
    /// TicketsCost الخاص بـ Employee
    /// </summary>
    public decimal? TicketsCost { get; private set; }

    /// <summary>
    /// TicketsForDays of the Employee
    /// TicketsForDays الخاص بـ Employee
    /// </summary>
    public decimal? TicketsForDays { get; private set; }

    /// <summary>
    /// EmpTcktsRtio of the Employee
    /// EmpTcktsRtio الخاص بـ Employee
    /// </summary>
    public decimal? EmpTcktsRtio { get; private set; }

    /// <summary>
    /// TicketPathNumber of the Employee
    /// TicketPathNumber الخاص بـ Employee
    /// </summary>
    public string TicketPathNumber { get; private set; }

    /// <summary>
    /// Ctznshp of the Employee
    /// Ctznshp الخاص بـ Employee
    /// </summary>
    public decimal? Ctznshp { get; private set; }

    /// <summary>
    /// EmpNoLast of the Employee
    /// EmpNoLast الخاص بـ Employee
    /// </summary>
    public decimal? EmpNoLast { get; private set; }

    /// <summary>
    /// EmpNoMchn of the Employee
    /// EmpNoMchn الخاص بـ Employee
    /// </summary>
    public decimal? EmpNoMchn { get; private set; }

    /// <summary>
    /// GenerateFlag of the Employee
    /// GenerateFlag الخاص بـ Employee
    /// </summary>
    public decimal? GenerateFlag { get; private set; }

    /// <summary>
    /// LawNoDeserveHoliday of the Employee
    /// LawNoDeserveHoliday الخاص بـ Employee
    /// </summary>
    public decimal? LawNoDeserveHoliday { get; private set; }

    /// <summary>
    /// RelativeEmail of the Employee
    /// RelativeEmail الخاص بـ Employee
    /// </summary>
    public string RelativeEmail { get; private set; }

    /// <summary>
    /// RelativeMobileNumber of the Employee
    /// RelativeMobileNumber الخاص بـ Employee
    /// </summary>
    public string RelativeMobileNumber { get; private set; }

    /// <summary>
    /// RelativeTelephoneNumber of the Employee
    /// RelativeTelephoneNumber الخاص بـ Employee
    /// </summary>
    public string RelativeTelephoneNumber { get; private set; }

    /// <summary>
    /// RetirementAge of the Employee
    /// RetirementAge الخاص بـ Employee
    /// </summary>
    public decimal? RetirementAge { get; private set; }

    /// <summary>
    /// RetirementWorkYear of the Employee
    /// RetirementWorkYear الخاص بـ Employee
    /// </summary>
    public decimal? RetirementWorkYear { get; private set; }

    /// <summary>
    /// SalaryCalculation of the Employee
    /// SalaryCalculation الخاص بـ Employee
    /// </summary>
    public decimal? SalaryCalculation { get; private set; }

    /// <summary>
    /// LastIncreaseDate of the Employee
    /// LastIncreaseDate الخاص بـ Employee
    /// </summary>
    public DateTime? LastIncreaseDate { get; private set; }

    /// <summary>
    /// LastAllianceDate of the Employee
    /// LastAllianceDate الخاص بـ Employee
    /// </summary>
    public DateTime? LastAllianceDate { get; private set; }

    /// <summary>
    /// FingerCalculation of the Employee
    /// FingerCalculation الخاص بـ Employee
    /// </summary>
    public decimal? FingerCalculation { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the Employee
    /// ImportExcelFlag الخاص بـ Employee
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// BankAccountCode of the Employee
    /// BankAccountCode الخاص بـ Employee
    /// </summary>
    public string BankAccountCode { get; private set; }

    /// <summary>
    /// GpsLongitudeX of the Employee
    /// GpsLongitudeX الخاص بـ Employee
    /// </summary>
    public string GpsLongitudeX { get; private set; }

    /// <summary>
    /// GpsLatitudeY of the Employee
    /// GpsLatitudeY الخاص بـ Employee
    /// </summary>
    public string GpsLatitudeY { get; private set; }

    /// <summary>
    /// GpsCity of the Employee
    /// GpsCity الخاص بـ Employee
    /// </summary>
    public string GpsCity { get; private set; }

    /// <summary>
    /// LinkTimesheet of the Employee
    /// LinkTimesheet الخاص بـ Employee
    /// </summary>
    public decimal? LinkTimesheet { get; private set; }

    /// <summary>
    /// ValueList of the Employee
    /// ValueList الخاص بـ Employee
    /// </summary>
    public decimal? ValueList { get; private set; }

    /// <summary>
    /// CountryNumber of the Employee
    /// CountryNumber الخاص بـ Employee
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the Employee
    /// CityNumber الخاص بـ Employee
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the Employee
    /// RegionCode الخاص بـ Employee
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// ProbationaryPeriodEndDate of the Employee
    /// ProbationaryPeriodEndDate الخاص بـ Employee
    /// </summary>
    public DateTime? ProbationaryPeriodEndDate { get; private set; }

    /// <summary>
    /// ProbationaryFlag of the Employee
    /// ProbationaryFlag الخاص بـ Employee
    /// </summary>
    public decimal? ProbationaryFlag { get; private set; }

    /// <summary>
    /// InsuranceOthers of the Employee
    /// InsuranceOthers الخاص بـ Employee
    /// </summary>
    public decimal? InsuranceOthers { get; private set; }

    /// <summary>
    /// EmpInsrnceRto of the Employee
    /// EmpInsrnceRto الخاص بـ Employee
    /// </summary>
    public decimal? EmpInsrnceRto { get; private set; }

    /// <summary>
    /// EmpInsrnceAmt of the Employee
    /// EmpInsrnceAmt الخاص بـ Employee
    /// </summary>
    public decimal? EmpInsrnceAmt { get; private set; }

    /// <summary>
    /// InsuranceCurrencyCode of the Employee
    /// InsuranceCurrencyCode الخاص بـ Employee
    /// </summary>
    public string InsuranceCurrencyCode { get; private set; }

    /// <summary>
    /// InactiveFlag of the Employee
    /// InactiveFlag الخاص بـ Employee
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Employee
    /// InactivatedByUserId الخاص بـ Employee
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the Employee
    /// InactiveDate الخاص بـ Employee
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Employee
    /// InactiveReason الخاص بـ Employee
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// Field1 of the Employee
    /// Field1 الخاص بـ Employee
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field10 of the Employee
    /// Field10 الخاص بـ Employee
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field11 of the Employee
    /// Field11 الخاص بـ Employee
    /// </summary>
    public string Field11 { get; private set; }

    /// <summary>
    /// Field12 of the Employee
    /// Field12 الخاص بـ Employee
    /// </summary>
    public string Field12 { get; private set; }

    /// <summary>
    /// Field13 of the Employee
    /// Field13 الخاص بـ Employee
    /// </summary>
    public string Field13 { get; private set; }

    /// <summary>
    /// Field14 of the Employee
    /// Field14 الخاص بـ Employee
    /// </summary>
    public string Field14 { get; private set; }

    /// <summary>
    /// Field15 of the Employee
    /// Field15 الخاص بـ Employee
    /// </summary>
    public string Field15 { get; private set; }

    /// <summary>
    /// Field16 of the Employee
    /// Field16 الخاص بـ Employee
    /// </summary>
    public string Field16 { get; private set; }

    /// <summary>
    /// Field17 of the Employee
    /// Field17 الخاص بـ Employee
    /// </summary>
    public string Field17 { get; private set; }

    /// <summary>
    /// Field18 of the Employee
    /// Field18 الخاص بـ Employee
    /// </summary>
    public string Field18 { get; private set; }

    /// <summary>
    /// Field19 of the Employee
    /// Field19 الخاص بـ Employee
    /// </summary>
    public string Field19 { get; private set; }

    /// <summary>
    /// Field2 of the Employee
    /// Field2 الخاص بـ Employee
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field20 of the Employee
    /// Field20 الخاص بـ Employee
    /// </summary>
    public string Field20 { get; private set; }

    /// <summary>
    /// Field3 of the Employee
    /// Field3 الخاص بـ Employee
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Employee
    /// Field4 الخاص بـ Employee
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Employee
    /// Field5 الخاص بـ Employee
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Employee
    /// Field6 الخاص بـ Employee
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Employee
    /// Field7 الخاص بـ Employee
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Employee
    /// Field8 الخاص بـ Employee
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Employee
    /// Field9 الخاص بـ Employee
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// SocialSecurityNumber of the Employee
    /// SocialSecurityNumber الخاص بـ Employee
    /// </summary>
    public decimal? SocialSecurityNumber { get; private set; }

    /// <summary>
    /// ReinstatementDate of the Employee
    /// ReinstatementDate الخاص بـ Employee
    /// </summary>
    public DateTime? ReinstatementDate { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Employee
    /// ProvinceNumber الخاص بـ Employee
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// WorkPeriodType of the Employee
    /// WorkPeriodType الخاص بـ Employee
    /// </summary>
    public decimal? WorkPeriodType { get; private set; }

    /// <summary>
    /// EmpCntrctTyp of the Employee
    /// EmpCntrctTyp الخاص بـ Employee
    /// </summary>
    public decimal? EmpCntrctTyp { get; private set; }

    /// <summary>
    /// EmpTrckMthd of the Employee
    /// EmpTrckMthd الخاص بـ Employee
    /// </summary>
    public decimal? EmpTrckMthd { get; private set; }

    /// <summary>
    /// FeedLimitAmount of the Employee
    /// FeedLimitAmount الخاص بـ Employee
    /// </summary>
    public decimal? FeedLimitAmount { get; private set; }

    /// <summary>
    /// FeedLimitType of the Employee
    /// FeedLimitType الخاص بـ Employee
    /// </summary>
    public decimal? FeedLimitType { get; private set; }

    /// <summary>
    /// EndWorkType of the Employee
    /// EndWorkType الخاص بـ Employee
    /// </summary>
    public decimal? EndWorkType { get; private set; }

    /// <summary>
    /// EmpMdclStrtDate of the Employee
    /// EmpMdclStrtDate الخاص بـ Employee
    /// </summary>
    public DateTime? EmpMdclStrtDate { get; private set; }

    /// <summary>
    /// EmpMdclEndDate of the Employee
    /// EmpMdclEndDate الخاص بـ Employee
    /// </summary>
    public DateTime? EmpMdclEndDate { get; private set; }

    /// <summary>
    /// DfltLawArtclVal of the Employee
    /// DfltLawArtclVal الخاص بـ Employee
    /// </summary>
    public decimal? DfltLawArtclVal { get; private set; }

    /// <summary>
    /// EmpAttndncTyp of the Employee
    /// EmpAttndncTyp الخاص بـ Employee
    /// </summary>
    public decimal? EmpAttndncTyp { get; private set; }

    /// <summary>
    /// AttendanceMobileType of the Employee
    /// AttendanceMobileType الخاص بـ Employee
    /// </summary>
    public decimal? AttendanceMobileType { get; private set; }

    /// <summary>
    /// MobileCaptureImageType of the Employee
    /// MobileCaptureImageType الخاص بـ Employee
    /// </summary>
    public decimal? MobileCaptureImageType { get; private set; }

    /// <summary>
    /// AttendanceTimezone of the Employee
    /// AttendanceTimezone الخاص بـ Employee
    /// </summary>
    public string AttendanceTimezone { get; private set; }

    /// <summary>
    /// MobileConnectType of the Employee
    /// MobileConnectType الخاص بـ Employee
    /// </summary>
    public decimal? MobileConnectType { get; private set; }

    /// <summary>
    /// AttendanceMobileSerial of the Employee
    /// AttendanceMobileSerial الخاص بـ Employee
    /// </summary>
    public string AttendanceMobileSerial { get; private set; }

    /// <summary>
    /// UseAttendanceLocation of the Employee
    /// UseAttendanceLocation الخاص بـ Employee
    /// </summary>
    public decimal? UseAttendanceLocation { get; private set; }

    /// <summary>
    /// MobileAttendanceSync of the Employee
    /// MobileAttendanceSync الخاص بـ Employee
    /// </summary>
    public decimal? MobileAttendanceSync { get; private set; }

    /// <summary>
    /// Facebook of the Employee
    /// Facebook الخاص بـ Employee
    /// </summary>
    public string Facebook { get; private set; }

    /// <summary>
    /// Twitter of the Employee
    /// Twitter الخاص بـ Employee
    /// </summary>
    public string Twitter { get; private set; }

    /// <summary>
    /// Instagram of the Employee
    /// Instagram الخاص بـ Employee
    /// </summary>
    public string Instagram { get; private set; }

    /// <summary>
    /// Telegram of the Employee
    /// Telegram الخاص بـ Employee
    /// </summary>
    public string Telegram { get; private set; }

    /// <summary>
    /// WeeklyDayoffCalculationStatus of the Employee
    /// WeeklyDayoffCalculationStatus الخاص بـ Employee
    /// </summary>
    public decimal? WeeklyDayoffCalculationStatus { get; private set; }

    /// <summary>
    /// WeeklyDayoffShiftDaysRequired of the Employee
    /// WeeklyDayoffShiftDaysRequired الخاص بـ Employee
    /// </summary>
    public decimal? WeeklyDayoffShiftDaysRequired { get; private set; }

    /// <summary>
    /// WeeklyDayoffRegularDaysRequired of the Employee
    /// WeeklyDayoffRegularDaysRequired الخاص بـ Employee
    /// </summary>
    public decimal? WeeklyDayoffRegularDaysRequired { get; private set; }

    /// <summary>
    /// WeeklyDayoffCompareEqual of the Employee
    /// WeeklyDayoffCompareEqual الخاص بـ Employee
    /// </summary>
    public decimal? WeeklyDayoffCompareEqual { get; private set; }

    /// <summary>
    /// WeeklyDayoffReferenceHolidayNumber of the Employee
    /// WeeklyDayoffReferenceHolidayNumber الخاص بـ Employee
    /// </summary>
    public decimal? WeeklyDayoffReferenceHolidayNumber { get; private set; }

    /// <summary>
    /// WeekDays of the Employee
    /// WeekDays الخاص بـ Employee
    /// </summary>
    public decimal? WeekDays { get; private set; }

    /// <summary>
    /// EmpMdclAgeLmt of the Employee
    /// EmpMdclAgeLmt الخاص بـ Employee
    /// </summary>
    public decimal? EmpMdclAgeLmt { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Employee Employee { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Employee EmployeeEmpNoMngr2 { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Hierarchy Hierarchy { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Collection relationship: ManyToOne
    /// </summary>
    public ICollection<Employee> Employees => _employees;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
