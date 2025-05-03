using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a Theme entity
/// يمثل المعرف الفريد لكيان السمة
/// !# THM_NO
/// </summary>
public sealed class ThemeId : ValueObject
{
    /// <summary>
    /// Gets the theme number
    /// رقم السمة
    /// !# THM_NO
    /// </summary>
    public int Value { get; }

    /// <summary>
    /// Initializes a new instance of the ThemeId class
    /// تهيئة نسخة جديدة من صنف معرف السمة
    /// </summary>
    /// <param name="value">The theme number رقم السمة</param>
    public ThemeId(int value)
    {
        if (value <= 0)
            throw new ArgumentException("Theme number must be greater than zero", nameof(value));

        Value = value;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
} 