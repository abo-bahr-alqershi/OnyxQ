using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PrintBarcodeTemp Identifier Value Object
/// </summary>
public sealed class PrintBarcodeTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrintBarcodeTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrintBarcodeTempId instance
    /// </summary>
    public PrintBarcodeTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrintBarcodeTempId with a new GUID
    /// </summary>
    public static PrintBarcodeTempId CreateUnique()
    {
        return new PrintBarcodeTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrintBarcodeTempId id) => id.Value.ToString();
    public static implicit operator Guid(PrintBarcodeTempId id) => id.Value;
}
}
