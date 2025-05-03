using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a mobile screen name in the ERP system
/// يمثل اسم شاشة الموبايل في نظام تخطيط موارد المؤسسات
/// Table name: S_MOBILE_SCR_NM
/// </summary>
public class MobileScreenName : AuditableEntity
{
    /// <summary>
    /// Gets or sets the screen number (Primary Key)
    /// رقم الشاشة (مفتاح رئيسي)
    /// </summary>
    public int ScreenNumber { get; private set; }

    /// <summary>
    /// Gets or sets the language number (Primary Key)
    /// رقم اللغة (مفتاح رئيسي)
    /// </summary>
    public int LanguageNumber { get; private set; }

    /// <summary>
    /// Gets or sets the screen name
    /// اسم الشاشة
    /// </summary>
    public string ScreenName { get; private set; }

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
    /// Gets or sets the mobile screen reference
    /// مرجع شاشة الموبايل
    /// </summary>
    public virtual MobileScreen MobileScreen { get; private set; }

    #region Constructors

    private MobileScreenName() { }

    public MobileScreenName(
        int screenNumber,
        int languageNumber,
        string screenName,
        string additionTerminalName,
        string updateTerminalName)
    {
        ScreenNumber = screenNumber;
        LanguageNumber = languageNumber;
        ScreenName = screenName;
        AdditionTerminalName = additionTerminalName;
        UpdateTerminalName = updateTerminalName;

        AddDomainEvent(new MobileScreenNameCreatedEvent(this));
    }

    #endregion

    #region Methods

    public void UpdateScreenName(string screenName)
    {
        if (string.IsNullOrWhiteSpace(screenName))
            throw new ArgumentException("Screen name cannot be empty", nameof(screenName));

        ScreenName = screenName;
        AddDomainEvent(new MobileScreenNameUpdatedEvent(this));
    }

    #endregion
} 