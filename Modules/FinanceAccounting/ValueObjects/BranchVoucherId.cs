using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BranchVoucher Identifier Value Object
/// </summary>
public sealed class BranchVoucherId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchVoucher
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchVoucherId instance
    /// </summary>
    public BranchVoucherId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchVoucherId with a new GUID
    /// </summary>
    public static BranchVoucherId CreateUnique()
    {
        return new BranchVoucherId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchVoucherId id) => id.Value.ToString();
    public static implicit operator Guid(BranchVoucherId id) => id.Value;
}
}
