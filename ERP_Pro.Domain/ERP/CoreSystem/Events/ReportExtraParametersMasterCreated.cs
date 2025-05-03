using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event when a ReportExtraParametersMaster is created
/// يمثل الحدث عند إنشاء رئيسي معلمات التقرير الإضافية
/// </summary>
public sealed class ReportExtraParametersMasterCreated : DomainEvent
{
    /// <summary>
    /// Gets the ReportExtraParametersMaster ID
    /// معرف رئيسي معلمات التقرير الإضافية
    /// </summary>
    public ReportExtraParametersMasterId Id { get; }

    /// <summary>
    /// Gets the document number
    /// رقم المستند
    /// </summary>
    public long DocumentNumber { get; }

    /// <summary>
    /// Gets the form number
    /// رقم النموذج
    /// </summary>
    public int FormNumber { get; }

    /// <summary>
    /// Gets the user ID
    /// معرف المستخدم
    /// </summary>
    public int UserId { get; }

    /// <summary>
    /// Initializes a new instance of the ReportExtraParametersMasterCreated class
    /// تهيئة نسخة جديدة من صنف حدث إنشاء رئيسي معلمات التقرير الإضافية
    /// </summary>
    public ReportExtraParametersMasterCreated(
        ReportExtraParametersMasterId id,
        long documentNumber,
        int formNumber,
        int userId)
    {
        Id = id;
        DocumentNumber = documentNumber;
        FormNumber = formNumber;
        UserId = userId;
    }
} 