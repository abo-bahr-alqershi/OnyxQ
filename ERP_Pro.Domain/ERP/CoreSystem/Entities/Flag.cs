using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// يمثل هذا النموذج العلامات في النظام
/// Represents flags in the system
/// رقم الموديل: 6
/// Model number: 6
/// اسم الجدول: S_FLAGS
/// Table name: S_FLAGS
/// </summary>
public class Flag : AuditableEntity, IAggregateRoot
{
    #region Properties

    /// <summary>
    /// رقم العلامة - المفتاح الرئيسي
    /// Flag number - Primary Key
    /// </summary>
    public int FlagNo { get; private set; }

    /// <summary>
    /// نوع العلامة
    /// Flag type
    /// </summary>
    public FlagType Type { get; private set; }

    /// <summary>
    /// اسم العلامة باللغة المحلية
    /// Flag name in local language
    /// </summary>
    public string LocalName { get; private set; }

    /// <summary>
    /// اسم العلامة باللغة الأجنبية
    /// Flag name in foreign language
    /// </summary>
    public string ForeignName { get; private set; }

    /// <summary>
    /// وصف العلامة
    /// Flag description
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// لون العلامة
    /// Flag color
    /// </summary>
    public string Color { get; private set; }

    /// <summary>
    /// أيقونة العلامة
    /// Flag icon
    /// </summary>
    public string Icon { get; private set; }

    /// <summary>
    /// ترتيب العلامة
    /// Flag order
    /// </summary>
    public int Order { get; private set; }

    /// <summary>
    /// حالة العلامة
    /// Flag status
    /// </summary>
    public FlagStatus Status { get; private set; }

    #endregion

    #region Navigation Properties

    /// <summary>
    /// صلاحيات العلامة
    /// Flag privileges
    /// </summary>
    public virtual ICollection<FlagPrivilege> Privileges { get; private set; } = new HashSet<FlagPrivilege>();

    #endregion

    #region Constructors

    private Flag() { } // Required by EF Core

    public Flag(
        int flagNo,
        FlagType type,
        string localName,
        string foreignName,
        string description = null,
        string color = null,
        string icon = null,
        int order = 0,
        FlagStatus status = FlagStatus.Active)
    {
        FlagNo = flagNo;
        Type = type;
        LocalName = localName;
        ForeignName = foreignName;
        Description = description;
        Color = color;
        Icon = icon;
        Order = order;
        Status = status;

        AddDomainEvent(new FlagCreatedEvent(this));
    }

    #endregion

    #region Methods

    /// <summary>
    /// تحديث معلومات العلامة
    /// Update flag information
    /// </summary>
    public void UpdateFlagInfo(
        string localName,
        string foreignName,
        string description,
        string color,
        string icon,
        int order)
    {
        LocalName = localName;
        ForeignName = foreignName;
        Description = description;
        Color = color;
        Icon = icon;
        Order = order;

        AddDomainEvent(new FlagUpdatedEvent(this));
    }

    /// <summary>
    /// تغيير حالة العلامة
    /// Change flag status
    /// </summary>
    public void ChangeStatus(FlagStatus newStatus)
    {
        var oldStatus = Status;
        Status = newStatus;

        AddDomainEvent(new FlagStatusChangedEvent(this, oldStatus, newStatus));
    }

    /// <summary>
    /// إضافة صلاحية للعلامة
    /// Add privilege to flag
    /// </summary>
    public void AddPrivilege(FlagPrivilege privilege)
    {
        Privileges.Add(privilege);
        AddDomainEvent(new FlagPrivilegeAddedEvent(this, privilege));
    }

    /// <summary>
    /// إزالة صلاحية من العلامة
    /// Remove privilege from flag
    /// </summary>
    public void RemovePrivilege(FlagPrivilege privilege)
    {
        Privileges.Remove(privilege);
        AddDomainEvent(new FlagPrivilegeRemovedEvent(this, privilege));
    }

    #endregion
} 