using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// TrustMaster Identifier Value Object
/// </summary>
public sealed class TrustMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TrustMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TrustMasterId instance
    /// </summary>
    public TrustMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TrustMasterId with a new GUID
    /// </summary>
    public static TrustMasterId CreateUnique()
    {
        return new TrustMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TrustMasterId id) => id.Value.ToString();
    public static implicit operator Guid(TrustMasterId id) => id.Value;
}
}
