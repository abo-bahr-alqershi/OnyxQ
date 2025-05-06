using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// MandatoryScreenFields Identifier Value Object
/// </summary>
public sealed class MandatoryScreenFieldsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MandatoryScreenFields
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MandatoryScreenFieldsId instance
    /// </summary>
    public MandatoryScreenFieldsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MandatoryScreenFieldsId with a new GUID
    /// </summary>
    public static MandatoryScreenFieldsId CreateUnique()
    {
        return new MandatoryScreenFieldsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MandatoryScreenFieldsId id) => id.Value.ToString();
    public static implicit operator Guid(MandatoryScreenFieldsId id) => id.Value;
}
}
