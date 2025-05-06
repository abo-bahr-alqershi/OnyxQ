using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// CheckDocumentInOutQuantityDetail Identifier Value Object
/// </summary>
public sealed class CheckDocumentInOutQuantityDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CheckDocumentInOutQuantityDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CheckDocumentInOutQuantityDetailId instance
    /// </summary>
    public CheckDocumentInOutQuantityDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CheckDocumentInOutQuantityDetailId with a new GUID
    /// </summary>
    public static CheckDocumentInOutQuantityDetailId CreateUnique()
    {
        return new CheckDocumentInOutQuantityDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CheckDocumentInOutQuantityDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CheckDocumentInOutQuantityDetailId id) => id.Value;
}
}
