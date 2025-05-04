using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// ProjectGroup Identifier Value Object
/// </summary>
public sealed class ProjectGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ProjectGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ProjectGroupId instance
    /// </summary>
    public ProjectGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ProjectGroupId with a new GUID
    /// </summary>
    public static ProjectGroupId CreateUnique()
    {
        return new ProjectGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ProjectGroupId id) => id.Value.ToString();
    public static implicit operator Guid(ProjectGroupId id) => id.Value;
}
}
