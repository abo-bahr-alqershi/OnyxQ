using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// VendorCoverageTemp Identifier Value Object
/// </summary>
public sealed class VendorCoverageTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VendorCoverageTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VendorCoverageTempId instance
    /// </summary>
    public VendorCoverageTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VendorCoverageTempId with a new GUID
    /// </summary>
    public static VendorCoverageTempId CreateUnique()
    {
        return new VendorCoverageTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VendorCoverageTempId id) => id.Value.ToString();
    public static implicit operator Guid(VendorCoverageTempId id) => id.Value;
}
}
