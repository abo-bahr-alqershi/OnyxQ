using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// GeneralCodeDetail Identifier Value Object
/// </summary>
public sealed class GeneralCodeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralCodeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralCodeDetailId instance
    /// </summary>
    public GeneralCodeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralCodeDetailId with a new GUID
    /// </summary>
    public static GeneralCodeDetailId CreateUnique()
    {
        return new GeneralCodeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralCodeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralCodeDetailId id) => id.Value;
}
}
