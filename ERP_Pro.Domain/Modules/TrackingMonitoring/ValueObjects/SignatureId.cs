using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// Signature Identifier Value Object
/// </summary>
public sealed class SignatureId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Signature
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SignatureId instance
    /// </summary>
    public SignatureId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SignatureId with a new GUID
    /// </summary>
    public static SignatureId CreateUnique()
    {
        return new SignatureId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SignatureId id) => id.Value.ToString();
    public static implicit operator Guid(SignatureId id) => id.Value;
}
}
