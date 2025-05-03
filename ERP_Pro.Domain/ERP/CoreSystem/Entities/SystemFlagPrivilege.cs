using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// يمثل هذا الكيان صلاحيات العلامات في النظام
/// This entity represents system flag privileges
/// اسم الجدول: S_FLAGS_PRIV
/// Table name: S_FLAGS_PRIV
/// </summary>
public class SystemFlagPrivilege : BaseAuditableEntity
{
    /// <summary>
    /// رقم المستخدم
    /// User ID
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// رمز العلامة
    /// Flag Code
    /// </summary>
    public string FlagCode { get; private set; }

    /// <summary>
    /// قيمة العلامة
    /// Flag Value
    /// </summary>
    public int FlagValue { get; private set; }

    /// <summary>
    /// علامة الصلاحية
    /// Privilege Flag
    /// </summary>
    public int PrivilegeFlag { get; private set; }

    /// <summary>
    /// نوع الصلاحية
    /// Privilege Type
    /// </summary>
    public FlagPrivilegeType PrivilegeType { get; private set; }

    /// <summary>
    /// مستوى الصلاحية
    /// Privilege Level
    /// </summary>
    public FlagPrivilegeLevel PrivilegeLevel { get; private set; }

    /// <summary>
    /// حالة الصلاحية
    /// Privilege Status
    /// </summary>
    public FlagPrivilegeStatus Status { get; private set; }

    /// <summary>
    /// العلاقة مع المستخدم
    /// User Navigation Property
    /// </summary>
    public User User { get; private set; }

    /// <summary>
    /// العلاقة مع العلامة
    /// Flag Navigation Property
    /// </summary>
    public SystemFlag Flag { get; private set; }

    private SystemFlagPrivilege() { }

    public static SystemFlagPrivilege Create(
        int userId,
        string flagCode,
        int flagValue,
        FlagPrivilegeType privilegeType,
        FlagPrivilegeLevel privilegeLevel)
    {
        var privilege = new SystemFlagPrivilege
        {
            UserId = userId,
            FlagCode = flagCode,
            FlagValue = flagValue,
            PrivilegeType = privilegeType,
            PrivilegeLevel = privilegeLevel,
            Status = FlagPrivilegeStatus.Active,
            PrivilegeFlag = 0
        };

        privilege.AddDomainEvent(new SystemFlagPrivilegeCreatedEvent(privilege));
        return privilege;
    }

    public void UpdatePrivilege(
        FlagPrivilegeType privilegeType,
        FlagPrivilegeLevel privilegeLevel)
    {
        PrivilegeType = privilegeType;
        PrivilegeLevel = privilegeLevel;
        AddDomainEvent(new SystemFlagPrivilegeUpdatedEvent(this));
    }

    public void SetStatus(FlagPrivilegeStatus status)
    {
        Status = status;
        AddDomainEvent(new SystemFlagPrivilegeStatusChangedEvent(this));
    }
} 