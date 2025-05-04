using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// CodeDetail Identifier Value Object
/// </summary>
public sealed class CodeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CodeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CodeDetailId instance
    /// </summary>
    public CodeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CodeDetailId with a new GUID
    /// </summary>
    public static CodeDetailId CreateUnique()
    {
        return new CodeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CodeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CodeDetailId id) => id.Value;
}
}
