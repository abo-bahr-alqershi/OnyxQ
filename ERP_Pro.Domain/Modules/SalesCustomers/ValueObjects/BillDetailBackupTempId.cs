using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillDetailBackupTemp Identifier Value Object
/// </summary>
public sealed class BillDetailBackupTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillDetailBackupTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillDetailBackupTempId instance
    /// </summary>
    public BillDetailBackupTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillDetailBackupTempId with a new GUID
    /// </summary>
    public static BillDetailBackupTempId CreateUnique()
    {
        return new BillDetailBackupTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillDetailBackupTempId id) => id.Value.ToString();
    public static implicit operator Guid(BillDetailBackupTempId id) => id.Value;
}
}
