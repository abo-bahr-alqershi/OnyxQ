using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CostMaster Identifier Value Object
/// </summary>
public sealed class CostMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CostMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CostMasterId instance
    /// </summary>
    public CostMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CostMasterId with a new GUID
    /// </summary>
    public static CostMasterId CreateUnique()
    {
        return new CostMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CostMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CostMasterId id) => id.Value;
}
}
