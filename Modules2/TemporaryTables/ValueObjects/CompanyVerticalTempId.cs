using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// CompanyVerticalTemp Identifier Value Object
/// </summary>
public sealed class CompanyVerticalTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CompanyVerticalTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CompanyVerticalTempId instance
    /// </summary>
    public CompanyVerticalTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CompanyVerticalTempId with a new GUID
    /// </summary>
    public static CompanyVerticalTempId CreateUnique()
    {
        return new CompanyVerticalTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CompanyVerticalTempId id) => id.Value.ToString();
    public static implicit operator Guid(CompanyVerticalTempId id) => id.Value;
}
}
