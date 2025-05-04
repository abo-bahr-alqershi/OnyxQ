using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CheckIncomeDetail Identifier Value Object
/// </summary>
public sealed class CheckIncomeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CheckIncomeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CheckIncomeDetailId instance
    /// </summary>
    public CheckIncomeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CheckIncomeDetailId with a new GUID
    /// </summary>
    public static CheckIncomeDetailId CreateUnique()
    {
        return new CheckIncomeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CheckIncomeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CheckIncomeDetailId id) => id.Value;
}
}
