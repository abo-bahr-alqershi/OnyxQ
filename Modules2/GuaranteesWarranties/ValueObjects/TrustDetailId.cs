using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// TrustDetail Identifier Value Object
/// </summary>
public sealed class TrustDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TrustDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TrustDetailId instance
    /// </summary>
    public TrustDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TrustDetailId with a new GUID
    /// </summary>
    public static TrustDetailId CreateUnique()
    {
        return new TrustDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TrustDetailId id) => id.Value.ToString();
    public static implicit operator Guid(TrustDetailId id) => id.Value;
}
}
