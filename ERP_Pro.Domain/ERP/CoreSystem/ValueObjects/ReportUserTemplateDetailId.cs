using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a ReportUserTemplateDetail
/// يمثل المعرف الفريد لتفاصيل قالب تقرير المستخدم
/// !# FORM_NO, U_ID, TMPLT_NO, SQ_NO
/// </summary>
public class ReportUserTemplateDetailId : ValueObject
{
    /// <summary>
    /// Gets the form number
    /// رقم النموذج
    /// !# FORM_NO
    /// </summary>
    public int FormNumber { get; }

    /// <summary>
    /// Gets the user ID
    /// معرف المستخدم
    /// !# U_ID
    /// </summary>
    public int UserId { get; }

    /// <summary>
    /// Gets the template number
    /// رقم القالب
    /// !# TMPLT_NO
    /// </summary>
    public long TemplateNumber { get; }

    /// <summary>
    /// Gets the sequence number
    /// رقم التسلسل
    /// !# SQ_NO
    /// </summary>
    public int SequenceNumber { get; }

    public ReportUserTemplateDetailId(int formNumber, int userId, long templateNumber, int sequenceNumber)
    {
        if (formNumber <= 0)
            throw new ArgumentException("Form number must be greater than zero", nameof(formNumber));
        if (userId <= 0)
            throw new ArgumentException("User ID must be greater than zero", nameof(userId));
        if (templateNumber <= 0)
            throw new ArgumentException("Template number must be greater than zero", nameof(templateNumber));
        if (sequenceNumber <= 0)
            throw new ArgumentException("Sequence number must be greater than zero", nameof(sequenceNumber));
        FormNumber = formNumber;
        UserId = userId;
        TemplateNumber = templateNumber;
        SequenceNumber = sequenceNumber;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FormNumber;
        yield return UserId;
        yield return TemplateNumber;
        yield return SequenceNumber;
    }
} 