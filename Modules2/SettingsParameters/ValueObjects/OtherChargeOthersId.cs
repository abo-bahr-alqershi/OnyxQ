using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// OtherChargeOthers Identifier Value Object
/// </summary>
public sealed class OtherChargeOthersId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OtherChargeOthers
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OtherChargeOthersId instance
    /// </summary>
    public OtherChargeOthersId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OtherChargeOthersId with a new GUID
    /// </summary>
    public static OtherChargeOthersId CreateUnique()
    {
        return new OtherChargeOthersId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OtherChargeOthersId id) => id.Value.ToString();
    public static implicit operator Guid(OtherChargeOthersId id) => id.Value;
}
}
