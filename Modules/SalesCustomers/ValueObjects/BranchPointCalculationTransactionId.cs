using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchPointCalculationTransaction Identifier Value Object
/// </summary>
public sealed class BranchPointCalculationTransactionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchPointCalculationTransaction
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchPointCalculationTransactionId instance
    /// </summary>
    public BranchPointCalculationTransactionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchPointCalculationTransactionId with a new GUID
    /// </summary>
    public static BranchPointCalculationTransactionId CreateUnique()
    {
        return new BranchPointCalculationTransactionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchPointCalculationTransactionId id) => id.Value.ToString();
    public static implicit operator Guid(BranchPointCalculationTransactionId id) => id.Value;
}
}
