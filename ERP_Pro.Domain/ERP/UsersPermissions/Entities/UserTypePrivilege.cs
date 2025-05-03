using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.UsersPermissions.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities;

/// <summary>
/// Represents a user type privilege entity in the system.
/// يمثل كيان امتياز نوع المستخدم في النظام
/// </summary>
public sealed class UserTypePrivilege : AggregateRoot<UserTypePrivilegeId>
{
    /// <summary>
    /// Gets the user type ID.
    /// معرف نوع المستخدم
    /// </summary>
    public int UserTypeId { get; private set; }

    /// <summary>
    /// Gets the privilege ID.
    /// معرف الامتياز
    /// </summary>
    public int PrivilegeId { get; private set; }

    /// <summary>
    /// Gets the privilege value.
    /// قيمة الامتياز
    /// </summary>
    public bool PrivilegeValue { get; private set; }

    /// <summary>
    /// Gets the added user ID.
    /// معرف المستخدم الذي أضاف السجل
    /// </summary>
    public int AddedUserId { get; private set; }

    /// <summary>
    /// Gets the addition date.
    /// تاريخ الإضافة
    /// </summary>
    public DateTime AddedDate { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was added.
    /// اسم الطرفية التي تمت إضافة السجل منها
    /// </summary>
    public string AddedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the updated user ID.
    /// معرف المستخدم الذي قام بالتحديث
    /// </summary>
    public int? UpdatedUserId { get; private set; }

    /// <summary>
    /// Gets the update date.
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdatedDate { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was last updated.
    /// اسم الطرفية التي تم تحديث السجل منها
    /// </summary>
    public string UpdatedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Navigation property for the related user type.
    /// خاصية التنقل لنوع المستخدم المرتبط
    /// </summary>
    public SystemType UserType { get; private set; }

    /// <summary>
    /// Navigation property for the related privilege.
    /// خاصية التنقل للامتياز المرتبط
    /// </summary>
    public Permission Privilege { get; private set; }

    private UserTypePrivilege() { }

    private UserTypePrivilege(
        UserTypePrivilegeId id,
        int userTypeId,
        int privilegeId,
        bool privilegeValue,
        int addedUserId,
        DateTime addedDate,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        UserTypeId = userTypeId;
        PrivilegeId = privilegeId;
        PrivilegeValue = privilegeValue;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static UserTypePrivilege Create(
        int userTypeId,
        int privilegeId,
        bool privilegeValue,
        int addedUserId,
        string addedTerminalName)
    {
        var userTypePrivilege = new UserTypePrivilege(
            UserTypePrivilegeId.CreateUnique(),
            userTypeId,
            privilegeId,
            privilegeValue,
            addedUserId,
            DateTime.UtcNow,
            addedTerminalName,
            addedTerminalName);

        userTypePrivilege.RaiseDomainEvent(new UserTypePrivilegeCreatedEvent(userTypePrivilege));

        return userTypePrivilege;
    }

    public void Update(
        bool privilegeValue,
        int updatedUserId,
        string updatedTerminalName)
    {
        PrivilegeValue = privilegeValue;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new UserTypePrivilegeUpdatedEvent(this));
    }
} 