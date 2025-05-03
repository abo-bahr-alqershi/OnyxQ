using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a ReportExtraParametersMaster entity
/// يمثل كيان رئيسي معلمات التقرير الإضافية
/// </summary>
public class ReportExtraParametersMaster : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the ReportExtraParametersMaster
    /// المعرف الفريد لرئيسي معلمات التقرير الإضافية
    /// !# DOC_SRL
    /// </summary>
    public ReportExtraParametersMasterId Id { get; private set; }

    /// <summary>
    /// Gets the document number
    /// رقم المستند
    /// !# DOC_NO
    /// </summary>
    public long DocumentNumber { get; private set; }

    /// <summary>
    /// Gets the document date
    /// تاريخ المستند
    /// !# DOC_DATE
    /// </summary>
    public DateTime? DocumentDate { get; private set; }

    /// <summary>
    /// Gets the form number
    /// رقم النموذج
    /// !# FORM_NO
    /// </summary>
    public int FormNumber { get; private set; }

    /// <summary>
    /// Gets the user ID
    /// معرف المستخدم
    /// !# U_ID
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// Gets the document use flag
    /// علم استخدام المستند
    /// !# DOC_USE
    /// </summary>
    public bool DocumentUse { get; private set; }

    /// <summary>
    /// Gets the document description
    /// وصف المستند
    /// !# DOC_DSC
    /// </summary>
    public string DocumentDescription { get; private set; }

    /// <summary>
    /// Gets the where SQL
    /// شرط WHERE SQL
    /// !# WHR_SQL
    /// </summary>
    public string WhereSql { get; private set; }

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
    /// Navigation property for the details
    /// خاصية التنقل للتفاصيل
    /// @# S_RP_EXTRA_PRMTRS_DTL
    /// </summary>
    public ICollection<ReportExtraParametersDetail> Details { get; private set; }

    private ReportExtraParametersMaster() { }

    public ReportExtraParametersMaster(
        long documentSerial,
        long documentNumber,
        DateTime? documentDate,
        int formNumber,
        int userId,
        bool documentUse,
        string documentDescription,
        string whereSql,
        int? addedByUserId,
        DateTime? addDate,
        string addTerminalName,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName)
    {
        Id = new ReportExtraParametersMasterId(documentSerial);
        DocumentNumber = documentNumber;
        DocumentDate = documentDate;
        FormNumber = formNumber;
        UserId = userId;
        DocumentUse = documentUse;
        DocumentDescription = documentDescription;
        WhereSql = whereSql;
        AddedByUserId = addedByUserId;
        AddDate = addDate;
        AddTerminalName = addTerminalName;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        Details = new List<ReportExtraParametersDetail>();
        AddDomainEvent(new ReportExtraParametersMasterCreated(this));
    }

    public void Update(
        DateTime? documentDate,
        bool documentUse,
        string documentDescription,
        string whereSql,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName)
    {
        DocumentDate = documentDate;
        DocumentUse = documentUse;
        DocumentDescription = documentDescription;
        WhereSql = whereSql;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new ReportExtraParametersMasterUpdated(this));
    }

    public void Delete()
    {
        AddDomainEvent(new ReportExtraParametersMasterDeleted(this));
    }
} 