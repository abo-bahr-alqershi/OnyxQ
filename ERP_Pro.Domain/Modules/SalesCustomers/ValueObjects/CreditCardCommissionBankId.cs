using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CreditCardCommissionBank Identifier Value Object
/// </summary>
public sealed class CreditCardCommissionBankId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CreditCardCommissionBank
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CreditCardCommissionBankId instance
    /// </summary>
    public CreditCardCommissionBankId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CreditCardCommissionBankId with a new GUID
    /// </summary>
    public static CreditCardCommissionBankId CreateUnique()
    {
        return new CreditCardCommissionBankId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CreditCardCommissionBankId id) => id.Value.ToString();
    public static implicit operator Guid(CreditCardCommissionBankId id) => id.Value;
}
}
