using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// TransferQuantityApproved Identifier Value Object
/// </summary>
public sealed class TransferQuantityApprovedId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferQuantityApproved
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferQuantityApprovedId instance
    /// </summary>
    public TransferQuantityApprovedId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferQuantityApprovedId with a new GUID
    /// </summary>
    public static TransferQuantityApprovedId CreateUnique()
    {
        return new TransferQuantityApprovedId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferQuantityApprovedId id) => id.Value.ToString();
    public static implicit operator Guid(TransferQuantityApprovedId id) => id.Value;
}
}
