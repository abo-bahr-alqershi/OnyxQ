using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// يمثل هذا النموذج الفرع في النظام
/// Represents a branch in the system
/// رقم الموديل: 2
/// Model number: 2
/// اسم الجدول: S_BRN
/// Table name: S_BRN
/// </summary>
public class Branch : AuditableEntity, IAggregateRoot
{
    private readonly List<BranchDocument> _documents = new();
    private readonly List<BranchUserPrivilege> _userPrivileges = new();

    #region Properties

    /// <summary>
    /// رقم الفرع - المفتاح الرئيسي
    /// Branch number - Primary Key
    /// </summary>
    public int BranchNo { get; private set; }

    /// <summary>
    /// رقم الشركة
    /// Company number
    /// </summary>
    public int CompanyNo { get; private set; }

    /// <summary>
    /// رقم الفرع الأب
    /// Parent branch number
    /// </summary>
    public int? ParentBranchNo { get; private set; }

    /// <summary>
    /// مجموعة الشركة
    /// Company group
    /// </summary>
    public int CompanyGroup { get; private set; }

    /// <summary>
    /// اسم الفرع باللغة المحلية
    /// Branch name in local language
    /// </summary>
    public string LocalName { get; private set; }

    /// <summary>
    /// اسم الفرع باللغة الأجنبية
    /// Branch name in foreign language
    /// </summary>
    public string ForeignName { get; private set; }

    /// <summary>
    /// معلومات الاتصال بالفرع
    /// Branch contact information
    /// </summary>
    public BranchContactInfo ContactInfo { get; private set; }

    /// <summary>
    /// عنوان الفرع
    /// Branch address
    /// </summary>
    public BranchAddress Address { get; private set; }

    /// <summary>
    /// حالة الفرع
    /// Branch status
    /// </summary>
    public BranchStatus Status { get; private set; }

    /// <summary>
    /// رمز الفرع
    /// Branch code
    /// </summary>
    public string BranchCode { get; private set; }

    /// <summary>
    /// فرع محلي
    /// Is local branch
    /// </summary>
    public bool IsLocal { get; private set; }

    /// <summary>
    /// فرع خفيف
    /// Is light branch
    /// </summary>
    public bool IsLight { get; private set; }

    /// <summary>
    /// الرقم الضريبي للفرع
    /// Branch tax code
    /// </summary>
    public string TaxCode { get; private set; }

    /// <summary>
    /// رمز الضمان الاجتماعي
    /// Social security code
    /// </summary>
    public string SocialSecurityCode { get; private set; }

    /// <summary>
    /// حالة النشاط
    /// Activity status
    /// </summary>
    public bool IsInactive { get; private set; }

    /// <summary>
    /// تاريخ عدم النشاط
    /// Inactivity date
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// سبب عدم النشاط
    /// Inactivity reason
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// رأس المال
    /// Capital
    /// </summary>
    public decimal? Capital { get; private set; }

    /// <summary>
    /// الموقع الإلكتروني للضرائب
    /// Tax website
    /// </summary>
    public string TaxWebsite { get; private set; }

    #endregion

    #region Navigation Properties

    /// <summary>
    /// الشركة التابع لها الفرع
    /// Company that owns the branch
    /// </summary>
    public virtual Company Company { get; private set; }

    /// <summary>
    /// الفرع الأب
    /// Parent branch
    /// </summary>
    public virtual Branch ParentBranch { get; private set; }

    /// <summary>
    /// الفروع التابعة
    /// Child branches
    /// </summary>
    public virtual ICollection<Branch> ChildBranches { get; private set; } = new HashSet<Branch>();

    /// <summary>
    /// مجموعة الفرع
    /// Branch group
    /// </summary>
    public virtual BranchGroup BranchGroup { get; private set; }
    public int BranchGroupId { get; private set; }

    /// <summary>
    /// المنطقة
    /// Region
    /// </summary>
    public virtual Region Region { get; private set; }
    public int? RegionId { get; private set; }

    /// <summary>
    /// المدينة
    /// City
    /// </summary>
    public virtual City City { get; private set; }
    public int? CityId { get; private set; }

    /// <summary>
    /// المحافظة
    /// Province
    /// </summary>
    public virtual Province Province { get; private set; }
    public int? ProvinceId { get; private set; }

    /// <summary>
    /// الدولة
    /// Country
    /// </summary>
    public virtual Country Country { get; private set; }
    public int? CountryId { get; private set; }

    /// <summary>
    /// وثائق الفرع
    /// Branch documents
    /// </summary>
    public IReadOnlyCollection<BranchDocument> Documents => _documents.AsReadOnly();

    /// <summary>
    /// صلاحيات المستخدمين على الفرع
    /// User privileges on the branch
    /// </summary>
    public IReadOnlyCollection<BranchUserPrivilege> UserPrivileges => _userPrivileges.AsReadOnly();

    #endregion

    #region Constructors

    private Branch() { } // Required by EF Core

    public Branch(
        int branchNo,
        int companyNo,
        int? parentBranchNo,
        int companyGroup,
        string localName,
        string foreignName,
        BranchContactInfo contactInfo,
        BranchAddress address,
        int branchGroupId,
        BranchStatus status = BranchStatus.Active)
    {
        BranchNo = branchNo;
        CompanyNo = companyNo;
        ParentBranchNo = parentBranchNo;
        CompanyGroup = companyGroup;
        LocalName = localName;
        ForeignName = foreignName;
        ContactInfo = contactInfo;
        Address = address;
        BranchGroupId = branchGroupId;
        Status = status;

        AddDomainEvent(new BranchCreatedEvent(this));
    }

    #endregion

    #region Methods

    /// <summary>
    /// تحديث معلومات الفرع
    /// Update branch information
    /// </summary>
    public void UpdateBranchInfo(
        string localName,
        string foreignName,
        BranchContactInfo contactInfo,
        BranchAddress address)
    {
        LocalName = localName;
        ForeignName = foreignName;
        ContactInfo = contactInfo;
        Address = address;

        AddDomainEvent(new BranchUpdatedEvent(this));
    }

    /// <summary>
    /// تغيير حالة الفرع
    /// Change branch status
    /// </summary>
    public void ChangeStatus(BranchStatus newStatus)
    {
        var oldStatus = Status;
        Status = newStatus;

        AddDomainEvent(new BranchStatusChangedEvent(this, oldStatus, newStatus));
    }

    /// <summary>
    /// تغيير مجموعة الفرع
    /// Change branch group
    /// </summary>
    public void ChangeBranchGroup(int newBranchGroupId)
    {
        var oldBranchGroupId = BranchGroupId;
        BranchGroupId = newBranchGroupId;

        AddDomainEvent(new BranchGroupChangedEvent(this, oldBranchGroupId, newBranchGroupId));
    }

    /// <summary>
    /// تغيير الفرع الأب
    /// Change parent branch
    /// </summary>
    public void ChangeParentBranch(int? newParentBranchNo)
    {
        var oldParentBranchNo = ParentBranchNo;
        ParentBranchNo = newParentBranchNo;

        AddDomainEvent(new BranchParentChangedEvent(this, oldParentBranchNo, newParentBranchNo));
    }

    /// <summary>
    /// تحديث معلومات الموقع
    /// Update location information
    /// </summary>
    public void UpdateLocation(
        int? regionId = null,
        int? cityId = null,
        int? provinceId = null,
        int? countryId = null)
    {
        RegionId = regionId;
        CityId = cityId;
        ProvinceId = provinceId;
        CountryId = countryId;

        AddDomainEvent(new BranchLocationUpdatedEvent(this));
    }

    /// <summary>
    /// تغيير حالة النشاط
    /// Change activity status
    /// </summary>
    public void ChangeActivityStatus(bool isInactive, string reason = null)
    {
        var oldStatus = IsInactive;
        IsInactive = isInactive;
        InactiveReason = reason;
        InactiveDate = isInactive ? DateTime.Now : null;

        AddDomainEvent(new BranchActivityStatusChangedEvent(this, oldStatus, isInactive, reason));
    }

    /// <summary>
    /// إضافة وثيقة للفرع
    /// Add document to branch
    /// </summary>
    public void AddDocument(BranchDocument document)
    {
        _documents.Add(document);
        AddDomainEvent(new BranchDocumentAddedEvent(this, document));
    }

    /// <summary>
    /// إضافة صلاحية مستخدم للفرع
    /// Add user privilege to branch
    /// </summary>
    public void AddUserPrivilege(BranchUserPrivilege privilege)
    {
        _userPrivileges.Add(privilege);
        AddDomainEvent(new BranchUserPrivilegeAddedEvent(this, privilege));
    }

    #endregion
} 