using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceItemGroupMaster Identifier Value Object
/// </summary>
public sealed class InsuranceItemGroupMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceItemGroupMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceItemGroupMasterId instance
    /// </summary>
    public InsuranceItemGroupMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceItemGroupMasterId with a new GUID
    /// </summary>
    public static InsuranceItemGroupMasterId CreateUnique()
    {
        return new InsuranceItemGroupMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceItemGroupMasterId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceItemGroupMasterId id) => id.Value;
}
}
