using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CheckIncomeMaster Identifier Value Object
/// </summary>
public sealed class CheckIncomeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CheckIncomeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CheckIncomeMasterId instance
    /// </summary>
    public CheckIncomeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CheckIncomeMasterId with a new GUID
    /// </summary>
    public static CheckIncomeMasterId CreateUnique()
    {
        return new CheckIncomeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CheckIncomeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CheckIncomeMasterId id) => id.Value;
}
}
