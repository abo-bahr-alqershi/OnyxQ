using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a ReportUserTemplateMaster
/// يمثل المعرف الفريد لرئيسي قالب تقرير المستخدم
/// !# FORM_NO, U_ID, TMPLT_NO
/// </summary>
public class ReportUserTemplateMasterId : ValueObject
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

    public ReportUserTemplateMasterId(int formNumber, int userId, long templateNumber)
    {
        if (formNumber <= 0)
            throw new ArgumentException("Form number must be greater than zero", nameof(formNumber));

        if (userId <= 0)
            throw new ArgumentException("User ID must be greater than zero", nameof(userId));

        if (templateNumber <= 0)
            throw new ArgumentException("Template number must be greater than zero", nameof(templateNumber));

        FormNumber = formNumber;
        UserId = userId;
        TemplateNumber = templateNumber;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FormNumber;
        yield return UserId;
        yield return TemplateNumber;
    }
} 