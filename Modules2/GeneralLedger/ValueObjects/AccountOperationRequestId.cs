using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountOperationRequest Identifier Value Object
/// </summary>
public sealed class AccountOperationRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountOperationRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountOperationRequestId instance
    /// </summary>
    public AccountOperationRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountOperationRequestId with a new GUID
    /// </summary>
    public static AccountOperationRequestId CreateUnique()
    {
        return new AccountOperationRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountOperationRequestId id) => id.Value.ToString();
    public static implicit operator Guid(AccountOperationRequestId id) => id.Value;
}
}
