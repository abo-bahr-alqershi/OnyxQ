using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a mobile screen privilege in the ERP system
/// يمثل صلاحية شاشة الموبايل في نظام تخطيط موارد المؤسسات
/// Table name: S_MOBILE_SCR_PRV
/// </summary>
public class MobileScreenPrivilege : AuditableEntity
{
    /// <summary>
    /// Gets or sets the screen number (Primary Key)
    /// رقم الشاشة (مفتاح رئيسي)
    /// </summary>
    public int ScreenNumber { get; private set; }

    /// <summary>
    /// Gets or sets the user ID (Primary Key)
    /// معرف المستخدم (مفتاح رئيسي)
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// Gets or sets the privilege flag
    /// علم الصلاحية
    /// </summary>
    public bool PrivilegeFlag { get; private set; }

    /// <summary>
    /// Gets or sets the add flag
    /// علم الإضافة
    /// </summary>
    public bool AddFlag { get; private set; }

    /// <summary>
    /// Gets or sets the user ID for addition
    /// معرف مستخدم الإضافة
    /// </summary>
    public int AdditionUserId { get; private set; }

    /// <summary>
    /// Gets or sets the addition date
    /// تاريخ الإضافة
    /// </summary>
    public DateTime AdditionDate { get; private set; }

    /// <summary>
    /// Gets or sets the user ID for update
    /// معرف مستخدم التحديث
    /// </summary>
    public int UpdateUserId { get; private set; }

    /// <summary>
    /// Gets or sets the update date
    /// تاريخ التحديث
    /// </summary>
    public DateTime UpdateDate { get; private set; }

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

    /// <summary>
    /// Gets or sets the user reference
    /// مرجع المستخدم
    /// </summary>
    public virtual User User { get; private set; }

    #region Constructors

    private MobileScreenPrivilege() { }

    public MobileScreenPrivilege(
        int screenNumber,
        int userId,
        bool privilegeFlag,
        bool addFlag,
        int additionUserId,
        DateTime additionDate,
        int updateUserId,
        DateTime updateDate,
        string additionTerminalName,
        string updateTerminalName)
    {
        ScreenNumber = screenNumber;
        UserId = userId;
        PrivilegeFlag = privilegeFlag;
        AddFlag = addFlag;
        AdditionUserId = additionUserId;
        AdditionDate = additionDate;
        UpdateUserId = updateUserId;
        UpdateDate = updateDate;
        AdditionTerminalName = additionTerminalName;
        UpdateTerminalName = updateTerminalName;

        AddDomainEvent(new MobileScreenPrivilegeCreatedEvent(this));
    }

    #endregion

    #region Methods

    public void UpdatePrivileges(bool privilegeFlag, bool addFlag)
    {
        PrivilegeFlag = privilegeFlag;
        AddFlag = addFlag;
        AddDomainEvent(new MobileScreenPrivilegeUpdatedEvent(this));
    }

    #endregion
} 