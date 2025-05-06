using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// ColumnDetailGeneralLedger Identifier Value Object
/// </summary>
public sealed class ColumnDetailGeneralLedgerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ColumnDetailGeneralLedger
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ColumnDetailGeneralLedgerId instance
    /// </summary>
    public ColumnDetailGeneralLedgerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ColumnDetailGeneralLedgerId with a new GUID
    /// </summary>
    public static ColumnDetailGeneralLedgerId CreateUnique()
    {
        return new ColumnDetailGeneralLedgerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ColumnDetailGeneralLedgerId id) => id.Value.ToString();
    public static implicit operator Guid(ColumnDetailGeneralLedgerId id) => id.Value;
}
}
