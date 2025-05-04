using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// CostingType Identifier Value Object
/// </summary>
public sealed class CostingTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CostingType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CostingTypeId instance
    /// </summary>
    public CostingTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CostingTypeId with a new GUID
    /// </summary>
    public static CostingTypeId CreateUnique()
    {
        return new CostingTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CostingTypeId id) => id.Value.ToString();
    public static implicit operator Guid(CostingTypeId id) => id.Value;
}
}
