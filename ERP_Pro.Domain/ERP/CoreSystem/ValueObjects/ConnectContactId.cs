using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a connect contact
/// يمثل المعرف الفريد لجهة الاتصال
/// </summary>
public class ConnectContactId : ValueObject
{
    /// <summary>
    /// The unique identifier value
    /// قيمة المعرف الفريد
    /// </summary>
    public Guid Value { get; }

    public ConnectContactId(Guid value)
    {
        if (value == Guid.Empty)
            throw new ArgumentException("Contact ID cannot be empty", nameof(value));

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();
} 