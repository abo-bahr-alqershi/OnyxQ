using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// يمثل هذا النموذج صلاحيات مستخدم الفرع في النظام
/// Represents branch user privileges in the system
/// رقم الموديل: 5
/// Model number: 5
/// اسم الجدول: S_BRN_USR_PRIV
/// Table name: S_BRN_USR_PRIV
/// </summary>
public class BranchUserPrivilege : AuditableEntity
{
    #region Properties

    /// <summary>
    /// رقم المستخدم
    /// User number
    /// </summary>
    public int UserNo { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// Branch number
    /// </summary>
    public int BranchNo { get; private set; }

    /// <summary>
    /// نوع الصلاحية
    /// Privilege type
    /// </summary>
    public PrivilegeType PrivilegeType { get; private set; }

    /// <summary>
    /// مستوى الصلاحية
    /// Privilege level
    /// </summary>
    public PrivilegeLevel PrivilegeLevel { get; private set; }

    /// <summary>
    /// تاريخ بداية الصلاحية
    /// Privilege start date
    /// </summary>
    public DateTime StartDate { get; private set; }

    /// <summary>
    /// تاريخ نهاية الصلاحية
    /// Privilege end date
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// حالة الصلاحية
    /// Privilege status
    /// </summary>
    public PrivilegeStatus Status { get; private set; }

    /// <summary>
    /// ملاحظات
    /// Notes
    /// </summary>
    public string Notes { get; private set; }

    #endregion

    #region Navigation Properties

    /// <summary>
    /// المستخدم
    /// User
    /// </summary>
    public virtual User User { get; private set; }

    /// <summary>
    /// الفرع
    /// Branch
    /// </summary>
    public virtual Branch Branch { get; private set; }

    #endregion

    #region Constructors

    private BranchUserPrivilege() { } // Required by EF Core

    public BranchUserPrivilege(
        int userNo,
        int branchNo,
        PrivilegeType privilegeType,
        PrivilegeLevel privilegeLevel,
        DateTime startDate,
        DateTime? endDate = null,
        string notes = null,
        PrivilegeStatus status = PrivilegeStatus.Active)
    {
        UserNo = userNo;
        BranchNo = branchNo;
        PrivilegeType = privilegeType;
        PrivilegeLevel = privilegeLevel;
        StartDate = startDate;
        EndDate = endDate;
        Notes = notes;
        Status = status;

        AddDomainEvent(new BranchUserPrivilegeCreatedEvent(this));
    }

    #endregion

    #region Methods

    /// <summary>
    /// تحديث معلومات الصلاحية
    /// Update privilege information
    /// </summary>
    public void UpdatePrivilegeInfo(
        PrivilegeType privilegeType,
        PrivilegeLevel privilegeLevel,
        DateTime startDate,
        DateTime? endDate,
        string notes)
    {
        PrivilegeType = privilegeType;
        PrivilegeLevel = privilegeLevel;
        StartDate = startDate;
        EndDate = endDate;
        Notes = notes;

        AddDomainEvent(new BranchUserPrivilegeUpdatedEvent(this));
    }

    /// <summary>
    /// تغيير حالة الصلاحية
    /// Change privilege status
    /// </summary>
    public void ChangeStatus(PrivilegeStatus newStatus)
    {
        var oldStatus = Status;
        Status = newStatus;

        AddDomainEvent(new BranchUserPrivilegeStatusChangedEvent(this, oldStatus, newStatus));
    }

    /// <summary>
    /// تمديد فترة الصلاحية
    /// Extend privilege period
    /// </summary>
    public void ExtendPrivilegePeriod(DateTime newEndDate)
    {
        var oldEndDate = EndDate;
        EndDate = newEndDate;

        AddDomainEvent(new BranchUserPrivilegePeriodExtendedEvent(this, oldEndDate, newEndDate));
    }

    #endregion
} 