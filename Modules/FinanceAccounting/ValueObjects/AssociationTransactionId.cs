using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AssociationTransaction Identifier Value Object
/// </summary>
public sealed class AssociationTransactionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AssociationTransaction
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AssociationTransactionId instance
    /// </summary>
    public AssociationTransactionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AssociationTransactionId with a new GUID
    /// </summary>
    public static AssociationTransactionId CreateUnique()
    {
        return new AssociationTransactionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AssociationTransactionId id) => id.Value.ToString();
    public static implicit operator Guid(AssociationTransactionId id) => id.Value;
}
}
