using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// ProjectAdditionalFields Identifier Value Object
/// </summary>
public sealed class ProjectAdditionalFieldsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ProjectAdditionalFields
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ProjectAdditionalFieldsId instance
    /// </summary>
    public ProjectAdditionalFieldsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ProjectAdditionalFieldsId with a new GUID
    /// </summary>
    public static ProjectAdditionalFieldsId CreateUnique()
    {
        return new ProjectAdditionalFieldsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ProjectAdditionalFieldsId id) => id.Value.ToString();
    public static implicit operator Guid(ProjectAdditionalFieldsId id) => id.Value;
}
}
