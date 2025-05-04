using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerRequest Entity
/// </summary>
public class CustomerRequest : Entity<CustomerRequestId>
{
    private CustomerRequest() { }

    /// <summary>
    /// The unique identifier for the CustomerRequest
    /// المعرف الفريد لـ CustomerRequest
    /// </summary>
    public CustomerRequestId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerRequest
    /// CCode الخاص بـ CustomerRequest
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CAName of the CustomerRequest
    /// CAName الخاص بـ CustomerRequest
    /// </summary>
    public string CAName { get; private set; }

    /// <summary>
    /// CEName of the CustomerRequest
    /// CEName الخاص بـ CustomerRequest
    /// </summary>
    public string CEName { get; private set; }

    /// <summary>
    /// CACode of the CustomerRequest
    /// CACode الخاص بـ CustomerRequest
    /// </summary>
    public string CACode { get; private set; }

    /// <summary>
    /// CstSeq of the CustomerRequest
    /// CstSeq الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CstSeq { get; private set; }

    /// <summary>
    /// CGroupCode of the CustomerRequest
    /// CGroupCode الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CTaxCode of the CustomerRequest
    /// CTaxCode الخاص بـ CustomerRequest
    /// </summary>
    public string CTaxCode { get; private set; }

    /// <summary>
    /// CBoxCode of the CustomerRequest
    /// CBoxCode الخاص بـ CustomerRequest
    /// </summary>
    public string CBoxCode { get; private set; }

    /// <summary>
    /// CAddress of the CustomerRequest
    /// CAddress الخاص بـ CustomerRequest
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// CountryNumber of the CustomerRequest
    /// CountryNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the CustomerRequest
    /// ProvinceNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the CustomerRequest
    /// CityNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the CustomerRequest
    /// RegionCode الخاص بـ CustomerRequest
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RepCode of the CustomerRequest
    /// RepCode الخاص بـ CustomerRequest
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// RouteNumber of the CustomerRequest
    /// RouteNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? RouteNumber { get; private set; }

    /// <summary>
    /// SortInRoute of the CustomerRequest
    /// SortInRoute الخاص بـ CustomerRequest
    /// </summary>
    public decimal? SortInRoute { get; private set; }

    /// <summary>
    /// Gps of the CustomerRequest
    /// Gps الخاص بـ CustomerRequest
    /// </summary>
    public string Gps { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CustomerRequest
    /// ColumnNumberShort الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CostCenterCode of the CustomerRequest
    /// CostCenterCode الخاص بـ CustomerRequest
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CreditPeriod of the CustomerRequest
    /// CreditPeriod الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CreditPeriod { get; private set; }

    /// <summary>
    /// CPhone of the CustomerRequest
    /// CPhone الخاص بـ CustomerRequest
    /// </summary>
    public string CPhone { get; private set; }

    /// <summary>
    /// CFax of the CustomerRequest
    /// CFax الخاص بـ CustomerRequest
    /// </summary>
    public string CFax { get; private set; }

    /// <summary>
    /// CBox of the CustomerRequest
    /// CBox الخاص بـ CustomerRequest
    /// </summary>
    public string CBox { get; private set; }

    /// <summary>
    /// CPerson of the CustomerRequest
    /// CPerson الخاص بـ CustomerRequest
    /// </summary>
    public string CPerson { get; private set; }

    /// <summary>
    /// CEMail of the CustomerRequest
    /// CEMail الخاص بـ CustomerRequest
    /// </summary>
    public string CEMail { get; private set; }

    /// <summary>
    /// CWebSite of the CustomerRequest
    /// CWebSite الخاص بـ CustomerRequest
    /// </summary>
    public string CWebSite { get; private set; }

    /// <summary>
    /// CClass of the CustomerRequest
    /// CClass الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CDegree of the CustomerRequest
    /// CDegree الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CDegree { get; private set; }

    /// <summary>
    /// CMobile of the CustomerRequest
    /// CMobile الخاص بـ CustomerRequest
    /// </summary>
    public string CMobile { get; private set; }

    /// <summary>
    /// CSince of the CustomerRequest
    /// CSince الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? CSince { get; private set; }

    /// <summary>
    /// InactiveFlag of the CustomerRequest
    /// InactiveFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CustomerRequest
    /// InactiveReason الخاص بـ CustomerRequest
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CustomerRequest
    /// InactiveDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// CVendor of the CustomerRequest
    /// CVendor الخاص بـ CustomerRequest
    /// </summary>
    public string CVendor { get; private set; }

    /// <summary>
    /// CNote of the CustomerRequest
    /// CNote الخاص بـ CustomerRequest
    /// </summary>
    public string CNote { get; private set; }

    /// <summary>
    /// DiscPer of the CustomerRequest
    /// DiscPer الخاص بـ CustomerRequest
    /// </summary>
    public decimal? DiscPer { get; private set; }

    /// <summary>
    /// ConnectionRemoteSystem of the CustomerRequest
    /// ConnectionRemoteSystem الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ConnectionRemoteSystem { get; private set; }

    /// <summary>
    /// InactiveSales of the CustomerRequest
    /// InactiveSales الخاص بـ CustomerRequest
    /// </summary>
    public decimal? InactiveSales { get; private set; }

    /// <summary>
    /// GuarantorName of the CustomerRequest
    /// GuarantorName الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorName { get; private set; }

    /// <summary>
    /// GuarantorAddress of the CustomerRequest
    /// GuarantorAddress الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorAddress { get; private set; }

    /// <summary>
    /// GuarantorStartDate of the CustomerRequest
    /// GuarantorStartDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? GuarantorStartDate { get; private set; }

    /// <summary>
    /// GuarantorExpireDate of the CustomerRequest
    /// GuarantorExpireDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? GuarantorExpireDate { get; private set; }

    /// <summary>
    /// GuarantorType of the CustomerRequest
    /// GuarantorType الخاص بـ CustomerRequest
    /// </summary>
    public decimal? GuarantorType { get; private set; }

    /// <summary>
    /// GuarantorAmount of the CustomerRequest
    /// GuarantorAmount الخاص بـ CustomerRequest
    /// </summary>
    public decimal? GuarantorAmount { get; private set; }

    /// <summary>
    /// GuarantorStatus of the CustomerRequest
    /// GuarantorStatus الخاص بـ CustomerRequest
    /// </summary>
    public decimal? GuarantorStatus { get; private set; }

    /// <summary>
    /// GuarantorFinancialCenter of the CustomerRequest
    /// GuarantorFinancialCenter الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorFinancialCenter { get; private set; }

    /// <summary>
    /// GuarantorWork of the CustomerRequest
    /// GuarantorWork الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorWork { get; private set; }

    /// <summary>
    /// GuarantorDocumentDate of the CustomerRequest
    /// GuarantorDocumentDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? GuarantorDocumentDate { get; private set; }

    /// <summary>
    /// GuarantorRegisterCourt of the CustomerRequest
    /// GuarantorRegisterCourt الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorRegisterCourt { get; private set; }

    /// <summary>
    /// GuarantorRegisterTrade of the CustomerRequest
    /// GuarantorRegisterTrade الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorRegisterTrade { get; private set; }

    /// <summary>
    /// GuarantorFileTrade of the CustomerRequest
    /// GuarantorFileTrade الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorFileTrade { get; private set; }

    /// <summary>
    /// GuarantorTelephone of the CustomerRequest
    /// GuarantorTelephone الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorTelephone { get; private set; }

    /// <summary>
    /// GuarantorFax of the CustomerRequest
    /// GuarantorFax الخاص بـ CustomerRequest
    /// </summary>
    public string GuarantorFax { get; private set; }

    /// <summary>
    /// BlackListFlag of the CustomerRequest
    /// BlackListFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? BlackListFlag { get; private set; }

    /// <summary>
    /// BlackListReason of the CustomerRequest
    /// BlackListReason الخاص بـ CustomerRequest
    /// </summary>
    public string BlackListReason { get; private set; }

    /// <summary>
    /// CSalesMan of the CustomerRequest
    /// CSalesMan الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CSalesMan { get; private set; }

    /// <summary>
    /// LicenseNumber of the CustomerRequest
    /// LicenseNumber الخاص بـ CustomerRequest
    /// </summary>
    public string LicenseNumber { get; private set; }

    /// <summary>
    /// LicenseOwner of the CustomerRequest
    /// LicenseOwner الخاص بـ CustomerRequest
    /// </summary>
    public string LicenseOwner { get; private set; }

    /// <summary>
    /// ResponsiblePerson of the CustomerRequest
    /// ResponsiblePerson الخاص بـ CustomerRequest
    /// </summary>
    public string ResponsiblePerson { get; private set; }

    /// <summary>
    /// SignatoryPerson of the CustomerRequest
    /// SignatoryPerson الخاص بـ CustomerRequest
    /// </summary>
    public string SignatoryPerson { get; private set; }

    /// <summary>
    /// SerialNumber of the CustomerRequest
    /// SerialNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? SerialNumber { get; private set; }

    /// <summary>
    /// DriverNo of the CustomerRequest
    /// DriverNo الخاص بـ CustomerRequest
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// AccountOperationNumber of the CustomerRequest
    /// AccountOperationNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? AccountOperationNumber { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the CustomerRequest
    /// ImportExcelFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// CParent of the CustomerRequest
    /// CParent الخاص بـ CustomerRequest
    /// </summary>
    public string CParent { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the CustomerRequest
    /// ConnectionBranchNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// SendMessageFlag of the CustomerRequest
    /// SendMessageFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? SendMessageFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the CustomerRequest
    /// ApprovalUserId الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the CustomerRequest
    /// ApprovalDescription الخاص بـ CustomerRequest
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ApprovalDate of the CustomerRequest
    /// ApprovalDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovedFlag of the CustomerRequest
    /// ApprovedFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// DocSrl of the CustomerRequest
    /// DocSrl الخاص بـ CustomerRequest
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CustomerRequest
    /// CompanyNumberShort الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchYear of the CustomerRequest
    /// BranchYear الخاص بـ CustomerRequest
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CustomerRequest
    /// BranchUser الخاص بـ CustomerRequest
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CashCost of the CustomerRequest
    /// CashCost الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CashCost { get; private set; }

    /// <summary>
    /// ResponsiblePersonJob of the CustomerRequest
    /// ResponsiblePersonJob الخاص بـ CustomerRequest
    /// </summary>
    public string ResponsiblePersonJob { get; private set; }

    /// <summary>
    /// CustomerCreditLimitLocal of the CustomerRequest
    /// CustomerCreditLimitLocal الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerCreditLimitLocal { get; private set; }

    /// <summary>
    /// CustomerInvoiceLimitLocal of the CustomerRequest
    /// CustomerInvoiceLimitLocal الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerInvoiceLimitLocal { get; private set; }

    /// <summary>
    /// CustomerLimitType of the CustomerRequest
    /// CustomerLimitType الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerLimitType { get; private set; }

    /// <summary>
    /// CustomerLimitPercent of the CustomerRequest
    /// CustomerLimitPercent الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerLimitPercent { get; private set; }

    /// <summary>
    /// CreditEndDateHijri of the CustomerRequest
    /// CreditEndDateHijri الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? CreditEndDateHijri { get; private set; }

    /// <summary>
    /// CreditIssueDateHijri of the CustomerRequest
    /// CreditIssueDateHijri الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? CreditIssueDateHijri { get; private set; }

    /// <summary>
    /// BirthDate of the CustomerRequest
    /// BirthDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? BirthDate { get; private set; }

    /// <summary>
    /// BirthDateHijri of the CustomerRequest
    /// BirthDateHijri الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? BirthDateHijri { get; private set; }

    /// <summary>
    /// BirthPlace of the CustomerRequest
    /// BirthPlace الخاص بـ CustomerRequest
    /// </summary>
    public string BirthPlace { get; private set; }

    /// <summary>
    /// WorkPlace of the CustomerRequest
    /// WorkPlace الخاص بـ CustomerRequest
    /// </summary>
    public string WorkPlace { get; private set; }

    /// <summary>
    /// SourceIncome of the CustomerRequest
    /// SourceIncome الخاص بـ CustomerRequest
    /// </summary>
    public string SourceIncome { get; private set; }

    /// <summary>
    /// SourceIncomeRate of the CustomerRequest
    /// SourceIncomeRate الخاص بـ CustomerRequest
    /// </summary>
    public decimal? SourceIncomeRate { get; private set; }

    /// <summary>
    /// MaritalStatus of the CustomerRequest
    /// MaritalStatus الخاص بـ CustomerRequest
    /// </summary>
    public decimal? MaritalStatus { get; private set; }

    /// <summary>
    /// CompanyWork of the CustomerRequest
    /// CompanyWork الخاص بـ CustomerRequest
    /// </summary>
    public string CompanyWork { get; private set; }

    /// <summary>
    /// CFinscanStatus of the CustomerRequest
    /// CFinscanStatus الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CFinscanStatus { get; private set; }

    /// <summary>
    /// OpenFileDate of the CustomerRequest
    /// OpenFileDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? OpenFileDate { get; private set; }

    /// <summary>
    /// EndFileDate of the CustomerRequest
    /// EndFileDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? EndFileDate { get; private set; }

    /// <summary>
    /// HomeAddress of the CustomerRequest
    /// HomeAddress الخاص بـ CustomerRequest
    /// </summary>
    public string HomeAddress { get; private set; }

    /// <summary>
    /// SignatureImageName of the CustomerRequest
    /// SignatureImageName الخاص بـ CustomerRequest
    /// </summary>
    public string SignatureImageName { get; private set; }

    /// <summary>
    /// PassportNumber of the CustomerRequest
    /// PassportNumber الخاص بـ CustomerRequest
    /// </summary>
    public string PassportNumber { get; private set; }

    /// <summary>
    /// PassportIssuePlace of the CustomerRequest
    /// PassportIssuePlace الخاص بـ CustomerRequest
    /// </summary>
    public string PassportIssuePlace { get; private set; }

    /// <summary>
    /// PassportIssueDate of the CustomerRequest
    /// PassportIssueDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? PassportIssueDate { get; private set; }

    /// <summary>
    /// PassportEndDate of the CustomerRequest
    /// PassportEndDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? PassportEndDate { get; private set; }

    /// <summary>
    /// NameInPassport of the CustomerRequest
    /// NameInPassport الخاص بـ CustomerRequest
    /// </summary>
    public string NameInPassport { get; private set; }

    /// <summary>
    /// AdditionalIncomeSource of the CustomerRequest
    /// AdditionalIncomeSource الخاص بـ CustomerRequest
    /// </summary>
    public decimal? AdditionalIncomeSource { get; private set; }

    /// <summary>
    /// AdditionalIncomeRate of the CustomerRequest
    /// AdditionalIncomeRate الخاص بـ CustomerRequest
    /// </summary>
    public decimal? AdditionalIncomeRate { get; private set; }

    /// <summary>
    /// CountRemainMonthExpected of the CustomerRequest
    /// CountRemainMonthExpected الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CountRemainMonthExpected { get; private set; }

    /// <summary>
    /// OtherCompanyBank of the CustomerRequest
    /// OtherCompanyBank الخاص بـ CustomerRequest
    /// </summary>
    public string OtherCompanyBank { get; private set; }

    /// <summary>
    /// CommissionRegisterNumber of the CustomerRequest
    /// CommissionRegisterNumber الخاص بـ CustomerRequest
    /// </summary>
    public string CommissionRegisterNumber { get; private set; }

    /// <summary>
    /// RegistrationIssuePlace of the CustomerRequest
    /// RegistrationIssuePlace الخاص بـ CustomerRequest
    /// </summary>
    public string RegistrationIssuePlace { get; private set; }

    /// <summary>
    /// RegistrationIssueDate of the CustomerRequest
    /// RegistrationIssueDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? RegistrationIssueDate { get; private set; }

    /// <summary>
    /// RegistrationEndDate of the CustomerRequest
    /// RegistrationEndDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? RegistrationEndDate { get; private set; }

    /// <summary>
    /// CompanyActivity of the CustomerRequest
    /// CompanyActivity الخاص بـ CustomerRequest
    /// </summary>
    public string CompanyActivity { get; private set; }

    /// <summary>
    /// CustomerGCC of the CustomerRequest
    /// CustomerGCC الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerGCC { get; private set; }

    /// <summary>
    /// CustomerFileUploadDate of the CustomerRequest
    /// CustomerFileUploadDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? CustomerFileUploadDate { get; private set; }

    /// <summary>
    /// CustomerBenefitType of the CustomerRequest
    /// CustomerBenefitType الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerBenefitType { get; private set; }

    /// <summary>
    /// CustomerMainImageName of the CustomerRequest
    /// CustomerMainImageName الخاص بـ CustomerRequest
    /// </summary>
    public string CustomerMainImageName { get; private set; }

    /// <summary>
    /// CreatedUserPhoto of the CustomerRequest
    /// CreatedUserPhoto الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CreatedUserPhoto { get; private set; }

    /// <summary>
    /// CstVatGrpFlg of the CustomerRequest
    /// CstVatGrpFlg الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CstVatGrpFlg { get; private set; }

    /// <summary>
    /// CustomerDealFlag of the CustomerRequest
    /// CustomerDealFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerDealFlag { get; private set; }

    /// <summary>
    /// CustomerExceptionQuotationPremiumFlag of the CustomerRequest
    /// CustomerExceptionQuotationPremiumFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerExceptionQuotationPremiumFlag { get; private set; }

    /// <summary>
    /// CustomerExchangeFlag of the CustomerRequest
    /// CustomerExchangeFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CustomerExchangeFlag { get; private set; }

    /// <summary>
    /// CClassTyp of the CustomerRequest
    /// CClassTyp الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CClassTyp { get; private set; }

    /// <summary>
    /// CRisk of the CustomerRequest
    /// CRisk الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CRisk { get; private set; }

    /// <summary>
    /// CBusSec of the CustomerRequest
    /// CBusSec الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CBusSec { get; private set; }

    /// <summary>
    /// CPerFee of the CustomerRequest
    /// CPerFee الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CPerFee { get; private set; }

    /// <summary>
    /// CAcctFee of the CustomerRequest
    /// CAcctFee الخاص بـ CustomerRequest
    /// </summary>
    public string CAcctFee { get; private set; }

    /// <summary>
    /// AutoApprovedFlag of the CustomerRequest
    /// AutoApprovedFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? AutoApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalRiskUserId of the CustomerRequest
    /// ApprovalRiskUserId الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ApprovalRiskUserId { get; private set; }

    /// <summary>
    /// ApprovalRiskDescription of the CustomerRequest
    /// ApprovalRiskDescription الخاص بـ CustomerRequest
    /// </summary>
    public string ApprovalRiskDescription { get; private set; }

    /// <summary>
    /// ApprovalRiskDate of the CustomerRequest
    /// ApprovalRiskDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? ApprovalRiskDate { get; private set; }

    /// <summary>
    /// ApprovedRisk of the CustomerRequest
    /// ApprovedRisk الخاص بـ CustomerRequest
    /// </summary>
    public decimal? ApprovedRisk { get; private set; }

    /// <summary>
    /// Field1 of the CustomerRequest
    /// Field1 الخاص بـ CustomerRequest
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the CustomerRequest
    /// Field2 الخاص بـ CustomerRequest
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the CustomerRequest
    /// Field3 الخاص بـ CustomerRequest
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the CustomerRequest
    /// Field4 الخاص بـ CustomerRequest
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the CustomerRequest
    /// Field5 الخاص بـ CustomerRequest
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the CustomerRequest
    /// Field6 الخاص بـ CustomerRequest
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the CustomerRequest
    /// Field7 الخاص بـ CustomerRequest
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the CustomerRequest
    /// Field8 الخاص بـ CustomerRequest
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the CustomerRequest
    /// Field9 الخاص بـ CustomerRequest
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the CustomerRequest
    /// Field10 الخاص بـ CustomerRequest
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field11 of the CustomerRequest
    /// Field11 الخاص بـ CustomerRequest
    /// </summary>
    public string Field11 { get; private set; }

    /// <summary>
    /// Field12 of the CustomerRequest
    /// Field12 الخاص بـ CustomerRequest
    /// </summary>
    public string Field12 { get; private set; }

    /// <summary>
    /// Field13 of the CustomerRequest
    /// Field13 الخاص بـ CustomerRequest
    /// </summary>
    public string Field13 { get; private set; }

    /// <summary>
    /// Field14 of the CustomerRequest
    /// Field14 الخاص بـ CustomerRequest
    /// </summary>
    public string Field14 { get; private set; }

    /// <summary>
    /// Field15 of the CustomerRequest
    /// Field15 الخاص بـ CustomerRequest
    /// </summary>
    public string Field15 { get; private set; }

    /// <summary>
    /// Field16 of the CustomerRequest
    /// Field16 الخاص بـ CustomerRequest
    /// </summary>
    public string Field16 { get; private set; }

    /// <summary>
    /// Field17 of the CustomerRequest
    /// Field17 الخاص بـ CustomerRequest
    /// </summary>
    public string Field17 { get; private set; }

    /// <summary>
    /// Field18 of the CustomerRequest
    /// Field18 الخاص بـ CustomerRequest
    /// </summary>
    public string Field18 { get; private set; }

    /// <summary>
    /// Field19 of the CustomerRequest
    /// Field19 الخاص بـ CustomerRequest
    /// </summary>
    public string Field19 { get; private set; }

    /// <summary>
    /// Field20 of the CustomerRequest
    /// Field20 الخاص بـ CustomerRequest
    /// </summary>
    public string Field20 { get; private set; }

    /// <summary>
    /// Latitude of the CustomerRequest
    /// Latitude الخاص بـ CustomerRequest
    /// </summary>
    public string Latitude { get; private set; }

    /// <summary>
    /// Longitude of the CustomerRequest
    /// Longitude الخاص بـ CustomerRequest
    /// </summary>
    public string Longitude { get; private set; }

    /// <summary>
    /// GpsColor of the CustomerRequest
    /// GpsColor الخاص بـ CustomerRequest
    /// </summary>
    public string GpsColor { get; private set; }

    /// <summary>
    /// FavoriteAccountFlag of the CustomerRequest
    /// FavoriteAccountFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? FavoriteAccountFlag { get; private set; }

    /// <summary>
    /// FActiveDate of the CustomerRequest
    /// FActiveDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? FActiveDate { get; private set; }

    /// <summary>
    /// TActiveDate of the CustomerRequest
    /// TActiveDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? TActiveDate { get; private set; }

    /// <summary>
    /// SecretKey of the CustomerRequest
    /// SecretKey الخاص بـ CustomerRequest
    /// </summary>
    public string SecretKey { get; private set; }

    /// <summary>
    /// AllowProductAfterDue of the CustomerRequest
    /// AllowProductAfterDue الخاص بـ CustomerRequest
    /// </summary>
    public decimal? AllowProductAfterDue { get; private set; }

    /// <summary>
    /// BlackListDate of the CustomerRequest
    /// BlackListDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? BlackListDate { get; private set; }

    /// <summary>
    /// CAge of the CustomerRequest
    /// CAge الخاص بـ CustomerRequest
    /// </summary>
    public string CAge { get; private set; }

    /// <summary>
    /// CGender of the CustomerRequest
    /// CGender الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CGender { get; private set; }

    /// <summary>
    /// InsuranceNumberAlt of the CustomerRequest
    /// InsuranceNumberAlt الخاص بـ CustomerRequest
    /// </summary>
    public string InsuranceNumberAlt { get; private set; }

    /// <summary>
    /// ApprovalNumber of the CustomerRequest
    /// ApprovalNumber الخاص بـ CustomerRequest
    /// </summary>
    public string ApprovalNumber { get; private set; }

    /// <summary>
    /// CInsurance of the CustomerRequest
    /// CInsurance الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CInsurance { get; private set; }

    /// <summary>
    /// CCodeTrgt of the CustomerRequest
    /// CCodeTrgt الخاص بـ CustomerRequest
    /// </summary>
    public string CCodeTrgt { get; private set; }

    /// <summary>
    /// InsuranceCost of the CustomerRequest
    /// InsuranceCost الخاص بـ CustomerRequest
    /// </summary>
    public decimal? InsuranceCost { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the CustomerRequest
    /// InsuranceCompanyNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// NationalityNumber of the CustomerRequest
    /// NationalityNumber الخاص بـ CustomerRequest
    /// </summary>
    public decimal? NationalityNumber { get; private set; }

    /// <summary>
    /// TypeCredit of the CustomerRequest
    /// TypeCredit الخاص بـ CustomerRequest
    /// </summary>
    public decimal? TypeCredit { get; private set; }

    /// <summary>
    /// CreditNumber of the CustomerRequest
    /// CreditNumber الخاص بـ CustomerRequest
    /// </summary>
    public string CreditNumber { get; private set; }

    /// <summary>
    /// CreditIssuePlace of the CustomerRequest
    /// CreditIssuePlace الخاص بـ CustomerRequest
    /// </summary>
    public string CreditIssuePlace { get; private set; }

    /// <summary>
    /// CreditIssueDate of the CustomerRequest
    /// CreditIssueDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? CreditIssueDate { get; private set; }

    /// <summary>
    /// CreditEndDate of the CustomerRequest
    /// CreditEndDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? CreditEndDate { get; private set; }

    /// <summary>
    /// CreditNumberShort of the CustomerRequest
    /// CreditNumberShort الخاص بـ CustomerRequest
    /// </summary>
    public string CreditNumberShort { get; private set; }

    /// <summary>
    /// ActivityName of the CustomerRequest
    /// ActivityName الخاص بـ CustomerRequest
    /// </summary>
    public string ActivityName { get; private set; }

    /// <summary>
    /// NisNumber of the CustomerRequest
    /// NisNumber الخاص بـ CustomerRequest
    /// </summary>
    public string NisNumber { get; private set; }

    /// <summary>
    /// NaiDescription of the CustomerRequest
    /// NaiDescription الخاص بـ CustomerRequest
    /// </summary>
    public string NaiDescription { get; private set; }

    /// <summary>
    /// EquipmentCapital of the CustomerRequest
    /// EquipmentCapital الخاص بـ CustomerRequest
    /// </summary>
    public string EquipmentCapital { get; private set; }

    /// <summary>
    /// AgentFlag of the CustomerRequest
    /// AgentFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? AgentFlag { get; private set; }

    /// <summary>
    /// CIdPlace of the CustomerRequest
    /// CIdPlace الخاص بـ CustomerRequest
    /// </summary>
    public string CIdPlace { get; private set; }

    /// <summary>
    /// CId of the CustomerRequest
    /// CId الخاص بـ CustomerRequest
    /// </summary>
    public string CId { get; private set; }

    /// <summary>
    /// CIdIssDate of the CustomerRequest
    /// CIdIssDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? CIdIssDate { get; private set; }

    /// <summary>
    /// CIdExpDate of the CustomerRequest
    /// CIdExpDate الخاص بـ CustomerRequest
    /// </summary>
    public DateTime? CIdExpDate { get; private set; }

    /// <summary>
    /// CProff of the CustomerRequest
    /// CProff الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CProff { get; private set; }

    /// <summary>
    /// CIdType of the CustomerRequest
    /// CIdType الخاص بـ CustomerRequest
    /// </summary>
    public decimal? CIdType { get; private set; }

    /// <summary>
    /// InsertedFlagAlt of the CustomerRequest
    /// InsertedFlagAlt الخاص بـ CustomerRequest
    /// </summary>
    public decimal? InsertedFlagAlt { get; private set; }

    /// <summary>
    /// PoliticalRelationFlag of the CustomerRequest
    /// PoliticalRelationFlag الخاص بـ CustomerRequest
    /// </summary>
    public decimal? PoliticalRelationFlag { get; private set; }

    /// <summary>
    /// PoliticalRelationWith of the CustomerRequest
    /// PoliticalRelationWith الخاص بـ CustomerRequest
    /// </summary>
    public string PoliticalRelationWith { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// ManyToOne relationship to City
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Country
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerClass
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerDegree
    /// </summary>
    public CustomerDegree CustomerDegree { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerGroup
    /// </summary>
    public CustomerGroup CustomerGroup { get; private set; }
    #endregion
}
}
