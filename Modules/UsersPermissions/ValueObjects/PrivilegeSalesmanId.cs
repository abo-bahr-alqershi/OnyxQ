using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeSalesman Identifier Value Object
/// </summary>
public sealed class PrivilegeSalesmanId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeSalesman
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeSalesmanId instance
    /// </summary>
    public PrivilegeSalesmanId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeSalesmanId with a new GUID
    /// </summary>
    public static PrivilegeSalesmanId CreateUnique()
    {
        return new PrivilegeSalesmanId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeSalesmanId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeSalesmanId id) => id.Value;
}
}
