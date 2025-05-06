using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AccountsReceivableItemSalesExportTemp Entity
/// </summary>
public class AccountsReceivableItemSalesExportTemp : Entity<AccountsReceivableItemSalesExportTempId>
{

    private AccountsReceivableItemSalesExportTemp() { }

    public AccountsReceivableItemSalesExportTemp(AccountsReceivableItemSalesExportTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableItemSalesExportTemp
    /// المعرف الفريد لـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public AccountsReceivableItemSalesExportTempId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsReceivableItemSalesExportTemp
    /// DocNo الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the AccountsReceivableItemSalesExportTemp
    /// DocType الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocDate of the AccountsReceivableItemSalesExportTemp
    /// DocDate الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FieldCode of the AccountsReceivableItemSalesExportTemp
    /// FieldCode الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public string FieldCode { get; private set; }

    /// <summary>
    /// FieldName of the AccountsReceivableItemSalesExportTemp
    /// FieldName الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public string FieldName { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsReceivableItemSalesExportTemp
    /// ItemCode الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsReceivableItemSalesExportTemp
    /// ItemUnit الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsReceivableItemSalesExportTemp
    /// WarehouseCode الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the AccountsReceivableItemSalesExportTemp
    /// BatchNumber الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsReceivableItemSalesExportTemp
    /// RecordNumber الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AccountsReceivableItemSalesExportTemp
    /// ProcessedFlagFull الخاص بـ AccountsReceivableItemSalesExportTemp
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

