using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// IncomeType Identifier Value Object
/// </summary>
public sealed class IncomeTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the IncomeType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new IncomeTypeId instance
    /// </summary>
    public IncomeTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new IncomeTypeId with a new GUID
    /// </summary>
    public static IncomeTypeId CreateUnique()
    {
        return new IncomeTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(IncomeTypeId id) => id.Value.ToString();
    public static implicit operator Guid(IncomeTypeId id) => id.Value;
}
}
