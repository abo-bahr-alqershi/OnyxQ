using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceItemGroupDetail Identifier Value Object
/// </summary>
public sealed class InsuranceItemGroupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceItemGroupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceItemGroupDetailId instance
    /// </summary>
    public InsuranceItemGroupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceItemGroupDetailId with a new GUID
    /// </summary>
    public static InsuranceItemGroupDetailId CreateUnique()
    {
        return new InsuranceItemGroupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceItemGroupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceItemGroupDetailId id) => id.Value;
}
}
