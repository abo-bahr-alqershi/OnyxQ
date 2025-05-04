using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// GuaranteeType Identifier Value Object
/// </summary>
public sealed class GuaranteeTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GuaranteeType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GuaranteeTypeId instance
    /// </summary>
    public GuaranteeTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GuaranteeTypeId with a new GUID
    /// </summary>
    public static GuaranteeTypeId CreateUnique()
    {
        return new GuaranteeTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GuaranteeTypeId id) => id.Value.ToString();
    public static implicit operator Guid(GuaranteeTypeId id) => id.Value;
}
}
