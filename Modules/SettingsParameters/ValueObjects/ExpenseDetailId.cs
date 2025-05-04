using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// ExpenseDetail Identifier Value Object
/// </summary>
public sealed class ExpenseDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ExpenseDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ExpenseDetailId instance
    /// </summary>
    public ExpenseDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ExpenseDetailId with a new GUID
    /// </summary>
    public static ExpenseDetailId CreateUnique()
    {
        return new ExpenseDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ExpenseDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ExpenseDetailId id) => id.Value;
}
}
