using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// GuaranteeMaster Identifier Value Object
/// </summary>
public sealed class GuaranteeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GuaranteeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GuaranteeMasterId instance
    /// </summary>
    public GuaranteeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GuaranteeMasterId with a new GUID
    /// </summary>
    public static GuaranteeMasterId CreateUnique()
    {
        return new GuaranteeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GuaranteeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GuaranteeMasterId id) => id.Value;
}
}
