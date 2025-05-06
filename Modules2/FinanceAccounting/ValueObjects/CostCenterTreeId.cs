using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CostCenterTree Identifier Value Object
/// </summary>
public sealed class CostCenterTreeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CostCenterTree
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CostCenterTreeId instance
    /// </summary>
    public CostCenterTreeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CostCenterTreeId with a new GUID
    /// </summary>
    public static CostCenterTreeId CreateUnique()
    {
        return new CostCenterTreeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CostCenterTreeId id) => id.Value.ToString();
    public static implicit operator Guid(CostCenterTreeId id) => id.Value;
}
}
