using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApprovedUser Identifier Value Object
/// </summary>
public sealed class ApprovedUserId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApprovedUser
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApprovedUserId instance
    /// </summary>
    public ApprovedUserId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApprovedUserId with a new GUID
    /// </summary>
    public static ApprovedUserId CreateUnique()
    {
        return new ApprovedUserId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApprovedUserId id) => id.Value.ToString();
    public static implicit operator Guid(ApprovedUserId id) => id.Value;
}
}
