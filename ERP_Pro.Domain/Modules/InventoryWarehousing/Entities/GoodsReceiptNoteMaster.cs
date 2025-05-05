using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptNoteMaster Entity
/// </summary>
public class GoodsReceiptNoteMaster : AggregateRoot<GoodsReceiptNoteMasterId>
{

    private GoodsReceiptNoteMaster() { }

    public GoodsReceiptNoteMaster(GoodsReceiptNoteMasterId id, decimal? guarantorSerial)
    {
        Id = id;
        GuarantorSerial = guarantorSerial;
    }

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
    /// GroupDate of the GoodsReceiptNoteMaster
    /// GroupDate الخاص بـ GoodsReceiptNoteMaster
    /// </summary>
    public DateTime? GroupDate { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GoodsReceiptNoteTypes GoodsReceiptNoteTypes { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

