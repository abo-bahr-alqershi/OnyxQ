using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// ExpenseDetail Entity
/// </summary>
public class ExpenseDetail : Entity<ExpenseDetailId>
{
    private ExpenseDetail() { }

    /// <summary>
    /// The unique identifier for the ExpenseDetail
    /// المعرف الفريد لـ ExpenseDetail
    /// </summary>
    public ExpenseDetailId Id { get; private set; }

    /// <summary>
    /// PurchaseInvoiceNumber of the ExpenseDetail
    /// PurchaseInvoiceNumber الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? PurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// GroupNumberFull of the ExpenseDetail
    /// GroupNumberFull الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the ExpenseDetail
    /// GuarantorSerial الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// DocSer of the ExpenseDetail
    /// DocSer الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ItemCode of the ExpenseDetail
    /// ItemCode الخاص بـ ExpenseDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ExpenseDetail
    /// ItemUnit الخاص بـ ExpenseDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ExpenseDetail
    /// PSize الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the ExpenseDetail
    /// WarehouseCode الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ExpireDate of the ExpenseDetail
    /// ExpireDate الخاص بـ ExpenseDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ExpenseDetail
    /// BatchNumber الخاص بـ ExpenseDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the ExpenseDetail
    /// RecordNumber الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Column1 of the ExpenseDetail
    /// Column1 الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? Column1 { get; private set; }

    /// <summary>
    /// Column2 of the ExpenseDetail
    /// Column2 الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? Column2 { get; private set; }

    /// <summary>
    /// Column3 of the ExpenseDetail
    /// Column3 الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? Column3 { get; private set; }

    /// <summary>
    /// GroupRecordNumber of the ExpenseDetail
    /// GroupRecordNumber الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? GroupRecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ExpenseDetail
    /// CompanyNumberShort الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ExpenseDetail
    /// BranchNumber الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ExpenseDetail
    /// BranchYear الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ExpenseDetail
    /// BranchUser الخاص بـ ExpenseDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
