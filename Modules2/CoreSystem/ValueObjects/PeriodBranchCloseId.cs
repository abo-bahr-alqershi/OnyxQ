using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// PeriodBranchClose Identifier Value Object
/// </summary>
public sealed class PeriodBranchCloseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodBranchClose
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodBranchCloseId instance
    /// </summary>
    public PeriodBranchCloseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodBranchCloseId with a new GUID
    /// </summary>
    public static PeriodBranchCloseId CreateUnique()
    {
        return new PeriodBranchCloseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodBranchCloseId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodBranchCloseId id) => id.Value;
}
}
