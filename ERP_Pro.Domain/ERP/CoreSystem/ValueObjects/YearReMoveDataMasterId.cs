using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a YearReMoveDataMaster entity
/// يمثل المعرف الفريد لكيان رئيسي نقل بيانات السنة
/// !# TABLE_NM
/// </summary>
public sealed class YearReMoveDataMasterId : ValueObject
{
    /// <summary>
    /// Gets the table name
    /// اسم الجدول
    /// !# TABLE_NM
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Initializes a new instance of the YearReMoveDataMasterId class
    /// تهيئة نسخة جديدة من صنف معرف رئيسي نقل بيانات السنة
    /// </summary>
    /// <param name="value">The table name اسم الجدول</param>
    public YearReMoveDataMasterId(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Table name cannot be empty", nameof(value));

        Value = value;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
} 