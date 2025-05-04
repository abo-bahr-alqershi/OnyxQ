using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanDocumentSyncDetails Identifier Value Object
/// </summary>
public sealed class SalesmanDocumentSyncDetailsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanDocumentSyncDetails
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanDocumentSyncDetailsId instance
    /// </summary>
    public SalesmanDocumentSyncDetailsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanDocumentSyncDetailsId with a new GUID
    /// </summary>
    public static SalesmanDocumentSyncDetailsId CreateUnique()
    {
        return new SalesmanDocumentSyncDetailsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanDocumentSyncDetailsId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanDocumentSyncDetailsId id) => id.Value;
}
}
