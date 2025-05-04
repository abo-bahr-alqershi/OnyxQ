using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// OtherItemSerialNumber Identifier Value Object
/// </summary>
public sealed class OtherItemSerialNumberId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OtherItemSerialNumber
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OtherItemSerialNumberId instance
    /// </summary>
    public OtherItemSerialNumberId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OtherItemSerialNumberId with a new GUID
    /// </summary>
    public static OtherItemSerialNumberId CreateUnique()
    {
        return new OtherItemSerialNumberId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OtherItemSerialNumberId id) => id.Value.ToString();
    public static implicit operator Guid(OtherItemSerialNumberId id) => id.Value;
}
}
