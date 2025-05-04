using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CostCenterGroup Identifier Value Object
/// </summary>
public sealed class CostCenterGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CostCenterGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CostCenterGroupId instance
    /// </summary>
    public CostCenterGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CostCenterGroupId with a new GUID
    /// </summary>
    public static CostCenterGroupId CreateUnique()
    {
        return new CostCenterGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CostCenterGroupId id) => id.Value.ToString();
    public static implicit operator Guid(CostCenterGroupId id) => id.Value;
}
}
