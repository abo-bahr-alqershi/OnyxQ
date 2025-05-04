using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// GeneralCodeMaster Identifier Value Object
/// </summary>
public sealed class GeneralCodeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralCodeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralCodeMasterId instance
    /// </summary>
    public GeneralCodeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralCodeMasterId with a new GUID
    /// </summary>
    public static GeneralCodeMasterId CreateUnique()
    {
        return new GeneralCodeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralCodeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralCodeMasterId id) => id.Value;
}
}
