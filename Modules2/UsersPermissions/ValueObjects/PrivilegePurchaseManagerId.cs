using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegePurchaseManager Identifier Value Object
/// </summary>
public sealed class PrivilegePurchaseManagerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegePurchaseManager
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegePurchaseManagerId instance
    /// </summary>
    public PrivilegePurchaseManagerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegePurchaseManagerId with a new GUID
    /// </summary>
    public static PrivilegePurchaseManagerId CreateUnique()
    {
        return new PrivilegePurchaseManagerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegePurchaseManagerId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegePurchaseManagerId id) => id.Value;
}
}
