using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApprovedUserDetail Identifier Value Object
/// </summary>
public sealed class ApprovedUserDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApprovedUserDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApprovedUserDetailId instance
    /// </summary>
    public ApprovedUserDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApprovedUserDetailId with a new GUID
    /// </summary>
    public static ApprovedUserDetailId CreateUnique()
    {
        return new ApprovedUserDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApprovedUserDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ApprovedUserDetailId id) => id.Value;
}
}
