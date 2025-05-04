using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FixedAssets.ValueObjects
{
/// <summary>
/// FixedAssetMaster Identifier Value Object
/// </summary>
public sealed class FixedAssetMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the FixedAssetMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new FixedAssetMasterId instance
    /// </summary>
    public FixedAssetMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new FixedAssetMasterId with a new GUID
    /// </summary>
    public static FixedAssetMasterId CreateUnique()
    {
        return new FixedAssetMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(FixedAssetMasterId id) => id.Value.ToString();
    public static implicit operator Guid(FixedAssetMasterId id) => id.Value;
}
}
