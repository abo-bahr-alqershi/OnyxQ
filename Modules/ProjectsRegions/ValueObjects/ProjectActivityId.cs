using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// ProjectActivity Identifier Value Object
/// </summary>
public sealed class ProjectActivityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ProjectActivity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ProjectActivityId instance
    /// </summary>
    public ProjectActivityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ProjectActivityId with a new GUID
    /// </summary>
    public static ProjectActivityId CreateUnique()
    {
        return new ProjectActivityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ProjectActivityId id) => id.Value.ToString();
    public static implicit operator Guid(ProjectActivityId id) => id.Value;
}
}
