using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a ListSelect
/// يمثل المعرف الفريد لاختيار القائمة
/// !# LST_NM
/// </summary>
public class ListSelectId : ValueObject
{
    /// <summary>
    /// The unique identifier value
    /// قيمة المعرف الفريد
    /// !# LST_NM
    /// </summary>
    public string Value { get; }

    public ListSelectId(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("List select ID cannot be empty", nameof(value));

        if (value.Length > 30)
            throw new ArgumentException("List select ID cannot be longer than 30 characters", nameof(value));

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
} 