using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// SubGroupDetail Identifier Value Object
/// </summary>
public sealed class SubGroupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SubGroupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SubGroupDetailId instance
    /// </summary>
    public SubGroupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SubGroupDetailId with a new GUID
    /// </summary>
    public static SubGroupDetailId CreateUnique()
    {
        return new SubGroupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SubGroupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SubGroupDetailId id) => id.Value;
}
}
