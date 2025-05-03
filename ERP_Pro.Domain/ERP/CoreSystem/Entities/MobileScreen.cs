using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a mobile screen in the ERP system
/// يمثل شاشة الموبايل في نظام تخطيط موارد المؤسسات
/// Table name: S_MOBILE_SCR
/// </summary>
public class MobileScreen : AuditableEntity
{
    private readonly List<MobileScreenName> _screenNames = new();
    private readonly List<MobileScreenPrivilege> _screenPrivileges = new();

    /// <summary>
    /// Gets or sets the system number
    /// رقم النظام
    /// </summary>
    public int SystemNumber { get; private set; }

    /// <summary>
    /// Gets or sets the screen number (Primary Key)
    /// رقم الشاشة (مفتاح رئيسي)
    /// </summary>
    public int ScreenNumber { get; private set; }

    /// <summary>
    /// Gets or sets the parent screen number
    /// رقم الشاشة الأب
    /// </summary>
    public int ParentScreenNumber { get; private set; }

    /// <summary>
    /// Gets or sets whether the screen is inactive
    /// حالة تعطيل الشاشة
    /// </summary>
    public bool IsInactive { get; private set; }

    /// <summary>
    /// Gets or sets the order number
    /// رقم الترتيب
    /// </summary>
    public int OrderNumber { get; private set; }

    /// <summary>
    /// Gets or sets the terminal name for addition
    /// اسم المحطة للإضافة
    /// </summary>
    public string AdditionTerminalName { get; private set; }

    /// <summary>
    /// Gets or sets the terminal name for update
    /// اسم المحطة للتحديث
    /// </summary>
    public string UpdateTerminalName { get; private set; }

    /// <summary>
    /// Gets the screen names
    /// أسماء الشاشة
    /// </summary>
    public IReadOnlyCollection<MobileScreenName> ScreenNames => _screenNames.AsReadOnly();

    /// <summary>
    /// Gets the screen privileges
    /// صلاحيات الشاشة
    /// </summary>
    public IReadOnlyCollection<MobileScreenPrivilege> ScreenPrivileges => _screenPrivileges.AsReadOnly();

    #region Constructors

    private MobileScreen() { }

    public MobileScreen(
        int systemNumber,
        int screenNumber,
        int parentScreenNumber,
        bool isInactive,
        int orderNumber,
        string additionTerminalName,
        string updateTerminalName)
    {
        SystemNumber = systemNumber;
        ScreenNumber = screenNumber;
        ParentScreenNumber = parentScreenNumber;
        IsInactive = isInactive;
        OrderNumber = orderNumber;
        AdditionTerminalName = additionTerminalName;
        UpdateTerminalName = updateTerminalName;

        AddDomainEvent(new MobileScreenCreatedEvent(this));
    }

    #endregion

    #region Methods

    public void UpdateStatus(bool isInactive)
    {
        IsInactive = isInactive;
        AddDomainEvent(new MobileScreenStatusUpdatedEvent(this));
    }

    public void UpdateOrder(int orderNumber)
    {
        OrderNumber = orderNumber;
        AddDomainEvent(new MobileScreenOrderUpdatedEvent(this));
    }

    public void AddScreenName(MobileScreenName screenName)
    {
        _screenNames.Add(screenName);
        AddDomainEvent(new MobileScreenNameAddedEvent(this, screenName));
    }

    public void AddPrivilege(MobileScreenPrivilege privilege)
    {
        _screenPrivileges.Add(privilege);
        AddDomainEvent(new MobileScreenPrivilegeAddedEvent(this, privilege));
    }

    #endregion
} 