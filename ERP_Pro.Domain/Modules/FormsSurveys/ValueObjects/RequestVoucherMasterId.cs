using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// RequestVoucherMaster Identifier Value Object
/// </summary>
public sealed class RequestVoucherMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestVoucherMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestVoucherMasterId instance
    /// </summary>
    public RequestVoucherMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestVoucherMasterId with a new GUID
    /// </summary>
    public static RequestVoucherMasterId CreateUnique()
    {
        return new RequestVoucherMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestVoucherMasterId id) => id.Value.ToString();
    public static implicit operator Guid(RequestVoucherMasterId id) => id.Value;
}
}
