using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BankAdjustmentMaster Identifier Value Object
/// </summary>
public sealed class BankAdjustmentMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BankAdjustmentMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BankAdjustmentMasterId instance
    /// </summary>
    public BankAdjustmentMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BankAdjustmentMasterId with a new GUID
    /// </summary>
    public static BankAdjustmentMasterId CreateUnique()
    {
        return new BankAdjustmentMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BankAdjustmentMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BankAdjustmentMasterId id) => id.Value;
}
}
