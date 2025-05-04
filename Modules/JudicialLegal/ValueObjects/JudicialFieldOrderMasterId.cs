using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects
{
/// <summary>
/// JudicialFieldOrderMaster Identifier Value Object
/// </summary>
public sealed class JudicialFieldOrderMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JudicialFieldOrderMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JudicialFieldOrderMasterId instance
    /// </summary>
    public JudicialFieldOrderMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JudicialFieldOrderMasterId with a new GUID
    /// </summary>
    public static JudicialFieldOrderMasterId CreateUnique()
    {
        return new JudicialFieldOrderMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JudicialFieldOrderMasterId id) => id.Value.ToString();
    public static implicit operator Guid(JudicialFieldOrderMasterId id) => id.Value;
}
}
