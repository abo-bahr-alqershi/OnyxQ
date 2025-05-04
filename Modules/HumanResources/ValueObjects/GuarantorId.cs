using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// Guarantor Identifier Value Object
/// </summary>
public sealed class GuarantorId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Guarantor
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GuarantorId instance
    /// </summary>
    public GuarantorId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GuarantorId with a new GUID
    /// </summary>
    public static GuarantorId CreateUnique()
    {
        return new GuarantorId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GuarantorId id) => id.Value.ToString();
    public static implicit operator Guid(GuarantorId id) => id.Value;
}
}
