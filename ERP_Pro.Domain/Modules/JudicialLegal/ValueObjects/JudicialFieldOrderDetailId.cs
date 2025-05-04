using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects
{
/// <summary>
/// JudicialFieldOrderDetail Identifier Value Object
/// </summary>
public sealed class JudicialFieldOrderDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JudicialFieldOrderDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JudicialFieldOrderDetailId instance
    /// </summary>
    public JudicialFieldOrderDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JudicialFieldOrderDetailId with a new GUID
    /// </summary>
    public static JudicialFieldOrderDetailId CreateUnique()
    {
        return new JudicialFieldOrderDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JudicialFieldOrderDetailId id) => id.Value.ToString();
    public static implicit operator Guid(JudicialFieldOrderDetailId id) => id.Value;
}
}
