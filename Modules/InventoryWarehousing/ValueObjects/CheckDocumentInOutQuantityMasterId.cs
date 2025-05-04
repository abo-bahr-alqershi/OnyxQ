using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// CheckDocumentInOutQuantityMaster Identifier Value Object
/// </summary>
public sealed class CheckDocumentInOutQuantityMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CheckDocumentInOutQuantityMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CheckDocumentInOutQuantityMasterId instance
    /// </summary>
    public CheckDocumentInOutQuantityMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CheckDocumentInOutQuantityMasterId with a new GUID
    /// </summary>
    public static CheckDocumentInOutQuantityMasterId CreateUnique()
    {
        return new CheckDocumentInOutQuantityMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CheckDocumentInOutQuantityMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CheckDocumentInOutQuantityMasterId id) => id.Value;
}
}
