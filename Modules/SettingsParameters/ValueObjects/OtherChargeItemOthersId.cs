using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// OtherChargeItemOthers Identifier Value Object
/// </summary>
public sealed class OtherChargeItemOthersId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OtherChargeItemOthers
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OtherChargeItemOthersId instance
    /// </summary>
    public OtherChargeItemOthersId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OtherChargeItemOthersId with a new GUID
    /// </summary>
    public static OtherChargeItemOthersId CreateUnique()
    {
        return new OtherChargeItemOthersId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OtherChargeItemOthersId id) => id.Value.ToString();
    public static implicit operator Guid(OtherChargeItemOthersId id) => id.Value;
}
}
