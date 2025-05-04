using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesType Entity
/// </summary>
public class SalesType : Entity<SalesTypeId>
{

    private SalesType() { }

    public SalesType(SalesTypeId id, decimal? salesInvoiceType)
    {
        Id = id;
        SalesInvoiceType = salesInvoiceType;
    }

    /// <summary>
    /// The unique identifier for the SalesType
    /// المعرف الفريد لـ SalesType
    /// </summary>
    public SalesTypeId Id { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the SalesType
    /// SalesInvoiceType الخاص بـ SalesType
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// SalesInvoiceAccountName of the SalesType
    /// SalesInvoiceAccountName الخاص بـ SalesType
    /// </summary>
    public string SalesInvoiceAccountName { get; private set; }

    /// <summary>
    /// SalesInvoiceNameEnglish of the SalesType
    /// SalesInvoiceNameEnglish الخاص بـ SalesType
    /// </summary>
    public string SalesInvoiceNameEnglish { get; private set; }

    /// <summary>
    /// SalesInvoiceSerial of the SalesType
    /// SalesInvoiceSerial الخاص بـ SalesType
    /// </summary>
    public decimal? SalesInvoiceSerial { get; private set; }

    /// <summary>
    /// PriceLevel of the SalesType
    /// PriceLevel الخاص بـ SalesType
    /// </summary>
    public decimal? PriceLevel { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SalesType
    /// BillDocumentTypeFull الخاص بـ SalesType
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
