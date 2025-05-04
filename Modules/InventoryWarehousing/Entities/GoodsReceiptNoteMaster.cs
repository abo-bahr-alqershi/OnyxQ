using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptNoteMaster Entity
/// </summary>
public class GoodsReceiptNoteMaster : Entity<GoodsReceiptNoteMasterId>
{
    private GoodsReceiptNoteMaster() { }

    /// <summary>
    /// The unique identifier for the GoodsReceiptNoteMaster
    /// المعرف الفريد لـ GoodsReceiptNoteMaster
    /// </summary>
    public GoodsReceiptNoteMasterId Id { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GoodsReceiptNoteMaster
    /// GroupNumberFull الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the GoodsReceiptNoteMaster
    /// GuarantorSerial الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// GoodsReceiptType of the GoodsReceiptNoteMaster
    /// GoodsReceiptType الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? GoodsReceiptType { get; private set; }

    /// <summary>
    /// GroupDate of the GoodsReceiptNoteMaster
    /// GroupDate الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public DateTime? GroupDate { get; private set; }

    /// <summary>
    /// VendorCode of the GoodsReceiptNoteMaster
    /// VendorCode الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the GoodsReceiptNoteMaster
    /// WarehouseCode الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the GoodsReceiptNoteMaster
    /// AccountCurrency الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GoodsReceiptNoteMaster
    /// ReferenceNumber الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the GoodsReceiptNoteMaster
    /// AccountDescription الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// CostCenterCode of the GoodsReceiptNoteMaster
    /// CostCenterCode الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GoodsReceiptNoteMaster
    /// ProjectNumber الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GoodsReceiptNoteMaster
    /// ActivityNumber الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// VendorName of the GoodsReceiptNoteMaster
    /// VendorName الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the GoodsReceiptNoteMaster
    /// ProcessedFlagFull الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// BillDateVoucherCode of the GoodsReceiptNoteMaster
    /// BillDateVoucherCode الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public DateTime? BillDateVoucherCode { get; private set; }

    /// <summary>
    /// BillNumberVoucherCode of the GoodsReceiptNoteMaster
    /// BillNumberVoucherCode الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string BillNumberVoucherCode { get; private set; }

    /// <summary>
    /// ContractNumber of the GoodsReceiptNoteMaster
    /// ContractNumber الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerial of the GoodsReceiptNoteMaster
    /// ContractSerial الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public string ContractSerial { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GoodsReceiptNoteMaster
    /// CompanyNumberShort الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GoodsReceiptNoteMaster
    /// BranchNumber الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GoodsReceiptNoteMaster
    /// BranchYear الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GoodsReceiptNoteMaster
    /// BranchUser الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: GoodsReceiptNoteMaster to GoodsReceiptNoteDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteDetail> GoodsReceiptNoteDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GoodsReceiptNoteTypes
    /// </summary>
    public GoodsReceiptNoteTypes GoodsReceiptNoteTypes { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
