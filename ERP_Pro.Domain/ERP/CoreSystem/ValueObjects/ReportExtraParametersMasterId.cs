using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a ReportExtraParametersMaster entity
/// يمثل المعرف الفريد لكيان رئيسي معلمات التقرير الإضافية
/// !# DOC_SRL
/// </summary>
public sealed class ReportExtraParametersMasterId : ValueObject
{
    /// <summary>
    /// Gets the document serial
    /// الرقم التسلسلي للمستند
    /// !# DOC_SRL
    /// </summary>
    public long Value { get; }

    /// <summary>
    /// Initializes a new instance of the ReportExtraParametersMasterId class
    /// تهيئة نسخة جديدة من صنف معرف رئيسي معلمات التقرير الإضافية
    /// </summary>
    /// <param name="value">The document serial value القيمة التسلسلية للمستند</param>
    public ReportExtraParametersMasterId(long value)
    {
        Value = value;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
} 