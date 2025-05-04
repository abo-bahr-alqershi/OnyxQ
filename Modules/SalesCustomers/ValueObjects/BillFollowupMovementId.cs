using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillFollowupMovement Identifier Value Object
/// </summary>
public sealed class BillFollowupMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillFollowupMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillFollowupMovementId instance
    /// </summary>
    public BillFollowupMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillFollowupMovementId with a new GUID
    /// </summary>
    public static BillFollowupMovementId CreateUnique()
    {
        return new BillFollowupMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillFollowupMovementId id) => id.Value.ToString();
    public static implicit operator Guid(BillFollowupMovementId id) => id.Value;
}
}
