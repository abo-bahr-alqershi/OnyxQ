using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects;
namespace ERP_Pro.Domain.ERP.TransportationShipping.Entities
{
/// <summary>
/// DriverIdentification Entity
/// </summary>
public class DriverIdentification : Entity<DriverIdentificationId>
{

    private DriverIdentification() { }

    public DriverIdentification(DriverIdentificationId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the DriverIdentification
    /// المعرف الفريد لـ DriverIdentification
    /// </summary>
    public DriverIdentificationId Id { get; private set; }

    /// <summary>
    /// IdSequence of the DriverIdentification
    /// IdSequence الخاص بـ DriverIdentification
    /// </summary>
    public decimal? IdSequence { get; private set; }

    /// <summary>
    /// SignatureImageName of the DriverIdentification
    /// SignatureImageName الخاص بـ DriverIdentification
    /// </summary>
    public string SignatureImageName { get; private set; }

    /// <summary>
    /// RecordNumber of the DriverIdentification
    /// RecordNumber الخاص بـ DriverIdentification
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// TypeCredit of the DriverIdentification
    /// TypeCredit الخاص بـ DriverIdentification
    /// </summary>
    public decimal? TypeCredit { get; private set; }

    /// <summary>
    /// CreditNumber of the DriverIdentification
    /// CreditNumber الخاص بـ DriverIdentification
    /// </summary>
    public string CreditNumber { get; private set; }

    /// <summary>
    /// ImagePath of the DriverIdentification
    /// ImagePath الخاص بـ DriverIdentification
    /// </summary>
    public string ImagePath { get; private set; }

    /// <summary>
    /// SignatureImage of the DriverIdentification
    /// SignatureImage الخاص بـ DriverIdentification
    /// </summary>
    public byte[] SignatureImage { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Driver Driver { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

