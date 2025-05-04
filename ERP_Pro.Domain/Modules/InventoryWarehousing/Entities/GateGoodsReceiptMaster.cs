using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GateGoodsReceiptMaster Entity
/// </summary>
public class GateGoodsReceiptMaster : Entity<GateGoodsReceiptMasterId>
{

    private GateGoodsReceiptMaster() { }

    public GateGoodsReceiptMaster(GateGoodsReceiptMasterId id, decimal? docNo, decimal? warehouseCode)
    {
        Id = id;
        DocNo = docNo;
        WarehouseCode = warehouseCode;
    }

    /// <summary>
    /// The unique identifier for the GateGoodsReceiptMaster
    /// المعرف الفريد لـ GateGoodsReceiptMaster
    /// </summary>
    public GateGoodsReceiptMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the GateGoodsReceiptMaster
    /// DocNo الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GateGoodsReceiptMaster
    /// DocSer الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// CCode of the GateGoodsReceiptMaster
    /// CCode الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// DocDate of the GateGoodsReceiptMaster
    /// DocDate الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// CarNumber of the GateGoodsReceiptMaster
    /// CarNumber الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public string CarNumber { get; private set; }

    /// <summary>
    /// DocDesc of the GateGoodsReceiptMaster
    /// DocDesc الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocPost of the GateGoodsReceiptMaster
    /// DocPost الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// WarehouseCode of the GateGoodsReceiptMaster
    /// WarehouseCode الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GateGoodsReceiptMaster
    /// CompanyNumberShort الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GateGoodsReceiptMaster
    /// BranchNumber الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GateGoodsReceiptMaster
    /// BranchYear الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GateGoodsReceiptMaster
    /// BranchUser الخاص بـ GateGoodsReceiptMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
