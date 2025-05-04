using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects
{
/// <summary>
/// LetterOfCreditDetail Identifier Value Object
/// </summary>
public sealed class LetterOfCreditDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the LetterOfCreditDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new LetterOfCreditDetailId instance
    /// </summary>
    public LetterOfCreditDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new LetterOfCreditDetailId with a new GUID
    /// </summary>
    public static LetterOfCreditDetailId CreateUnique()
    {
        return new LetterOfCreditDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(LetterOfCreditDetailId id) => id.Value.ToString();
    public static implicit operator Guid(LetterOfCreditDetailId id) => id.Value;
}
}
