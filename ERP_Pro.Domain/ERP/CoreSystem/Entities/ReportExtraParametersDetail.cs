using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a ReportExtraParametersDetail entity
/// يمثل كيان تفاصيل معلمات التقرير الإضافية
/// </summary>
public class ReportExtraParametersDetail : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the ReportExtraParametersDetail
    /// المعرف الفريد لتفاصيل معلمات التقرير الإضافية
    /// !# DOC_SRL, LN_NO
    /// </summary>
    public ReportExtraParametersDetailId Id { get; private set; }

    /// <summary>
    /// Gets the master document serial
    /// الرقم التسلسلي للمستند الرئيسي
    /// !# MST_DOC_SRL
    /// @# S_RP_EXTRA_PRMTRS_MST
    /// </summary>
    public ReportExtraParametersMasterId MasterDocumentSerial { get; private set; }

    /// <summary>
    /// Gets the line number
    /// رقم السطر
    /// !# LN_NO
    /// </summary>
    public int LineNumber { get; private set; }

    /// <summary>
    /// Gets the parameter name
    /// اسم المعلمة
    /// !# PRMTR_NM
    /// </summary>
    public string ParameterName { get; private set; }

    /// <summary>
    /// Gets the parameter value
    /// قيمة المعلمة
    /// !# PRMTR_VAL
    /// </summary>
    public string ParameterValue { get; private set; }

    /// <summary>
    /// Gets the parameter type
    /// نوع المعلمة
    /// !# PRMTR_TYP
    /// </summary>
    public string ParameterType { get; private set; }

    /// <summary>
    /// Gets the parameter description
    /// وصف المعلمة
    /// !# PRMTR_DSC
    /// </summary>
    public string ParameterDescription { get; private set; }

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
    /// Navigation property for the master
    /// خاصية التنقل للرئيسي
    /// @# S_RP_EXTRA_PRMTRS_MST
    /// </summary>
    public ReportExtraParametersMaster Master { get; private set; }

    private ReportExtraParametersDetail() { }

    public ReportExtraParametersDetail(
        long documentSerial,
        int lineNumber,
        ReportExtraParametersMasterId masterDocumentSerial,
        string parameterName,
        string parameterValue,
        string parameterType,
        string parameterDescription,
        int? addedByUserId,
        DateTime? addDate,
        string addTerminalName,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName)
    {
        Id = new ReportExtraParametersDetailId(documentSerial, lineNumber);
        MasterDocumentSerial = masterDocumentSerial;
        LineNumber = lineNumber;
        ParameterName = parameterName;
        ParameterValue = parameterValue;
        ParameterType = parameterType;
        ParameterDescription = parameterDescription;
        AddedByUserId = addedByUserId;
        AddDate = addDate;
        AddTerminalName = addTerminalName;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new ReportExtraParametersDetailCreated(this));
    }

    public void Update(
        string parameterName,
        string parameterValue,
        string parameterType,
        string parameterDescription,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName)
    {
        ParameterName = parameterName;
        ParameterValue = parameterValue;
        ParameterType = parameterType;
        ParameterDescription = parameterDescription;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new ReportExtraParametersDetailUpdated(this));
    }

    public void Delete()
    {
        AddDomainEvent(new ReportExtraParametersDetailDeleted(this));
    }
} 