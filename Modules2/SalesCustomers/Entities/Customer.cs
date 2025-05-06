using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.StationsFuel.Entities;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// Customer Entity
/// </summary>
public class Customer : Entity<CustomerId>
{

    private Customer() { }

    public Customer(CustomerId id, string cCode)
    {
        Id = id;
        CCode = cCode;
    }

    /// <summary>
    /// The unique identifier for the Customer
    /// المعرف الفريد لـ Customer
    /// </summary>
    public CustomerId Id { get; private set; }

    /// <summary>
    /// CCode of the Customer
    /// CCode الخاص بـ Customer
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CAName of the Customer
    /// CAName الخاص بـ Customer
    /// </summary>
    public string CAName { get; private set; }

    /// <summary>
    /// CEName of the Customer
    /// CEName الخاص بـ Customer
    /// </summary>
    public string CEName { get; private set; }

    /// <summary>
    /// CstSeq of the Customer
    /// CstSeq الخاص بـ Customer
    /// </summary>
    public decimal? CstSeq { get; private set; }

    /// <summary>
    /// CTaxCode of the Customer
    /// CTaxCode الخاص بـ Customer
    /// </summary>
    public string CTaxCode { get; private set; }

    /// <summary>
    /// CBoxCode of the Customer
    /// CBoxCode الخاص بـ Customer
    /// </summary>
    public string CBoxCode { get; private set; }

    /// <summary>
    /// CAddress of the Customer
    /// CAddress الخاص بـ Customer
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Customer
    /// ProvinceNumber الخاص بـ Customer
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// RouteNumber of the Customer
    /// RouteNumber الخاص بـ Customer
    /// </summary>
    public decimal? RouteNumber { get; private set; }

    /// <summary>
    /// SortInRoute of the Customer
    /// SortInRoute الخاص بـ Customer
    /// </summary>
    public decimal? SortInRoute { get; private set; }

    /// <summary>
    /// Gps of the Customer
    /// Gps الخاص بـ Customer
    /// </summary>
    public string Gps { get; private set; }

    /// <summary>
    /// CreditPeriod of the Customer
    /// CreditPeriod الخاص بـ Customer
    /// </summary>
    public decimal? CreditPeriod { get; private set; }

    /// <summary>
    /// CPhone of the Customer
    /// CPhone الخاص بـ Customer
    /// </summary>
    public string CPhone { get; private set; }

    /// <summary>
    /// CFax of the Customer
    /// CFax الخاص بـ Customer
    /// </summary>
    public string CFax { get; private set; }

    /// <summary>
    /// CBox of the Customer
    /// CBox الخاص بـ Customer
    /// </summary>
    public string CBox { get; private set; }

    /// <summary>
    /// CPerson of the Customer
    /// CPerson الخاص بـ Customer
    /// </summary>
    public string CPerson { get; private set; }

    /// <summary>
    /// CEMail of the Customer
    /// CEMail الخاص بـ Customer
    /// </summary>
    public string CEMail { get; private set; }

    /// <summary>
    /// CWebSite of the Customer
    /// CWebSite الخاص بـ Customer
    /// </summary>
    public string CWebSite { get; private set; }

    /// <summary>
    /// CMobile of the Customer
    /// CMobile الخاص بـ Customer
    /// </summary>
    public string CMobile { get; private set; }

    /// <summary>
    /// CSince of the Customer
    /// CSince الخاص بـ Customer
    /// </summary>
    public DateTime? CSince { get; private set; }

    /// <summary>
    /// InactiveFlag of the Customer
    /// InactiveFlag الخاص بـ Customer
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the Customer
    /// InactiveReason الخاص بـ Customer
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the Customer
    /// InactiveDate الخاص بـ Customer
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// CVendor of the Customer
    /// CVendor الخاص بـ Customer
    /// </summary>
    public string CVendor { get; private set; }

    /// <summary>
    /// CNote of the Customer
    /// CNote الخاص بـ Customer
    /// </summary>
    public string CNote { get; private set; }

    /// <summary>
    /// DiscPer of the Customer
    /// DiscPer الخاص بـ Customer
    /// </summary>
    public decimal? DiscPer { get; private set; }

    /// <summary>
    /// ConfigLastDate of the Customer
    /// ConfigLastDate الخاص بـ Customer
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

    /// <summary>
    /// ConnectionRemoteSystem of the Customer
    /// ConnectionRemoteSystem الخاص بـ Customer
    /// </summary>
    public decimal? ConnectionRemoteSystem { get; private set; }

    /// <summary>
    /// InactiveSales of the Customer
    /// InactiveSales الخاص بـ Customer
    /// </summary>
    public decimal? InactiveSales { get; private set; }

    /// <summary>
    /// GuarantorName of the Customer
    /// GuarantorName الخاص بـ Customer
    /// </summary>
    public string GuarantorName { get; private set; }

    /// <summary>
    /// GuarantorAddress of the Customer
    /// GuarantorAddress الخاص بـ Customer
    /// </summary>
    public string GuarantorAddress { get; private set; }

    /// <summary>
    /// GuarantorStartDate of the Customer
    /// GuarantorStartDate الخاص بـ Customer
    /// </summary>
    public DateTime? GuarantorStartDate { get; private set; }

    /// <summary>
    /// GuarantorExpireDate of the Customer
    /// GuarantorExpireDate الخاص بـ Customer
    /// </summary>
    public DateTime? GuarantorExpireDate { get; private set; }

    /// <summary>
    /// GuarantorType of the Customer
    /// GuarantorType الخاص بـ Customer
    /// </summary>
    public decimal? GuarantorType { get; private set; }

    /// <summary>
    /// GuarantorAmount of the Customer
    /// GuarantorAmount الخاص بـ Customer
    /// </summary>
    public decimal? GuarantorAmount { get; private set; }

    /// <summary>
    /// GuarantorStatus of the Customer
    /// GuarantorStatus الخاص بـ Customer
    /// </summary>
    public decimal? GuarantorStatus { get; private set; }

    /// <summary>
    /// GuarantorFinancialCenter of the Customer
    /// GuarantorFinancialCenter الخاص بـ Customer
    /// </summary>
    public string GuarantorFinancialCenter { get; private set; }

    /// <summary>
    /// GuarantorWork of the Customer
    /// GuarantorWork الخاص بـ Customer
    /// </summary>
    public string GuarantorWork { get; private set; }

    /// <summary>
    /// GuarantorDocumentDate of the Customer
    /// GuarantorDocumentDate الخاص بـ Customer
    /// </summary>
    public DateTime? GuarantorDocumentDate { get; private set; }

    /// <summary>
    /// GuarantorRegisterCourt of the Customer
    /// GuarantorRegisterCourt الخاص بـ Customer
    /// </summary>
    public string GuarantorRegisterCourt { get; private set; }

    /// <summary>
    /// GuarantorRegisterTrade of the Customer
    /// GuarantorRegisterTrade الخاص بـ Customer
    /// </summary>
    public string GuarantorRegisterTrade { get; private set; }

    /// <summary>
    /// GuarantorFileTrade of the Customer
    /// GuarantorFileTrade الخاص بـ Customer
    /// </summary>
    public string GuarantorFileTrade { get; private set; }

    /// <summary>
    /// GuarantorTelephone of the Customer
    /// GuarantorTelephone الخاص بـ Customer
    /// </summary>
    public string GuarantorTelephone { get; private set; }

    /// <summary>
    /// GuarantorFax of the Customer
    /// GuarantorFax الخاص بـ Customer
    /// </summary>
    public string GuarantorFax { get; private set; }

    /// <summary>
    /// BlackListFlag of the Customer
    /// BlackListFlag الخاص بـ Customer
    /// </summary>
    public decimal? BlackListFlag { get; private set; }

    /// <summary>
    /// BlackListReason of the Customer
    /// BlackListReason الخاص بـ Customer
    /// </summary>
    public string BlackListReason { get; private set; }

    /// <summary>
    /// CSalesMan of the Customer
    /// CSalesMan الخاص بـ Customer
    /// </summary>
    public decimal? CSalesMan { get; private set; }

    /// <summary>
    /// LicenseNumber of the Customer
    /// LicenseNumber الخاص بـ Customer
    /// </summary>
    public string LicenseNumber { get; private set; }

    /// <summary>
    /// LicenseOwner of the Customer
    /// LicenseOwner الخاص بـ Customer
    /// </summary>
    public string LicenseOwner { get; private set; }

    /// <summary>
    /// ResponsiblePerson of the Customer
    /// ResponsiblePerson الخاص بـ Customer
    /// </summary>
    public string ResponsiblePerson { get; private set; }

    /// <summary>
    /// SignatoryPerson of the Customer
    /// SignatoryPerson الخاص بـ Customer
    /// </summary>
    public string SignatoryPerson { get; private set; }

    /// <summary>
    /// SerialNumber of the Customer
    /// SerialNumber الخاص بـ Customer
    /// </summary>
    public decimal? SerialNumber { get; private set; }

    /// <summary>
    /// DriverNo of the Customer
    /// DriverNo الخاص بـ Customer
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// AccountOperationNumber of the Customer
    /// AccountOperationNumber الخاص بـ Customer
    /// </summary>
    public decimal? AccountOperationNumber { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the Customer
    /// ImportExcelFlag الخاص بـ Customer
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// CParent of the Customer
    /// CParent الخاص بـ Customer
    /// </summary>
    public string CParent { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the Customer
    /// ConnectionBranchNumber الخاص بـ Customer
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// SendMessageFlag of the Customer
    /// SendMessageFlag الخاص بـ Customer
    /// </summary>
    public decimal? SendMessageFlag { get; private set; }

    /// <summary>
    /// Latitude of the Customer
    /// Latitude الخاص بـ Customer
    /// </summary>
    public string Latitude { get; private set; }

    /// <summary>
    /// Longitude of the Customer
    /// Longitude الخاص بـ Customer
    /// </summary>
    public string Longitude { get; private set; }

    /// <summary>
    /// GpsColor of the Customer
    /// GpsColor الخاص بـ Customer
    /// </summary>
    public string GpsColor { get; private set; }

    /// <summary>
    /// FavoriteAccountFlag of the Customer
    /// FavoriteAccountFlag الخاص بـ Customer
    /// </summary>
    public decimal? FavoriteAccountFlag { get; private set; }

    /// <summary>
    /// FActiveDate of the Customer
    /// FActiveDate الخاص بـ Customer
    /// </summary>
    public DateTime? FActiveDate { get; private set; }

    /// <summary>
    /// TActiveDate of the Customer
    /// TActiveDate الخاص بـ Customer
    /// </summary>
    public DateTime? TActiveDate { get; private set; }

    /// <summary>
    /// SecretKey of the Customer
    /// SecretKey الخاص بـ Customer
    /// </summary>
    public string SecretKey { get; private set; }

    /// <summary>
    /// AllowProductAfterDue of the Customer
    /// AllowProductAfterDue الخاص بـ Customer
    /// </summary>
    public decimal? AllowProductAfterDue { get; private set; }

    /// <summary>
    /// BlackListDate of the Customer
    /// BlackListDate الخاص بـ Customer
    /// </summary>
    public DateTime? BlackListDate { get; private set; }

    /// <summary>
    /// CAge of the Customer
    /// CAge الخاص بـ Customer
    /// </summary>
    public string CAge { get; private set; }

    /// <summary>
    /// CGender of the Customer
    /// CGender الخاص بـ Customer
    /// </summary>
    public decimal? CGender { get; private set; }

    /// <summary>
    /// InsuranceNumberAlt of the Customer
    /// InsuranceNumberAlt الخاص بـ Customer
    /// </summary>
    public string InsuranceNumberAlt { get; private set; }

    /// <summary>
    /// ApprovalNumber of the Customer
    /// ApprovalNumber الخاص بـ Customer
    /// </summary>
    public string ApprovalNumber { get; private set; }

    /// <summary>
    /// CInsurance of the Customer
    /// CInsurance الخاص بـ Customer
    /// </summary>
    public decimal? CInsurance { get; private set; }

    /// <summary>
    /// CCodeTrgt of the Customer
    /// CCodeTrgt الخاص بـ Customer
    /// </summary>
    public string CCodeTrgt { get; private set; }

    /// <summary>
    /// InsuranceCost of the Customer
    /// InsuranceCost الخاص بـ Customer
    /// </summary>
    public decimal? InsuranceCost { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the Customer
    /// InsuranceCompanyNumber الخاص بـ Customer
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// NationalityNumber of the Customer
    /// NationalityNumber الخاص بـ Customer
    /// </summary>
    public decimal? NationalityNumber { get; private set; }

    /// <summary>
    /// TypeCredit of the Customer
    /// TypeCredit الخاص بـ Customer
    /// </summary>
    public decimal? TypeCredit { get; private set; }

    /// <summary>
    /// CreditNumber of the Customer
    /// CreditNumber الخاص بـ Customer
    /// </summary>
    public string CreditNumber { get; private set; }

    /// <summary>
    /// CreditIssuePlace of the Customer
    /// CreditIssuePlace الخاص بـ Customer
    /// </summary>
    public string CreditIssuePlace { get; private set; }

    /// <summary>
    /// CreditIssueDate of the Customer
    /// CreditIssueDate الخاص بـ Customer
    /// </summary>
    public DateTime? CreditIssueDate { get; private set; }

    /// <summary>
    /// CreditEndDate of the Customer
    /// CreditEndDate الخاص بـ Customer
    /// </summary>
    public DateTime? CreditEndDate { get; private set; }

    /// <summary>
    /// CProff of the Customer
    /// CProff الخاص بـ Customer
    /// </summary>
    public decimal? CProff { get; private set; }

    /// <summary>
    /// AgentFlag of the Customer
    /// AgentFlag الخاص بـ Customer
    /// </summary>
    public decimal? AgentFlag { get; private set; }

    /// <summary>
    /// CreditNumberShort of the Customer
    /// CreditNumberShort الخاص بـ Customer
    /// </summary>
    public string CreditNumberShort { get; private set; }

    /// <summary>
    /// ActivityName of the Customer
    /// ActivityName الخاص بـ Customer
    /// </summary>
    public string ActivityName { get; private set; }

    /// <summary>
    /// CCodeLgn of the Customer
    /// CCodeLgn الخاص بـ Customer
    /// </summary>
    public string CCodeLgn { get; private set; }

    /// <summary>
    /// NisNumber of the Customer
    /// NisNumber الخاص بـ Customer
    /// </summary>
    public string NisNumber { get; private set; }

    /// <summary>
    /// NaiDescription of the Customer
    /// NaiDescription الخاص بـ Customer
    /// </summary>
    public string NaiDescription { get; private set; }

    /// <summary>
    /// CashCost of the Customer
    /// CashCost الخاص بـ Customer
    /// </summary>
    public decimal? CashCost { get; private set; }

    /// <summary>
    /// EquipmentCapital of the Customer
    /// EquipmentCapital الخاص بـ Customer
    /// </summary>
    public string EquipmentCapital { get; private set; }

    /// <summary>
    /// ResponsiblePersonJob of the Customer
    /// ResponsiblePersonJob الخاص بـ Customer
    /// </summary>
    public string ResponsiblePersonJob { get; private set; }

    /// <summary>
    /// CustomerCreditLimitLocal of the Customer
    /// CustomerCreditLimitLocal الخاص بـ Customer
    /// </summary>
    public decimal? CustomerCreditLimitLocal { get; private set; }

    /// <summary>
    /// CustomerInvoiceLimitLocal of the Customer
    /// CustomerInvoiceLimitLocal الخاص بـ Customer
    /// </summary>
    public decimal? CustomerInvoiceLimitLocal { get; private set; }

    /// <summary>
    /// CustomerLimitType of the Customer
    /// CustomerLimitType الخاص بـ Customer
    /// </summary>
    public decimal? CustomerLimitType { get; private set; }

    /// <summary>
    /// CustomerLimitPercent of the Customer
    /// CustomerLimitPercent الخاص بـ Customer
    /// </summary>
    public decimal? CustomerLimitPercent { get; private set; }

    /// <summary>
    /// CreditEndDateHijri of the Customer
    /// CreditEndDateHijri الخاص بـ Customer
    /// </summary>
    public DateTime? CreditEndDateHijri { get; private set; }

    /// <summary>
    /// CreditIssueDateHijri of the Customer
    /// CreditIssueDateHijri الخاص بـ Customer
    /// </summary>
    public DateTime? CreditIssueDateHijri { get; private set; }

    /// <summary>
    /// BirthDate of the Customer
    /// BirthDate الخاص بـ Customer
    /// </summary>
    public DateTime? BirthDate { get; private set; }

    /// <summary>
    /// BirthDateHijri of the Customer
    /// BirthDateHijri الخاص بـ Customer
    /// </summary>
    public DateTime? BirthDateHijri { get; private set; }

    /// <summary>
    /// BirthPlace of the Customer
    /// BirthPlace الخاص بـ Customer
    /// </summary>
    public string BirthPlace { get; private set; }

    /// <summary>
    /// WorkPlace of the Customer
    /// WorkPlace الخاص بـ Customer
    /// </summary>
    public string WorkPlace { get; private set; }

    /// <summary>
    /// SourceIncome of the Customer
    /// SourceIncome الخاص بـ Customer
    /// </summary>
    public string SourceIncome { get; private set; }

    /// <summary>
    /// SourceIncomeRate of the Customer
    /// SourceIncomeRate الخاص بـ Customer
    /// </summary>
    public decimal? SourceIncomeRate { get; private set; }

    /// <summary>
    /// MaritalStatus of the Customer
    /// MaritalStatus الخاص بـ Customer
    /// </summary>
    public decimal? MaritalStatus { get; private set; }

    /// <summary>
    /// CompanyWork of the Customer
    /// CompanyWork الخاص بـ Customer
    /// </summary>
    public string CompanyWork { get; private set; }

    /// <summary>
    /// CFinscanStatus of the Customer
    /// CFinscanStatus الخاص بـ Customer
    /// </summary>
    public decimal? CFinscanStatus { get; private set; }

    /// <summary>
    /// OpenFileDate of the Customer
    /// OpenFileDate الخاص بـ Customer
    /// </summary>
    public DateTime? OpenFileDate { get; private set; }

    /// <summary>
    /// EndFileDate of the Customer
    /// EndFileDate الخاص بـ Customer
    /// </summary>
    public DateTime? EndFileDate { get; private set; }

    /// <summary>
    /// HomeAddress of the Customer
    /// HomeAddress الخاص بـ Customer
    /// </summary>
    public string HomeAddress { get; private set; }

    /// <summary>
    /// SignatureImageName of the Customer
    /// SignatureImageName الخاص بـ Customer
    /// </summary>
    public string SignatureImageName { get; private set; }

    /// <summary>
    /// PassportNumber of the Customer
    /// PassportNumber الخاص بـ Customer
    /// </summary>
    public string PassportNumber { get; private set; }

    /// <summary>
    /// PassportIssuePlace of the Customer
    /// PassportIssuePlace الخاص بـ Customer
    /// </summary>
    public string PassportIssuePlace { get; private set; }

    /// <summary>
    /// PassportIssueDate of the Customer
    /// PassportIssueDate الخاص بـ Customer
    /// </summary>
    public DateTime? PassportIssueDate { get; private set; }

    /// <summary>
    /// PassportEndDate of the Customer
    /// PassportEndDate الخاص بـ Customer
    /// </summary>
    public DateTime? PassportEndDate { get; private set; }

    /// <summary>
    /// NameInPassport of the Customer
    /// NameInPassport الخاص بـ Customer
    /// </summary>
    public string NameInPassport { get; private set; }

    /// <summary>
    /// AdditionalIncomeSource of the Customer
    /// AdditionalIncomeSource الخاص بـ Customer
    /// </summary>
    public decimal? AdditionalIncomeSource { get; private set; }

    /// <summary>
    /// AdditionalIncomeRate of the Customer
    /// AdditionalIncomeRate الخاص بـ Customer
    /// </summary>
    public decimal? AdditionalIncomeRate { get; private set; }

    /// <summary>
    /// CountRemainMonthExpected of the Customer
    /// CountRemainMonthExpected الخاص بـ Customer
    /// </summary>
    public decimal? CountRemainMonthExpected { get; private set; }

    /// <summary>
    /// OtherCompanyBank of the Customer
    /// OtherCompanyBank الخاص بـ Customer
    /// </summary>
    public string OtherCompanyBank { get; private set; }

    /// <summary>
    /// CommissionRegisterNumber of the Customer
    /// CommissionRegisterNumber الخاص بـ Customer
    /// </summary>
    public string CommissionRegisterNumber { get; private set; }

    /// <summary>
    /// RegistrationIssuePlace of the Customer
    /// RegistrationIssuePlace الخاص بـ Customer
    /// </summary>
    public string RegistrationIssuePlace { get; private set; }

    /// <summary>
    /// RegistrationIssueDate of the Customer
    /// RegistrationIssueDate الخاص بـ Customer
    /// </summary>
    public DateTime? RegistrationIssueDate { get; private set; }

    /// <summary>
    /// RegistrationEndDate of the Customer
    /// RegistrationEndDate الخاص بـ Customer
    /// </summary>
    public DateTime? RegistrationEndDate { get; private set; }

    /// <summary>
    /// CompanyActivity of the Customer
    /// CompanyActivity الخاص بـ Customer
    /// </summary>
    public string CompanyActivity { get; private set; }

    /// <summary>
    /// CustomerGCC of the Customer
    /// CustomerGCC الخاص بـ Customer
    /// </summary>
    public decimal? CustomerGCC { get; private set; }

    /// <summary>
    /// CustomerFileUploadDate of the Customer
    /// CustomerFileUploadDate الخاص بـ Customer
    /// </summary>
    public DateTime? CustomerFileUploadDate { get; private set; }

    /// <summary>
    /// CustomerBenefitType of the Customer
    /// CustomerBenefitType الخاص بـ Customer
    /// </summary>
    public decimal? CustomerBenefitType { get; private set; }

    /// <summary>
    /// CustomerMainImageName of the Customer
    /// CustomerMainImageName الخاص بـ Customer
    /// </summary>
    public string CustomerMainImageName { get; private set; }

    /// <summary>
    /// CstVatGrpFlg of the Customer
    /// CstVatGrpFlg الخاص بـ Customer
    /// </summary>
    public decimal? CstVatGrpFlg { get; private set; }

    /// <summary>
    /// CustomerDealFlag of the Customer
    /// CustomerDealFlag الخاص بـ Customer
    /// </summary>
    public decimal? CustomerDealFlag { get; private set; }

    /// <summary>
    /// CustomerExceptionQuotationPremiumFlag of the Customer
    /// CustomerExceptionQuotationPremiumFlag الخاص بـ Customer
    /// </summary>
    public decimal? CustomerExceptionQuotationPremiumFlag { get; private set; }

    /// <summary>
    /// CustomerExchangeFlag of the Customer
    /// CustomerExchangeFlag الخاص بـ Customer
    /// </summary>
    public decimal? CustomerExchangeFlag { get; private set; }

    /// <summary>
    /// CBusSec of the Customer
    /// CBusSec الخاص بـ Customer
    /// </summary>
    public decimal? CBusSec { get; private set; }

    /// <summary>
    /// CPerFee of the Customer
    /// CPerFee الخاص بـ Customer
    /// </summary>
    public decimal? CPerFee { get; private set; }

    /// <summary>
    /// CAcctFee of the Customer
    /// CAcctFee الخاص بـ Customer
    /// </summary>
    public string CAcctFee { get; private set; }

    /// <summary>
    /// AutoApprovedFlag of the Customer
    /// AutoApprovedFlag الخاص بـ Customer
    /// </summary>
    public decimal? AutoApprovedFlag { get; private set; }

    /// <summary>
    /// DiscPerDflt of the Customer
    /// DiscPerDflt الخاص بـ Customer
    /// </summary>
    public decimal? DiscPerDflt { get; private set; }

    /// <summary>
    /// AllowUpdateFixedPrice of the Customer
    /// AllowUpdateFixedPrice الخاص بـ Customer
    /// </summary>
    public decimal? AllowUpdateFixedPrice { get; private set; }

    /// <summary>
    /// Field1 of the Customer
    /// Field1 الخاص بـ Customer
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Customer
    /// Field2 الخاص بـ Customer
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Customer
    /// Field3 الخاص بـ Customer
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Customer
    /// Field4 الخاص بـ Customer
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Customer
    /// Field5 الخاص بـ Customer
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Customer
    /// Field6 الخاص بـ Customer
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Customer
    /// Field7 الخاص بـ Customer
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Customer
    /// Field8 الخاص بـ Customer
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Customer
    /// Field9 الخاص بـ Customer
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Customer
    /// Field10 الخاص بـ Customer
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field11 of the Customer
    /// Field11 الخاص بـ Customer
    /// </summary>
    public string Field11 { get; private set; }

    /// <summary>
    /// Field12 of the Customer
    /// Field12 الخاص بـ Customer
    /// </summary>
    public string Field12 { get; private set; }

    /// <summary>
    /// Field13 of the Customer
    /// Field13 الخاص بـ Customer
    /// </summary>
    public string Field13 { get; private set; }

    /// <summary>
    /// Field14 of the Customer
    /// Field14 الخاص بـ Customer
    /// </summary>
    public string Field14 { get; private set; }

    /// <summary>
    /// Field15 of the Customer
    /// Field15 الخاص بـ Customer
    /// </summary>
    public string Field15 { get; private set; }

    /// <summary>
    /// Field16 of the Customer
    /// Field16 الخاص بـ Customer
    /// </summary>
    public string Field16 { get; private set; }

    /// <summary>
    /// Field17 of the Customer
    /// Field17 الخاص بـ Customer
    /// </summary>
    public string Field17 { get; private set; }

    /// <summary>
    /// Field18 of the Customer
    /// Field18 الخاص بـ Customer
    /// </summary>
    public string Field18 { get; private set; }

    /// <summary>
    /// Field19 of the Customer
    /// Field19 الخاص بـ Customer
    /// </summary>
    public string Field19 { get; private set; }

    /// <summary>
    /// Field20 of the Customer
    /// Field20 الخاص بـ Customer
    /// </summary>
    public string Field20 { get; private set; }

    /// <summary>
    /// CreatedUserPhoto of the Customer
    /// CreatedUserPhoto الخاص بـ Customer
    /// </summary>
    public decimal? CreatedUserPhoto { get; private set; }

    /// <summary>
    /// CstRgstrTyp of the Customer
    /// CstRgstrTyp الخاص بـ Customer
    /// </summary>
    public decimal? CstRgstrTyp { get; private set; }

    /// <summary>
    /// ConnectionHospitalSystem of the Customer
    /// ConnectionHospitalSystem الخاص بـ Customer
    /// </summary>
    public decimal? ConnectionHospitalSystem { get; private set; }

    /// <summary>
    /// SectorType of the Customer
    /// SectorType الخاص بـ Customer
    /// </summary>
    public decimal? SectorType { get; private set; }

    /// <summary>
    /// PoliticalRelationFlag of the Customer
    /// PoliticalRelationFlag الخاص بـ Customer
    /// </summary>
    public decimal? PoliticalRelationFlag { get; private set; }

    /// <summary>
    /// PoliticalRelationWith of the Customer
    /// PoliticalRelationWith الخاص بـ Customer
    /// </summary>
    public string PoliticalRelationWith { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the Customer
    /// CalcTypeNumberTax الخاص بـ Customer
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CBarcode of the Customer
    /// CBarcode الخاص بـ Customer
    /// </summary>
    public string CBarcode { get; private set; }

    /// <summary>
    /// VisitOpenType of the Customer
    /// VisitOpenType الخاص بـ Customer
    /// </summary>
    public decimal? VisitOpenType { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the Customer
    /// CalcVatPriceType الخاص بـ Customer
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// GlnCode of the Customer
    /// GlnCode الخاص بـ Customer
    /// </summary>
    public string GlnCode { get; private set; }

    /// <summary>
    /// CMobDevSrl of the Customer
    /// CMobDevSrl الخاص بـ Customer
    /// </summary>
    public string CMobDevSrl { get; private set; }

    /// <summary>
    /// CSavLoginData of the Customer
    /// CSavLoginData الخاص بـ Customer
    /// </summary>
    public decimal? CSavLoginData { get; private set; }

    /// <summary>
    /// CRestPass of the Customer
    /// CRestPass الخاص بـ Customer
    /// </summary>
    public decimal? CRestPass { get; private set; }

    /// <summary>
    /// CVerfySmsCode of the Customer
    /// CVerfySmsCode الخاص بـ Customer
    /// </summary>
    public string CVerfySmsCode { get; private set; }

    /// <summary>
    /// WebServiceUseAutoSyncCustomer of the Customer
    /// WebServiceUseAutoSyncCustomer الخاص بـ Customer
    /// </summary>
    public decimal? WebServiceUseAutoSyncCustomer { get; private set; }

    /// <summary>
    /// WebServiceExternalCustomerCode of the Customer
    /// WebServiceExternalCustomerCode الخاص بـ Customer
    /// </summary>
    public string WebServiceExternalCustomerCode { get; private set; }

    /// <summary>
    /// WebServiceUserNumber of the Customer
    /// WebServiceUserNumber الخاص بـ Customer
    /// </summary>
    public string WebServiceUserNumber { get; private set; }

    /// <summary>
    /// WebServicePassword of the Customer
    /// WebServicePassword الخاص بـ Customer
    /// </summary>
    public string WebServicePassword { get; private set; }

    /// <summary>
    /// WebServiceLink of the Customer
    /// WebServiceLink الخاص بـ Customer
    /// </summary>
    public string WebServiceLink { get; private set; }

    /// <summary>
    /// PromoterCode of the Customer
    /// PromoterCode الخاص بـ Customer
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// EmpNo of the Customer
    /// EmpNo الخاص بـ Customer
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// DueType of the Customer
    /// DueType الخاص بـ Customer
    /// </summary>
    public decimal? DueType { get; private set; }

    /// <summary>
    /// AgentCustomerNumberSerial of the Customer
    /// AgentCustomerNumberSerial الخاص بـ Customer
    /// </summary>
    public string AgentCustomerNumberSerial { get; private set; }

    /// <summary>
    /// PeriodDay of the Customer
    /// PeriodDay الخاص بـ Customer
    /// </summary>
    public decimal? PeriodDay { get; private set; }

    /// <summary>
    /// ReportQuantityLimitCount of the Customer
    /// ReportQuantityLimitCount الخاص بـ Customer
    /// </summary>
    public decimal? ReportQuantityLimitCount { get; private set; }

    /// <summary>
    /// LimitItemQuantityType of the Customer
    /// LimitItemQuantityType الخاص بـ Customer
    /// </summary>
    public decimal? LimitItemQuantityType { get; private set; }

    /// <summary>
    /// ConfirmNote of the Customer
    /// ConfirmNote الخاص بـ Customer
    /// </summary>
    public string ConfirmNote { get; private set; }

    /// <summary>
    /// UseHolster of the Customer
    /// UseHolster الخاص بـ Customer
    /// </summary>
    public decimal? UseHolster { get; private set; }

    /// <summary>
    /// CompensationType of the Customer
    /// CompensationType الخاص بـ Customer
    /// </summary>
    public decimal? CompensationType { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the Customer
    /// ExternalPostFlag الخاص بـ Customer
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CustomerLightFlag of the Customer
    /// CustomerLightFlag الخاص بـ Customer
    /// </summary>
    public decimal? CustomerLightFlag { get; private set; }

    /// <summary>
    /// BuildingNumber of the Customer
    /// BuildingNumber الخاص بـ Customer
    /// </summary>
    public string BuildingNumber { get; private set; }

    /// <summary>
    /// Street of the Customer
    /// Street الخاص بـ Customer
    /// </summary>
    public string Street { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerClassType CustomerClassType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerDegree CustomerDegree { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerGroup CustomerGroup { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

