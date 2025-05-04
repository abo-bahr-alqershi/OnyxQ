using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// OtherChargeItem Identifier Value Object
/// </summary>
public sealed class OtherChargeItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OtherChargeItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OtherChargeItemId instance
    /// </summary>
    public OtherChargeItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OtherChargeItemId with a new GUID
    /// </summary>
    public static OtherChargeItemId CreateUnique()
    {
        return new OtherChargeItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OtherChargeItemId id) => id.Value.ToString();
    public static implicit operator Guid(OtherChargeItemId id) => id.Value;
}
}
