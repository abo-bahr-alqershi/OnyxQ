using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryBarcodeConfig Entity
/// </summary>
public class InventoryBarcodeConfig : Entity<InventoryBarcodeConfigId>
{

    private InventoryBarcodeConfig() { }

    public InventoryBarcodeConfig(InventoryBarcodeConfigId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the InventoryBarcodeConfig
    /// المعرف الفريد لـ InventoryBarcodeConfig
    /// </summary>
    public InventoryBarcodeConfigId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryBarcodeConfig
    /// RecordNumber الخاص بـ InventoryBarcodeConfig
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BarcodeLength of the InventoryBarcodeConfig
    /// BarcodeLength الخاص بـ InventoryBarcodeConfig
    /// </summary>
    public decimal? BarcodeLength { get; private set; }

    /// <summary>
    /// PrefixBarcode of the InventoryBarcodeConfig
    /// PrefixBarcode الخاص بـ InventoryBarcodeConfig
    /// </summary>
    public string PrefixBarcode { get; private set; }

    /// <summary>
    /// SubstringStartIndex of the InventoryBarcodeConfig
    /// SubstringStartIndex الخاص بـ InventoryBarcodeConfig
    /// </summary>
    public decimal? SubstringStartIndex { get; private set; }

    /// <summary>
    /// SubstringEndIndex of the InventoryBarcodeConfig
    /// SubstringEndIndex الخاص بـ InventoryBarcodeConfig
    /// </summary>
    public decimal? SubstringEndIndex { get; private set; }

    /// <summary>
    /// AddPrefixCode of the InventoryBarcodeConfig
    /// AddPrefixCode الخاص بـ InventoryBarcodeConfig
    /// </summary>
    public string AddPrefixCode { get; private set; }

    /// <summary>
    /// AddSuffixCode of the InventoryBarcodeConfig
    /// AddSuffixCode الخاص بـ InventoryBarcodeConfig
    /// </summary>
    public string AddSuffixCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
