using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// TransferType Identifier Value Object
/// </summary>
public sealed class TransferTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferTypeId instance
    /// </summary>
    public TransferTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferTypeId with a new GUID
    /// </summary>
    public static TransferTypeId CreateUnique()
    {
        return new TransferTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferTypeId id) => id.Value.ToString();
    public static implicit operator Guid(TransferTypeId id) => id.Value;
}
}
