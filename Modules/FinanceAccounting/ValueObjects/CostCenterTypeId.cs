using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CostCenterType Identifier Value Object
/// </summary>
public sealed class CostCenterTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CostCenterType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CostCenterTypeId instance
    /// </summary>
    public CostCenterTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CostCenterTypeId with a new GUID
    /// </summary>
    public static CostCenterTypeId CreateUnique()
    {
        return new CostCenterTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CostCenterTypeId id) => id.Value.ToString();
    public static implicit operator Guid(CostCenterTypeId id) => id.Value;
}
}
