using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillDetail Identifier Value Object
/// </summary>
public sealed class BillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillDetailId instance
    /// </summary>
    public BillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillDetailId with a new GUID
    /// </summary>
    public static BillDetailId CreateUnique()
    {
        return new BillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BillDetailId id) => id.Value;
}
}
