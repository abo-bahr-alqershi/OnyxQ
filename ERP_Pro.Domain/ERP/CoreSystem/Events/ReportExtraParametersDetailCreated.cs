using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event when a ReportExtraParametersDetail is created
/// يمثل الحدث عند إنشاء تفاصيل معلمات التقرير الإضافية
/// </summary>
public sealed class ReportExtraParametersDetailCreated : DomainEvent
{
    /// <summary>
    /// Gets the ReportExtraParametersDetail ID
    /// معرف تفاصيل معلمات التقرير الإضافية
    /// </summary>
    public ReportExtraParametersDetailId Id { get; }

    /// <summary>
    /// Gets the master document serial
    /// الرقم التسلسلي للمستند الرئيسي
    /// </summary>
    public ReportExtraParametersMasterId MasterDocumentSerial { get; }

    /// <summary>
    /// Gets the line number
    /// رقم السطر
    /// </summary>
    public int LineNumber { get; }

    /// <summary>
    /// Gets the parameter name
    /// اسم المعلمة
    /// </summary>
    public string ParameterName { get; }

    /// <summary>
    /// Initializes a new instance of the ReportExtraParametersDetailCreated class
    /// تهيئة نسخة جديدة من صنف حدث إنشاء تفاصيل معلمات التقرير الإضافية
    /// </summary>
    public ReportExtraParametersDetailCreated(
        ReportExtraParametersDetailId id,
        ReportExtraParametersMasterId masterDocumentSerial,
        int lineNumber,
        string parameterName)
    {
        Id = id;
        MasterDocumentSerial = masterDocumentSerial;
        LineNumber = lineNumber;
        ParameterName = parameterName;
    }
} 