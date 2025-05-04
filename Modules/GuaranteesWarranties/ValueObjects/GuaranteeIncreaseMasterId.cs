using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// GuaranteeIncreaseMaster Identifier Value Object
/// </summary>
public sealed class GuaranteeIncreaseMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GuaranteeIncreaseMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GuaranteeIncreaseMasterId instance
    /// </summary>
    public GuaranteeIncreaseMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GuaranteeIncreaseMasterId with a new GUID
    /// </summary>
    public static GuaranteeIncreaseMasterId CreateUnique()
    {
        return new GuaranteeIncreaseMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GuaranteeIncreaseMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GuaranteeIncreaseMasterId id) => id.Value;
}
}
