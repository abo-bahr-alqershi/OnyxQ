using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a screen CSS privilege entity in the system.
/// يمثل كيان امتيازات CSS للشاشة في النظام
/// </summary>
public sealed class ScreenCssPrivilege : AggregateRoot<ScreenCssPrivilegeId>
{
    /// <summary>
    /// Gets the screen number.
    /// رقم الشاشة
    /// </summary>
    public int ScreenNumber { get; private set; }

    /// <summary>
    /// Gets the customer code.
    /// رمز العميل
    /// </summary>
    public string CustomerCode { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the include flag.
    /// علم التضمين
    /// </summary>
    public bool IncludeFlag { get; private set; }

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
    /// Gets the terminal name where the record was last updated.
    /// اسم الطرفية التي تم تحديث السجل منها
    /// </summary>
    public string UpdatedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Navigation property for the related customer.
    /// خاصية التنقل للعميل المرتبط
    /// </summary>
    public Customer Customer { get; private set; }

    private ScreenCssPrivilege() { }

    private ScreenCssPrivilege(
        ScreenCssPrivilegeId id,
        int screenNumber,
        string customerCode,
        bool includeFlag,
        int addedUserId,
        DateTime addedDate,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        ScreenNumber = screenNumber;
        CustomerCode = customerCode;
        IncludeFlag = includeFlag;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static ScreenCssPrivilege Create(
        int screenNumber,
        string customerCode,
        bool includeFlag,
        int addedUserId,
        string addedTerminalName)
    {
        var screenCssPrivilege = new ScreenCssPrivilege(
            ScreenCssPrivilegeId.CreateUnique(),
            screenNumber,
            customerCode,
            includeFlag,
            addedUserId,
            DateTime.UtcNow,
            addedTerminalName,
            addedTerminalName);

        screenCssPrivilege.RaiseDomainEvent(new ScreenCssPrivilegeCreatedEvent(screenCssPrivilege));

        return screenCssPrivilege;
    }

    public void Update(
        bool includeFlag,
        int updatedUserId,
        string updatedTerminalName)
    {
        IncludeFlag = includeFlag;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new ScreenCssPrivilegeUpdatedEvent(this));
    }
} 