using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeKnowledge Identifier Value Object
/// </summary>
public sealed class EmployeeKnowledgeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeKnowledge
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeKnowledgeId instance
    /// </summary>
    public EmployeeKnowledgeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeKnowledgeId with a new GUID
    /// </summary>
    public static EmployeeKnowledgeId CreateUnique()
    {
        return new EmployeeKnowledgeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeKnowledgeId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeKnowledgeId id) => id.Value;
}
}
