using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// VendorTransactionTemp Entity
/// </summary>
public class VendorTransactionTemp : Entity<VendorTransactionTempId>
{

    private VendorTransactionTemp() { }

    public VendorTransactionTemp(VendorTransactionTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the VendorTransactionTemp
    /// المعرف الفريد لـ VendorTransactionTemp
    /// </summary>
    public VendorTransactionTempId Id { get; private set; }

    /// <summary>
    /// DocType of the VendorTransactionTemp
    /// DocType الخاص بـ VendorTransactionTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// ReceiverNumber of the VendorTransactionTemp
    /// ReceiverNumber الخاص بـ VendorTransactionTemp
    /// </summary>
    public decimal? ReceiverNumber { get; private set; }

    /// <summary>
    /// InOutFlag of the VendorTransactionTemp
    /// InOutFlag الخاص بـ VendorTransactionTemp
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// VendorCode of the VendorTransactionTemp
    /// VendorCode الخاص بـ VendorTransactionTemp
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ItemCode of the VendorTransactionTemp
    /// ItemCode الخاص بـ VendorTransactionTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the VendorTransactionTemp
    /// ItemNameFull الخاص بـ VendorTransactionTemp
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemUnit of the VendorTransactionTemp
    /// ItemUnit الخاص بـ VendorTransactionTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// StockCost of the VendorTransactionTemp
    /// StockCost الخاص بـ VendorTransactionTemp
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// PQuantity of the VendorTransactionTemp
    /// PQuantity الخاص بـ VendorTransactionTemp
    /// </summary>
    public decimal? PQuantity { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
