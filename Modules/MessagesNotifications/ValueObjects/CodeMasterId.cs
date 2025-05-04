using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// CodeMaster Identifier Value Object
/// </summary>
public sealed class CodeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CodeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CodeMasterId instance
    /// </summary>
    public CodeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CodeMasterId with a new GUID
    /// </summary>
    public static CodeMasterId CreateUnique()
    {
        return new CodeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CodeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CodeMasterId id) => id.Value;
}
}
