using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// VendorAccount Identifier Value Object
/// </summary>
public sealed class VendorAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorAccountId instance
    /// </summary>
    public VendorAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorAccountId with a new GUID
    /// </summary>
    public static VendorAccountId CreateUnique()
    {
        return new VendorAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorAccountId id) => id.Value.ToString();
    public static implicit operator Guid(VendorAccountId id) => id.Value;
}
}
