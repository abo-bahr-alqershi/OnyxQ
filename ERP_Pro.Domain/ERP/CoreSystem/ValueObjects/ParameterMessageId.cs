using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a ParameterMessage
/// يمثل المعرف الفريد لرسالة المعلمات
/// !# PARA_NO
/// </summary>
public class ParameterMessageId : ValueObject
{
    /// <summary>
    /// The unique identifier value
    /// قيمة المعرف الفريد
    /// !# PARA_NO
    /// </summary>
    public byte Value { get; }

    public ParameterMessageId(byte value)
    {
        if (value == 0)
            throw new ArgumentException("Parameter message ID cannot be zero", nameof(value));

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
} 