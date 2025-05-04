using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// Project Identifier Value Object
/// </summary>
public sealed class ProjectId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Project
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ProjectId instance
    /// </summary>
    public ProjectId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ProjectId with a new GUID
    /// </summary>
    public static ProjectId CreateUnique()
    {
        return new ProjectId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ProjectId id) => id.Value.ToString();
    public static implicit operator Guid(ProjectId id) => id.Value;
}
}
