using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// TelecomSetup Identifier Value Object
/// </summary>
public sealed class TelecomSetupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TelecomSetup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TelecomSetupId instance
    /// </summary>
    public TelecomSetupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TelecomSetupId with a new GUID
    /// </summary>
    public static TelecomSetupId CreateUnique()
    {
        return new TelecomSetupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TelecomSetupId id) => id.Value.ToString();
    public static implicit operator Guid(TelecomSetupId id) => id.Value;
}
}
