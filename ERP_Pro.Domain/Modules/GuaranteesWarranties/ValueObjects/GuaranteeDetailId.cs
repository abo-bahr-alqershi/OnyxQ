using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// GuaranteeDetail Identifier Value Object
/// </summary>
public sealed class GuaranteeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GuaranteeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GuaranteeDetailId instance
    /// </summary>
    public GuaranteeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GuaranteeDetailId with a new GUID
    /// </summary>
    public static GuaranteeDetailId CreateUnique()
    {
        return new GuaranteeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GuaranteeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GuaranteeDetailId id) => id.Value;
}
}
