using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillExpireDetail Identifier Value Object
/// </summary>
public sealed class BillExpireDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillExpireDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillExpireDetailId instance
    /// </summary>
    public BillExpireDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillExpireDetailId with a new GUID
    /// </summary>
    public static BillExpireDetailId CreateUnique()
    {
        return new BillExpireDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillExpireDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BillExpireDetailId id) => id.Value;
}
}
