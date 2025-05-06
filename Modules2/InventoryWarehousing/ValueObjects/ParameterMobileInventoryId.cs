using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ParameterMobileInventory Identifier Value Object
/// </summary>
public sealed class ParameterMobileInventoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterMobileInventory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterMobileInventoryId instance
    /// </summary>
    public ParameterMobileInventoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterMobileInventoryId with a new GUID
    /// </summary>
    public static ParameterMobileInventoryId CreateUnique()
    {
        return new ParameterMobileInventoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterMobileInventoryId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterMobileInventoryId id) => id.Value;
}
}
