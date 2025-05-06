using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// MainSubGroupDetail Identifier Value Object
/// </summary>
public sealed class MainSubGroupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MainSubGroupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MainSubGroupDetailId instance
    /// </summary>
    public MainSubGroupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MainSubGroupDetailId with a new GUID
    /// </summary>
    public static MainSubGroupDetailId CreateUnique()
    {
        return new MainSubGroupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MainSubGroupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(MainSubGroupDetailId id) => id.Value;
}
}
