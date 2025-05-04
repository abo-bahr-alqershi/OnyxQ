using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// AssistantGroup Identifier Value Object
/// </summary>
public sealed class AssistantGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AssistantGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AssistantGroupId instance
    /// </summary>
    public AssistantGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AssistantGroupId with a new GUID
    /// </summary>
    public static AssistantGroupId CreateUnique()
    {
        return new AssistantGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AssistantGroupId id) => id.Value.ToString();
    public static implicit operator Guid(AssistantGroupId id) => id.Value;
}
}
