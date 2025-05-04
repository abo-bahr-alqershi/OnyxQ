using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// BranchYearsTemp Identifier Value Object
/// </summary>
public sealed class BranchYearsTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchYearsTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchYearsTempId instance
    /// </summary>
    public BranchYearsTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchYearsTempId with a new GUID
    /// </summary>
    public static BranchYearsTempId CreateUnique()
    {
        return new BranchYearsTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchYearsTempId id) => id.Value.ToString();
    public static implicit operator Guid(BranchYearsTempId id) => id.Value;
}
}
