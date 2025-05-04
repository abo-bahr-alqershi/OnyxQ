using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillExpireDetail Entity
/// </summary>
public class BillExpireDetail : Entity<BillExpireDetailId>
{
    private BillExpireDetail() { }

    /// <summary>
    /// The unique identifier for the BillExpireDetail
    /// المعرف الفريد لـ BillExpireDetail
    /// </summary>
    public BillExpireDetailId Id { get; private set; }

    /// <summary>
    /// BillNumber of the BillExpireDetail
    /// BillNumber الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BillExpireDetail
    /// BillSerial الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemCode of the BillExpireDetail
    /// ItemCode الخاص بـ BillExpireDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the BillExpireDetail
    /// ItemUnit الخاص بـ BillExpireDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BillExpireDetail
    /// PSize الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the BillExpireDetail
    /// WarehouseCode الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the BillExpireDetail
    /// ItemNameFull الخاص بـ BillExpireDetail
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemQuantity of the BillExpireDetail
    /// ItemQuantity الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the BillExpireDetail
    /// PQuantity الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BillExpireDetail
    /// ItemPriceShort الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// RecordNumber of the BillExpireDetail
    /// RecordNumber الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillExpireDetail
    /// CompanyNumberShort الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillExpireDetail
    /// BranchNumber الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BillExpireDetail
    /// BranchYear الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BillExpireDetail
    /// BranchUser الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// VendorCode of the BillExpireDetail
    /// VendorCode الخاص بـ BillExpireDetail
    /// </summary>
    public string VendorCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BillExpireMaster
    /// </summary>
    public BillExpireMaster BillExpireMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
