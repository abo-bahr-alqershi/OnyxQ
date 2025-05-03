using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// يمثل هذا الكيان التسلسل الهرمي في النظام
/// This entity represents the hierarchy in the system
/// اسم الجدول: S_HRCHY
/// Table name: S_HRCHY
/// </summary>
public class Hierarchy : BaseAuditableEntity
{
    /// <summary>
    /// رقم التسلسل الهرمي
    /// Hierarchy Number
    /// </summary>
    public long HierarchyNo { get; private set; }

    /// <summary>
    /// الاسم المحلي للتسلسل الهرمي
    /// Local Hierarchy Name
    /// </summary>
    public string LocalName { get; private set; }

    /// <summary>
    /// الاسم الأجنبي للتسلسل الهرمي
    /// Foreign Hierarchy Name
    /// </summary>
    public string ForeignName { get; private set; }

    /// <summary>
    /// رقم التسلسل الهرمي الأب
    /// Parent Hierarchy Number
    /// </summary>
    public long? ParentHierarchyNo { get; private set; }

    /// <summary>
    /// رقم المستوى
    /// Level Number
    /// </summary>
    public int LevelNo { get; private set; }

    /// <summary>
    /// رقم النوع
    /// Type Number
    /// </summary>
    public int TypeNo { get; private set; }

    /// <summary>
    /// غير نشط
    /// Inactive
    /// </summary>
    public bool IsInactive { get; private set; }

    /// <summary>
    /// سبب عدم النشاط
    /// Inactive Reason
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// رقم مستخدم عدم النشاط
    /// Inactive User ID
    /// </summary>
    public int? InactiveUserId { get; private set; }

    /// <summary>
    /// تاريخ عدم النشاط
    /// Inactive Date
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// رمز التسلسل الهرمي
    /// Hierarchy Code
    /// </summary>
    public string HierarchyCode { get; private set; }

    /// <summary>
    /// حالة التسلسل الهرمي
    /// Hierarchy Status
    /// </summary>
    public HierarchyStatus Status { get; private set; }

    /// <summary>
    /// العلاقة مع التسلسل الهرمي الأب
    /// Parent Hierarchy Navigation Property
    /// </summary>
    public Hierarchy ParentHierarchy { get; private set; }

    /// <summary>
    /// العلاقة مع نوع التسلسل الهرمي
    /// Hierarchy Type Navigation Property
    /// </summary>
    public HierarchyType Type { get; private set; }

    private Hierarchy() { }

    public static Hierarchy Create(
        long hierarchyNo,
        string localName,
        string foreignName,
        long? parentHierarchyNo,
        int levelNo,
        int typeNo,
        string hierarchyCode)
    {
        var hierarchy = new Hierarchy
        {
            HierarchyNo = hierarchyNo,
            LocalName = localName,
            ForeignName = foreignName,
            ParentHierarchyNo = parentHierarchyNo,
            LevelNo = levelNo,
            TypeNo = typeNo,
            HierarchyCode = hierarchyCode,
            Status = HierarchyStatus.Active,
            IsInactive = false
        };

        hierarchy.AddDomainEvent(new HierarchyCreatedEvent(hierarchy));
        return hierarchy;
    }

    public void Update(
        string localName,
        string foreignName,
        long? parentHierarchyNo,
        int levelNo,
        string hierarchyCode)
    {
        LocalName = localName;
        ForeignName = foreignName;
        ParentHierarchyNo = parentHierarchyNo;
        LevelNo = levelNo;
        HierarchyCode = hierarchyCode;

        AddDomainEvent(new HierarchyUpdatedEvent(this));
    }

    public void SetInactive(string reason, int userId)
    {
        IsInactive = true;
        InactiveReason = reason;
        InactiveUserId = userId;
        InactiveDate = DateTime.UtcNow;
        Status = HierarchyStatus.Inactive;

        AddDomainEvent(new HierarchyInactivatedEvent(this));
    }

    public void SetActive()
    {
        IsInactive = false;
        InactiveReason = null;
        InactiveUserId = null;
        InactiveDate = null;
        Status = HierarchyStatus.Active;

        AddDomainEvent(new HierarchyActivatedEvent(this));
    }
} 