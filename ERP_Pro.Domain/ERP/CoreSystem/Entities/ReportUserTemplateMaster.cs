using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a ReportUserTemplateMaster entity
/// يمثل كيان رئيسي قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateMaster : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the ReportUserTemplateMaster
    /// المعرف الفريد لرئيسي قالب تقرير المستخدم
    /// !# FORM_NO, U_ID, TMPLT_NO
    /// </summary>
    public ReportUserTemplateMasterId Id { get; private set; }

    /// <summary>
    /// Gets the order number
    /// رقم الترتيب
    /// !# ORDR_NO
    /// </summary>
    public long OrderNumber { get; private set; }

    /// <summary>
    /// Gets the notes
    /// الملاحظات
    /// !# NOTES
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// Gets the inactive flag
    /// حالة التعطيل
    /// !# INACTIVE
    /// </summary>
    public bool Inactive { get; private set; }

    /// <summary>
    /// Gets the inactive reason
    /// سبب التعطيل
    /// !# INACTIVE_RES
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// Gets the user ID who inactivated
    /// معرف المستخدم الذي قام بالتعطيل
    /// !# INACTIVE_U_ID
    /// </summary>
    public long? InactiveUserId { get; private set; }

    /// <summary>
    /// Gets the inactive date
    /// تاريخ التعطيل
    /// !# INACTIVE_DATE
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// Gets the user ID who added
    /// معرف المستخدم الذي أضاف
    /// !# AD_U_ID
    /// </summary>
    public long? AddedByUserId { get; private set; }

    /// <summary>
    /// Gets the add date
    /// تاريخ الإضافة
    /// !# AD_DATE
    /// </summary>
    public DateTime? AddDate { get; private set; }

    /// <summary>
    /// Gets the terminal name for add
    /// اسم الجهاز عند الإضافة
    /// !# AD_TRMNL_NM
    /// </summary>
    public string AddTerminalName { get; private set; }

    /// <summary>
    /// Gets the user ID who last updated
    /// معرف المستخدم الذي قام بآخر تحديث
    /// !# UP_U_ID
    /// </summary>
    public long? UpdatedByUserId { get; private set; }

    /// <summary>
    /// Gets the last update date
    /// تاريخ آخر تحديث
    /// !# UP_DATE
    /// </summary>
    public DateTime? UpdatedDate { get; private set; }

    /// <summary>
    /// Gets the update count
    /// عدد مرات التحديث
    /// !# UP_CNT
    /// </summary>
    public long? UpdateCount { get; private set; }

    /// <summary>
    /// Gets the terminal name for last update
    /// اسم الجهاز لآخر تحديث
    /// !# UP_TRMNL_NM
    /// </summary>
    public string UpdatedTerminalName { get; private set; }

    /// <summary>
    /// Gets the template name
    /// اسم القالب
    /// !# TMPLT_NM
    /// </summary>
    public string TemplateName { get; private set; }

    /// <summary>
    /// Gets the default flag
    /// هل هو افتراضي
    /// !# DFLT_FLG
    /// </summary>
    public bool DefaultFlag { get; private set; }

    /// <summary>
    /// Gets the generate for all users flag
    /// هل ينشأ لجميع المستخدمين
    /// !# GNR_FOR_ALL_USR_FLG
    /// </summary>
    public bool GenerateForAllUsersFlag { get; private set; }

    /// <summary>
    /// Navigation property for the details
    /// خاصية التنقل للتفاصيل
    /// @# S_RPRT_USR_TMPLT_DTL
    /// </summary>
    public ICollection<ReportUserTemplateDetail> Details { get; private set; }

    private ReportUserTemplateMaster() { }

    public ReportUserTemplateMaster(
        int formNumber,
        int userId,
        long templateNumber,
        long orderNumber,
        string notes,
        bool inactive,
        string inactiveReason,
        long? inactiveUserId,
        DateTime? inactiveDate,
        long? addedByUserId,
        DateTime? addDate,
        string addTerminalName,
        long? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName,
        string templateName,
        bool defaultFlag,
        bool generateForAllUsersFlag)
    {
        Id = new ReportUserTemplateMasterId(formNumber, userId, templateNumber);
        OrderNumber = orderNumber;
        Notes = notes;
        Inactive = inactive;
        InactiveReason = inactiveReason;
        InactiveUserId = inactiveUserId;
        InactiveDate = inactiveDate;
        AddedByUserId = addedByUserId;
        AddDate = addDate;
        AddTerminalName = addTerminalName;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        TemplateName = templateName;
        DefaultFlag = defaultFlag;
        GenerateForAllUsersFlag = generateForAllUsersFlag;
        Details = new List<ReportUserTemplateDetail>();
        AddDomainEvent(new ReportUserTemplateMasterCreatedEvent(this));
    }

    public void Update(
        long orderNumber,
        string notes,
        bool inactive,
        string inactiveReason,
        long? inactiveUserId,
        DateTime? inactiveDate,
        long? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName,
        string templateName,
        bool defaultFlag,
        bool generateForAllUsersFlag)
    {
        OrderNumber = orderNumber;
        Notes = notes;
        Inactive = inactive;
        InactiveReason = inactiveReason;
        InactiveUserId = inactiveUserId;
        InactiveDate = inactiveDate;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        TemplateName = templateName;
        DefaultFlag = defaultFlag;
        GenerateForAllUsersFlag = generateForAllUsersFlag;
        AddDomainEvent(new ReportUserTemplateMasterUpdatedEvent(this));
    }

    public void Activate()
    {
        Inactive = false;
        AddDomainEvent(new ReportUserTemplateMasterActivatedEvent(this));
    }

    public void Deactivate(string reason, DateTime deactivationDate)
    {
        Inactive = true;
        InactiveReason = reason;
        InactiveDate = deactivationDate;
        AddDomainEvent(new ReportUserTemplateMasterDeactivatedEvent(this, reason, deactivationDate));
    }

    public void Delete()
    {
        AddDomainEvent(new ReportUserTemplateMasterDeletedEvent(this));
    }
} 