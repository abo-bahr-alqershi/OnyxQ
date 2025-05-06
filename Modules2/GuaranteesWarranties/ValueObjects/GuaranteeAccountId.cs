using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// GuaranteeAccount Identifier Value Object
/// </summary>
public sealed class GuaranteeAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GuaranteeAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GuaranteeAccountId instance
    /// </summary>
    public GuaranteeAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GuaranteeAccountId with a new GUID
    /// </summary>
    public static GuaranteeAccountId CreateUnique()
    {
        return new GuaranteeAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GuaranteeAccountId id) => id.Value.ToString();
    public static implicit operator Guid(GuaranteeAccountId id) => id.Value;
}
}
