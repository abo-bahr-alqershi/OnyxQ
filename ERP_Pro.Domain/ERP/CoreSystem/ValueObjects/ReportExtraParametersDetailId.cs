using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a ReportExtraParametersDetail entity
/// يمثل المعرف الفريد لكيان تفاصيل معلمات التقرير الإضافية
/// !# DOC_SRL, LN_NO
/// </summary>
public sealed class ReportExtraParametersDetailId : ValueObject
{
    /// <summary>
    /// Gets the document serial
    /// الرقم التسلسلي للمستند
    /// !# DOC_SRL
    /// </summary>
    public long DocumentSerial { get; }

    /// <summary>
    /// Gets the line number
    /// رقم السطر
    /// !# LN_NO
    /// </summary>
    public int LineNumber { get; }

    /// <summary>
    /// Initializes a new instance of the ReportExtraParametersDetailId class
    /// تهيئة نسخة جديدة من صنف معرف تفاصيل معلمات التقرير الإضافية
    /// </summary>
    /// <param name="documentSerial">The document serial الرقم التسلسلي للمستند</param>
    /// <param name="lineNumber">The line number رقم السطر</param>
    public ReportExtraParametersDetailId(long documentSerial, int lineNumber)
    {
        if (documentSerial <= 0)
            throw new ArgumentException("Document serial must be greater than zero", nameof(documentSerial));
        if (lineNumber <= 0)
            throw new ArgumentException("Line number must be greater than zero", nameof(lineNumber));

        DocumentSerial = documentSerial;
        LineNumber = lineNumber;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return DocumentSerial;
        yield return LineNumber;
    }
} 