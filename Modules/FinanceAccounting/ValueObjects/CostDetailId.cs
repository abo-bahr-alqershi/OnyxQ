using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CostDetail Identifier Value Object
/// </summary>
public sealed class CostDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CostDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CostDetailId instance
    /// </summary>
    public CostDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CostDetailId with a new GUID
    /// </summary>
    public static CostDetailId CreateUnique()
    {
        return new CostDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CostDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CostDetailId id) => id.Value;
}
}
