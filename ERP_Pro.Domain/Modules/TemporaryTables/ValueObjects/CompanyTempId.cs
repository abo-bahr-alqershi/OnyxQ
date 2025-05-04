using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// CompanyTemp Identifier Value Object
/// </summary>
public sealed class CompanyTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CompanyTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CompanyTempId instance
    /// </summary>
    public CompanyTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CompanyTempId with a new GUID
    /// </summary>
    public static CompanyTempId CreateUnique()
    {
        return new CompanyTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CompanyTempId id) => id.Value.ToString();
    public static implicit operator Guid(CompanyTempId id) => id.Value;
}
}
