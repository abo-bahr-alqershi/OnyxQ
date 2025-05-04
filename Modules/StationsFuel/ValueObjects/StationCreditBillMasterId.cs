using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationCreditBillMaster Identifier Value Object
/// </summary>
public sealed class StationCreditBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationCreditBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationCreditBillMasterId instance
    /// </summary>
    public StationCreditBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationCreditBillMasterId with a new GUID
    /// </summary>
    public static StationCreditBillMasterId CreateUnique()
    {
        return new StationCreditBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationCreditBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(StationCreditBillMasterId id) => id.Value;
}
}
