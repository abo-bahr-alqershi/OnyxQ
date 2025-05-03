using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a ReportUserTemplateDetail entity
/// يمثل كيان تفاصيل قالب تقرير المستخدم
/// </summary>
public class ReportUserTemplateDetail : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the ReportUserTemplateDetail
    /// المعرف الفريد لتفاصيل قالب تقرير المستخدم
    /// !# FORM_NO, U_ID, TMPLT_NO, SQ_NO
    /// </summary>
    public ReportUserTemplateDetailId Id { get; private set; }

    /// <summary>
    /// Gets the block name
    /// اسم الكتلة
    /// !# BLK_NM
    /// </summary>
    public string BlockName { get; private set; }

    /// <summary>
    /// Gets the item name
    /// اسم العنصر
    /// !# ITM_NM
    /// </summary>
    public string ItemName { get; private set; }

    /// <summary>
    /// Gets the value
    /// القيمة
    /// !# VAL
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// Gets the sequence number
    /// رقم التسلسل
    /// !# SQ_NO
    /// </summary>
    public int SequenceNumber { get; private set; }

    /// <summary>
    /// Gets the notes
    /// الملاحظات
    /// !# NOTES
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// Gets the user ID who added
    /// معرف المستخدم الذي أضاف
    /// !# AD_U_ID
    /// </summary>
    public int? AddedByUserId { get; private set; }

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
    public int? UpdatedByUserId { get; private set; }

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
    /// Navigation property for the report user template master
    /// خاصية التنقل لرئيسي قالب تقرير المستخدم
    /// @# S_RPRT_USR_TMPLT_MST
    /// </summary>
    public ReportUserTemplateMaster TemplateMaster { get; private set; }

    private ReportUserTemplateDetail() { } // For EF Core

    public ReportUserTemplateDetail(
        int formNumber,
        int userId,
        long templateNumber,
        int sequenceNumber,
        string blockName,
        string itemName,
        string value,
        string notes,
        int? addedByUserId,
        DateTime? addDate,
        string addTerminalName,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName)
    {
        Id = new ReportUserTemplateDetailId(formNumber, userId, templateNumber, sequenceNumber);
        BlockName = blockName;
        ItemName = itemName;
        Value = value;
        SequenceNumber = sequenceNumber;
        Notes = notes;
        AddedByUserId = addedByUserId;
        AddDate = addDate;
        AddTerminalName = addTerminalName;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new ReportUserTemplateDetailCreatedEvent(this));
    }

    public void Update(
        string blockName,
        string itemName,
        string value,
        string notes,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName)
    {
        BlockName = blockName;
        ItemName = itemName;
        Value = value;
        Notes = notes;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new ReportUserTemplateDetailUpdatedEvent(this));
    }

    public void Delete()
    {
        AddDomainEvent(new ReportUserTemplateDetailDeletedEvent(this));
    }
}