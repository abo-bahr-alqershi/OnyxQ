using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects
{
/// <summary>
/// LetterOfCreditMaster Identifier Value Object
/// </summary>
public sealed class LetterOfCreditMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the LetterOfCreditMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new LetterOfCreditMasterId instance
    /// </summary>
    public LetterOfCreditMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new LetterOfCreditMasterId with a new GUID
    /// </summary>
    public static LetterOfCreditMasterId CreateUnique()
    {
        return new LetterOfCreditMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(LetterOfCreditMasterId id) => id.Value.ToString();
    public static implicit operator Guid(LetterOfCreditMasterId id) => id.Value;
}
}
