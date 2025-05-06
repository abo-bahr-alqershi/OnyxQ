using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// GuaranteeIncrease Identifier Value Object
/// </summary>
public sealed class GuaranteeIncreaseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GuaranteeIncrease
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GuaranteeIncreaseId instance
    /// </summary>
    public GuaranteeIncreaseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GuaranteeIncreaseId with a new GUID
    /// </summary>
    public static GuaranteeIncreaseId CreateUnique()
    {
        return new GuaranteeIncreaseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GuaranteeIncreaseId id) => id.Value.ToString();
    public static implicit operator Guid(GuaranteeIncreaseId id) => id.Value;
}
}
