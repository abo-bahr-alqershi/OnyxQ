using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// PeriodBranchCurrentClose Identifier Value Object
/// </summary>
public sealed class PeriodBranchCurrentCloseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodBranchCurrentClose
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodBranchCurrentCloseId instance
    /// </summary>
    public PeriodBranchCurrentCloseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodBranchCurrentCloseId with a new GUID
    /// </summary>
    public static PeriodBranchCurrentCloseId CreateUnique()
    {
        return new PeriodBranchCurrentCloseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodBranchCurrentCloseId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodBranchCurrentCloseId id) => id.Value;
}
}
