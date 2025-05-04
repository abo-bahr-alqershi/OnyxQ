using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// OtherCharge Identifier Value Object
/// </summary>
public sealed class OtherChargeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OtherCharge
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OtherChargeId instance
    /// </summary>
    public OtherChargeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OtherChargeId with a new GUID
    /// </summary>
    public static OtherChargeId CreateUnique()
    {
        return new OtherChargeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OtherChargeId id) => id.Value.ToString();
    public static implicit operator Guid(OtherChargeId id) => id.Value;
}
}
