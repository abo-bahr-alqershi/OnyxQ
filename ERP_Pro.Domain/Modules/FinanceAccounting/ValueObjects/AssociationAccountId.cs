using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AssociationAccount Identifier Value Object
/// </summary>
public sealed class AssociationAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AssociationAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AssociationAccountId instance
    /// </summary>
    public AssociationAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AssociationAccountId with a new GUID
    /// </summary>
    public static AssociationAccountId CreateUnique()
    {
        return new AssociationAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AssociationAccountId id) => id.Value.ToString();
    public static implicit operator Guid(AssociationAccountId id) => id.Value;
}
}
