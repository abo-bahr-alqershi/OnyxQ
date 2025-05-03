using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a company in the ERP system
/// يمثل الشركة في نظام تخطيط موارد المؤسسات
/// اسم الجدول: S_CMPNY
/// Table name: S_CMPNY
/// </summary>
public class Company : AuditableEntity, IAggregateRoot
{
    private readonly List<Branch> _branches = new();

    #region Properties

    /// <summary>
    /// رقم الشركة - المفتاح الرئيسي
    /// Company number - Primary Key
    /// </summary>
    public int CompanyNumber { get; private set; }

    /// <summary>
    /// اسم الشركة باللغة المحلية
    /// Company name in local language
    /// </summary>
    public string LocalizedName { get; private set; }

    /// <summary>
    /// اسم الشركة باللغة الأجنبية
    /// Company name in foreign language
    /// </summary>
    public string ForeignName { get; private set; }

    /// <summary>
    /// الاسم المختصر للشركة باللغة المحلية
    /// Company short name in local language
    /// </summary>
    public string LocalizedShortName { get; private set; }

    /// <summary>
    /// الاسم المختصر للشركة باللغة الأجنبية
    /// Company short name in foreign language
    /// </summary>
    public string ForeignShortName { get; private set; }

    /// <summary>
    /// معلومات الاتصال بالشركة
    /// Company contact information
    /// </summary>
    public CompanyContactInfo ContactInfo { get; private set; }

    /// <summary>
    /// معلومات العنوان
    /// Address information
    /// </summary>
    public CompanyAddress Address { get; private set; }

    /// <summary>
    /// الرقم التجاري للشركة
    /// Company commercial registration number
    /// </summary>
    public string CommercialRegistrationNumber { get; private set; }

    /// <summary>
    /// تاريخ انتهاء التسجيل التجاري
    /// Company commercial registration expiry date
    /// </summary>
    public DateTime? CommercialRegistrationExpiryDate { get; private set; }

    /// <summary>
    /// الرقم الضريبي للشركة
    /// Company tax registration number
    /// </summary>
    public string TaxRegistrationNumber { get; private set; }

    /// <summary>
    /// السنة المالية الحالية
    /// Current fiscal year
    /// </summary>
    public int CurrentFiscalYear { get; private set; }

    /// <summary>
    /// تاريخ بداية السنة المالية
    /// Fiscal year start date
    /// </summary>
    public DateTime FiscalYearStartDate { get; private set; }

    /// <summary>
    /// العملة الافتراضية للشركة
    /// Default currency for the company
    /// </summary>
    public string DefaultCurrencyCode { get; private set; }

    /// <summary>
    /// حالة الشركة
    /// Company status
    /// </summary>
    public bool IsActive { get; private set; }

    /// <summary>
    /// التسلسل الهرمي للشركة
    /// Company hierarchy
    /// </summary>
    public int? HierarchyId { get; private set; }

    /// <summary>
    /// ما إذا كانت الشركة عبر الإنترنت متصلة
    /// Whether the company is web connected
    /// </summary>
    public bool IsWebConnected { get; private set; }

    #endregion

    #region Navigation Properties

    /// <summary>
    /// الفروع التابعة للشركة
    /// Company branches
    /// </summary>
    public IReadOnlyCollection<Branch> Branches => _branches.AsReadOnly();

    /// <summary>
    /// العملة الافتراضية للشركة
    /// Default currency for the company
    /// </summary>
    public virtual Currency DefaultCurrency { get; private set; }
    public int DefaultCurrencyId { get; private set; }

    /// <summary>
    /// مركز التكلفة الافتراضي
    /// Default cost center
    /// </summary>
    public virtual CostCenter DefaultCostCenter { get; private set; }
    public string DefaultCostCenterId { get; private set; }

    /// <summary>
    /// التسلسل الهرمي للشركة
    /// Company hierarchy
    /// </summary>
    public virtual Hierarchy CompanyHierarchy { get; private set; }

    #endregion

    #region Constructors

    private Company() { } // Required by EF Core

    public Company(
        int companyNumber,
        string localizedName,
        string foreignName,
        string localizedShortName,
        string foreignShortName,
        CompanyAddress address,
        CompanyContactInfo contactInfo,
        string commercialRegistrationNumber,
        DateTime? commercialRegistrationExpiryDate,
        string taxRegistrationNumber,
        DateTime fiscalYearStartDate,
        string defaultCurrencyCode,
        bool isActive,
        int? hierarchyId,
        bool isWebConnected)
    {
        CompanyNumber = companyNumber;
        LocalizedName = localizedName;
        ForeignName = foreignName;
        LocalizedShortName = localizedShortName;
        ForeignShortName = foreignShortName;
        Address = address;
        ContactInfo = contactInfo;
        CommercialRegistrationNumber = commercialRegistrationNumber;
        CommercialRegistrationExpiryDate = commercialRegistrationExpiryDate;
        TaxRegistrationNumber = taxRegistrationNumber;
        FiscalYearStartDate = fiscalYearStartDate;
        DefaultCurrencyCode = defaultCurrencyCode;
        IsActive = isActive;
        HierarchyId = hierarchyId;
        IsWebConnected = isWebConnected;

        AddDomainEvent(new CompanyCreatedEvent(this));
    }

    #endregion

    #region Methods

    /// <summary>
    /// إضافة فرع جديد للشركة
    /// Add a new branch to the company
    /// </summary>
    public void AddBranch(Branch branch)
    {
        _branches.Add(branch);
        AddDomainEvent(new BranchAddedToCompanyEvent(this, branch));
    }

    /// <summary>
    /// تحديث معلومات الشركة
    /// Update company information
    /// </summary>
    public void UpdateCompanyInformation(
        string localizedName,
        string foreignName,
        string localizedShortName,
        string foreignShortName,
        CompanyAddress address,
        CompanyContactInfo contactInfo,
        string commercialRegistrationNumber,
        DateTime? commercialRegistrationExpiryDate,
        string taxRegistrationNumber)
    {
        LocalizedName = localizedName;
        ForeignName = foreignName;
        LocalizedShortName = localizedShortName;
        ForeignShortName = foreignShortName;
        Address = address;
        ContactInfo = contactInfo;
        CommercialRegistrationNumber = commercialRegistrationNumber;
        CommercialRegistrationExpiryDate = commercialRegistrationExpiryDate;
        TaxRegistrationNumber = taxRegistrationNumber;

        AddDomainEvent(new CompanyUpdatedEvent(this));
    }

    /// <summary>
    /// تحديث السنة المالية
    /// Update fiscal year
    /// </summary>
    public void ChangeFiscalYearStartDate(DateTime newStartDate)
    {
        var oldStartDate = FiscalYearStartDate;
        FiscalYearStartDate = newStartDate;

        AddDomainEvent(new CompanyFiscalYearChangedEvent(this, oldStartDate, newStartDate));
    }

    /// <summary>
    /// تغيير العملة الافتراضية
    /// Change default currency
    /// </summary>
    public void ChangeDefaultCurrency(string newCurrencyCode)
    {
        var oldCurrencyCode = DefaultCurrencyCode;
        DefaultCurrencyCode = newCurrencyCode;

        AddDomainEvent(new CompanyDefaultCurrencyChangedEvent(this, oldCurrencyCode, newCurrencyCode));
    }

    /// <summary>
    /// تغيير حالة الشركة
    /// Change company status
    /// </summary>
    public void ChangeStatus(bool isActive)
    {
        var oldStatus = IsActive;
        IsActive = isActive;

        AddDomainEvent(new CompanyStatusChangedEvent(this, oldStatus, isActive));
    }

    /// <summary>
    /// تعيين التسلسل الهرمي للشركة
    /// Set company hierarchy
    /// </summary>
    public void ChangeHierarchy(int? newHierarchyId)
    {
        var oldHierarchyId = HierarchyId;
        HierarchyId = newHierarchyId;

        AddDomainEvent(new CompanyHierarchyChangedEvent(this, oldHierarchyId, newHierarchyId));
    }

    #endregion
} 