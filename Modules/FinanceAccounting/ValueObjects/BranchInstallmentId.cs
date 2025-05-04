using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BranchInstallment Identifier Value Object
/// </summary>
public sealed class BranchInstallmentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchInstallment
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchInstallmentId instance
    /// </summary>
    public BranchInstallmentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchInstallmentId with a new GUID
    /// </summary>
    public static BranchInstallmentId CreateUnique()
    {
        return new BranchInstallmentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchInstallmentId id) => id.Value.ToString();
    public static implicit operator Guid(BranchInstallmentId id) => id.Value;
}
}
