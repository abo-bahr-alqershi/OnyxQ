using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptIncomingMaster Entity
/// </summary>
public class GoodsReceiptIncomingMaster : AggregateRoot<GoodsReceiptIncomingMasterId>
{

    private GoodsReceiptIncomingMaster() { }

    public GoodsReceiptIncomingMaster(GoodsReceiptIncomingMasterId id, decimal? incomeSerialAlt)
    {
        Id = id;
        IncomeSerialAlt = incomeSerialAlt;
    }

    /// <summary>
    /// The unique identifier for the GoodsReceiptIncomingMaster
    /// المعرف الفريد لـ GoodsReceiptIncomingMaster
    /// </summary>
    public GoodsReceiptIncomingMasterId Id { get; private set; }

    /// <summary>
    /// IncomeNumber of the GoodsReceiptIncomingMaster
    /// IncomeNumber الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? IncomeNumber { get; private set; }

    /// <summary>
    /// IncomeSerialAlt of the GoodsReceiptIncomingMaster
    /// IncomeSerialAlt الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? IncomeSerialAlt { get; private set; }

    /// <summary>
    /// IncomeDateAlt of the GoodsReceiptIncomingMaster
    /// IncomeDateAlt الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public DateTime? IncomeDateAlt { get; private set; }

    /// <summary>
    /// DriverName of the GoodsReceiptIncomingMaster
    /// DriverName الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string DriverName { get; private set; }

    /// <summary>
    /// CarNumber of the GoodsReceiptIncomingMaster
    /// CarNumber الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string CarNumber { get; private set; }

    /// <summary>
    /// IncomeDescription of the GoodsReceiptIncomingMaster
    /// IncomeDescription الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string IncomeDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GoodsReceiptIncomingMaster
    /// ReferenceNumber الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// Field1 of the GoodsReceiptIncomingMaster
    /// Field1 الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the GoodsReceiptIncomingMaster
    /// Field2 الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the GoodsReceiptIncomingMaster
    /// Field3 الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the GoodsReceiptIncomingMaster
    /// ProcessedFlagFull الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GoodsReceiptIncomingMaster
    /// ExternalPostFlag الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the GoodsReceiptIncomingMaster
    /// InactiveFlag الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the GoodsReceiptIncomingMaster
    /// InactivatedByUserId الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the GoodsReceiptIncomingMaster
    /// InactiveDate الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the GoodsReceiptIncomingMaster
    /// InactiveReason الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ApprovedFlag of the GoodsReceiptIncomingMaster
    /// ApprovedFlag الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the GoodsReceiptIncomingMaster
    /// ApprovalUserId الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the GoodsReceiptIncomingMaster
    /// ApprovalDate الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the GoodsReceiptIncomingMaster
    /// ApprovalDescription الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GoodsReceiptIncomingMaster
    /// CompanyNumberShort الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GoodsReceiptIncomingMaster
    /// BranchNumber الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GoodsReceiptIncomingMaster
    /// BranchYear الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GoodsReceiptIncomingMaster
    /// BranchUser الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// MrpMtType of the GoodsReceiptIncomingMaster
    /// MrpMtType الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string MrpMtType { get; private set; }

    /// <summary>
    /// MrpMtOrder of the GoodsReceiptIncomingMaster
    /// MrpMtOrder الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public string MrpMtOrder { get; private set; }

    /// <summary>
    /// MrpMtSequence of the GoodsReceiptIncomingMaster
    /// MrpMtSequence الخاص بـ GoodsReceiptIncomingMaster
    /// </summary>
    public decimal? MrpMtSequence { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public IncomeType IncomeType { get; private set; }
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
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

