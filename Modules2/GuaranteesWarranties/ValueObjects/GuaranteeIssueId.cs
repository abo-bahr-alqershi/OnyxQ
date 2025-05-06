using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// GuaranteeIssue Identifier Value Object
/// </summary>
public sealed class GuaranteeIssueId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GuaranteeIssue
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GuaranteeIssueId instance
    /// </summary>
    public GuaranteeIssueId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GuaranteeIssueId with a new GUID
    /// </summary>
    public static GuaranteeIssueId CreateUnique()
    {
        return new GuaranteeIssueId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GuaranteeIssueId id) => id.Value.ToString();
    public static implicit operator Guid(GuaranteeIssueId id) => id.Value;
}
}
