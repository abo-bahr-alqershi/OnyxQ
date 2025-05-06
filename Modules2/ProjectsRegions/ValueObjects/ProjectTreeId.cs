using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// ProjectTree Identifier Value Object
/// </summary>
public sealed class ProjectTreeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ProjectTree
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ProjectTreeId instance
    /// </summary>
    public ProjectTreeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ProjectTreeId with a new GUID
    /// </summary>
    public static ProjectTreeId CreateUnique()
    {
        return new ProjectTreeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ProjectTreeId id) => id.Value.ToString();
    public static implicit operator Guid(ProjectTreeId id) => id.Value;
}
}
