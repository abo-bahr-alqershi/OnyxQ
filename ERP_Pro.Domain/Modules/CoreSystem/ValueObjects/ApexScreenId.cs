using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApexScreen Identifier Value Object
/// </summary>
public sealed class ApexScreenId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApexScreen
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApexScreenId instance
    /// </summary>
    public ApexScreenId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApexScreenId with a new GUID
    /// </summary>
    public static ApexScreenId CreateUnique()
    {
        return new ApexScreenId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApexScreenId id) => id.Value.ToString();
    public static implicit operator Guid(ApexScreenId id) => id.Value;
}
}
