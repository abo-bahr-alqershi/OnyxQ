using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// RequestVoucherDetail Identifier Value Object
/// </summary>
public sealed class RequestVoucherDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestVoucherDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestVoucherDetailId instance
    /// </summary>
    public RequestVoucherDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestVoucherDetailId with a new GUID
    /// </summary>
    public static RequestVoucherDetailId CreateUnique()
    {
        return new RequestVoucherDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestVoucherDetailId id) => id.Value.ToString();
    public static implicit operator Guid(RequestVoucherDetailId id) => id.Value;
}
}
