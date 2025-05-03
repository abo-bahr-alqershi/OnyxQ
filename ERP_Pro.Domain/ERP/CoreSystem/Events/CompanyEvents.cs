using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a new company is created
/// حدث يتم رفعه عند إنشاء شركة جديدة
/// </summary>
public class CompanyCreatedEvent : DomainEvent
{
    public Company Company { get; }

    public CompanyCreatedEvent(Company company)
    {
        Company = company;
    }
}

/// <summary>
/// Event raised when company information is updated
/// حدث يتم رفعه عند تحديث معلومات الشركة
/// </summary>
public class CompanyUpdatedEvent : DomainEvent
{
    public Company Company { get; }

    public CompanyUpdatedEvent(Company company)
    {
        Company = company;
    }
}

/// <summary>
/// حدث إضافة فرع جديد للشركة
/// New branch addition event
/// </summary>
public class BranchAddedToCompanyEvent : DomainEvent
{
    public Company Company { get; }
    public Branch Branch { get; }
    public BranchAddedToCompanyEvent(Company company, Branch branch)
    {
        Company = company;
        Branch = branch;
    }
}

/// <summary>
/// Event raised when company fiscal year start date is changed
/// حدث يتم رفعه عند تغيير تاريخ بداية السنة المالية للشركة
/// </summary>
public class CompanyFiscalYearChangedEvent : DomainEvent
{
    public Company Company { get; }
    public DateTime OldStartDate { get; }
    public DateTime NewStartDate { get; }

    public CompanyFiscalYearChangedEvent(Company company, DateTime oldStartDate, DateTime newStartDate)
    {
        Company = company;
        OldStartDate = oldStartDate;
        NewStartDate = newStartDate;
    }
}

/// <summary>
/// Event raised when company default currency is changed
/// حدث يتم رفعه عند تغيير العملة الافتراضية للشركة
/// </summary>
public class CompanyDefaultCurrencyChangedEvent : DomainEvent
{
    public Company Company { get; }
    public string OldCurrencyCode { get; }
    public string NewCurrencyCode { get; }

    public CompanyDefaultCurrencyChangedEvent(Company company, string oldCurrencyCode, string newCurrencyCode)
    {
        Company = company;
        OldCurrencyCode = oldCurrencyCode;
        NewCurrencyCode = newCurrencyCode;
    }
}

/// <summary>
/// Event raised when company status is changed
/// حدث يتم رفعه عند تغيير حالة الشركة
/// </summary>
public class CompanyStatusChangedEvent : DomainEvent
{
    public Company Company { get; }
    public bool OldStatus { get; }
    public bool NewStatus { get; }

    public CompanyStatusChangedEvent(Company company, bool oldStatus, bool newStatus)
    {
        Company = company;
        OldStatus = oldStatus;
        NewStatus = newStatus;
    }
}

/// <summary>
/// Event raised when company hierarchy is changed
/// حدث يتم رفعه عند تغيير التسلسل الهرمي للشركة
/// </summary>
public class CompanyHierarchyChangedEvent : DomainEvent
{
    public Company Company { get; }
    public int? OldHierarchyId { get; }
    public int? NewHierarchyId { get; }

    public CompanyHierarchyChangedEvent(Company company, int? oldHierarchyId, int? newHierarchyId)
    {
        Company = company;
        OldHierarchyId = oldHierarchyId;
        NewHierarchyId = newHierarchyId;
    }
} 