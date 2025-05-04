using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// VendorTdsAccount Identifier Value Object
/// </summary>
public sealed class VendorTdsAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorTdsAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorTdsAccountId instance
    /// </summary>
    public VendorTdsAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorTdsAccountId with a new GUID
    /// </summary>
    public static VendorTdsAccountId CreateUnique()
    {
        return new VendorTdsAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorTdsAccountId id) => id.Value.ToString();
    public static implicit operator Guid(VendorTdsAccountId id) => id.Value;
}
}
