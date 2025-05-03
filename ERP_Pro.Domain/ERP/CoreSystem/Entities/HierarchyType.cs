using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// يمثل هذا النموذج نوع التسلسل الهرمي في النظام
/// Represents hierarchy type in the system
/// رقم الموديل: 9
/// Model number: 9
/// اسم الجدول: S_HRCHY_TYP
/// Table name: S_HRCHY_TYP
/// </summary>
public class HierarchyType : AuditableEntity, IAggregateRoot
{
    #region Properties

    /// <summary>
    /// رقم نوع التسلسل الهرمي - المفتاح الرئيسي
    /// Hierarchy type number - Primary Key
    /// </summary>
    public int HierarchyTypeNo { get; private set; }

    /// <summary>
    /// الاسم باللغة المحلية
    /// Name in local language
    /// </summary>
    public string LocalName { get; private set; }

    /// <summary>
    /// الاسم باللغة الأجنبية
    /// Name in foreign language
    /// </summary>
    public string ForeignName { get; private set; }

    /// <summary>
    /// الوصف
    /// Description
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// الحد الأقصى للمستويات
    /// Maximum levels
    /// </summary>
    public int MaxLevels { get; private set; }

    /// <summary>
    /// حالة نوع التسلسل الهرمي
    /// Hierarchy type status
    /// </summary>
    public HierarchyTypeStatus Status { get; private set; }

    #endregion

    #region Navigation Properties

    /// <summary>
    /// التسلسلات الهرمية
    /// Hierarchies
    /// </summary>
    public virtual ICollection<Hierarchy> Hierarchies { get; private set; } = new HashSet<Hierarchy>();

    #endregion

    #region Constructors

    private HierarchyType() { } // Required by EF Core

    public HierarchyType(
        int hierarchyTypeNo,
        string localName,
        string foreignName,
        string description = null,
        int maxLevels = 10,
        HierarchyTypeStatus status = HierarchyTypeStatus.Active)
    {
        HierarchyTypeNo = hierarchyTypeNo;
        LocalName = localName;
        ForeignName = foreignName;
        Description = description;
        MaxLevels = maxLevels;
        Status = status;

        AddDomainEvent(new HierarchyTypeCreatedEvent(this));
    }

    #endregion

    #region Methods

    /// <summary>
    /// تحديث معلومات نوع التسلسل الهرمي
    /// Update hierarchy type information
    /// </summary>
    public void UpdateHierarchyTypeInfo(
        string localName,
        string foreignName,
        string description,
        int maxLevels)
    {
        LocalName = localName;
        ForeignName = foreignName;
        Description = description;
        MaxLevels = maxLevels;

        AddDomainEvent(new HierarchyTypeUpdatedEvent(this));
    }

    /// <summary>
    /// تغيير حالة نوع التسلسل الهرمي
    /// Change hierarchy type status
    /// </summary>
    public void ChangeStatus(HierarchyTypeStatus newStatus)
    {
        var oldStatus = Status;
        Status = newStatus;

        AddDomainEvent(new HierarchyTypeStatusChangedEvent(this, oldStatus, newStatus));
    }

    /// <summary>
    /// إضافة تسلسل هرمي
    /// Add hierarchy
    /// </summary>
    public void AddHierarchy(Hierarchy hierarchy)
    {
        Hierarchies.Add(hierarchy);
        AddDomainEvent(new HierarchyAddedToTypeEvent(this, hierarchy));
    }

    /// <summary>
    /// إزالة تسلسل هرمي
    /// Remove hierarchy
    /// </summary>
    public void RemoveHierarchy(Hierarchy hierarchy)
    {
        Hierarchies.Remove(hierarchy);
        AddDomainEvent(new HierarchyRemovedFromTypeEvent(this, hierarchy));
    }

    #endregion
} 