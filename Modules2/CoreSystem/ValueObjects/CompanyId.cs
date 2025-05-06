using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// Company Identifier Value Object
/// </summary>
public sealed class CompanyId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Company
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CompanyId instance
    /// </summary>
    public CompanyId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CompanyId with a new GUID
    /// </summary>
    public static CompanyId CreateUnique()
    {
        return new CompanyId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CompanyId id) => id.Value.ToString();
    public static implicit operator Guid(CompanyId id) => id.Value;
}
}
