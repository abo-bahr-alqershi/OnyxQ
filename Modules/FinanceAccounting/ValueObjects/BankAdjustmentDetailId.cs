using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BankAdjustmentDetail Identifier Value Object
/// </summary>
public sealed class BankAdjustmentDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BankAdjustmentDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BankAdjustmentDetailId instance
    /// </summary>
    public BankAdjustmentDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BankAdjustmentDetailId with a new GUID
    /// </summary>
    public static BankAdjustmentDetailId CreateUnique()
    {
        return new BankAdjustmentDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BankAdjustmentDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BankAdjustmentDetailId id) => id.Value;
}
}
