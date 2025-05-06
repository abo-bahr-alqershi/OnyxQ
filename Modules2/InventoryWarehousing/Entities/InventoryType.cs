using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryType Entity
/// </summary>
public class InventoryType : Entity<InventoryTypeId>
{

    private InventoryType() { }

    public InventoryType(InventoryTypeId id, decimal? invoiceType)
    {
        Id = id;
        InvoiceType = invoiceType;
    }

    /// <summary>
    /// The unique identifier for the InventoryType
    /// المعرف الفريد لـ InventoryType
    /// </summary>
    public InventoryTypeId Id { get; private set; }

    /// <summary>
    /// InvoiceType of the InventoryType
    /// InvoiceType الخاص بـ InventoryType
    /// </summary>
    public decimal? InvoiceType { get; private set; }

    /// <summary>
    /// InvoiceName of the InventoryType
    /// InvoiceName الخاص بـ InventoryType
    /// </summary>
    public string InvoiceName { get; private set; }

    /// <summary>
    /// InvoiceNameEnglish of the InventoryType
    /// InvoiceNameEnglish الخاص بـ InventoryType
    /// </summary>
    public string InvoiceNameEnglish { get; private set; }

    /// <summary>
    /// InvoiceSerialShort of the InventoryType
    /// InvoiceSerialShort الخاص بـ InventoryType
    /// </summary>
    public decimal? InvoiceSerialShort { get; private set; }

    /// <summary>
    /// InvoiceSubItems of the InventoryType
    /// InvoiceSubItems الخاص بـ InventoryType
    /// </summary>
    public decimal? InvoiceSubItems { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

