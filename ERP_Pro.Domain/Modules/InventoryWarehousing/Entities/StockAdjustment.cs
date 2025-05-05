using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// StockAdjustment Entity
/// </summary>
public class StockAdjustment : AggregateRoot<StockAdjustmentId>
{

    private StockAdjustment() { }

    public StockAdjustment(StockAdjustmentId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the StockAdjustment
    /// المعرف الفريد لـ StockAdjustment
    /// </summary>
    public StockAdjustmentId Id { get; private set; }

    /// <summary>
    /// AdjustmentType of the StockAdjustment
    /// AdjustmentType الخاص بـ StockAdjustment
    /// </summary>
    public decimal? AdjustmentType { get; private set; }

    /// <summary>
    /// DocNo of the StockAdjustment
    /// DocNo الخاص بـ StockAdjustment
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the StockAdjustment
    /// DocSer الخاص بـ StockAdjustment
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the StockAdjustment
    /// DocDate الخاص بـ StockAdjustment
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the StockAdjustment
    /// ReferenceNumber الخاص بـ StockAdjustment
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// StockDescription of the StockAdjustment
    /// StockDescription الخاص بـ StockAdjustment
    /// </summary>
    public string StockDescription { get; private set; }

    /// <summary>
    /// VendorCode of the StockAdjustment
    /// VendorCode الخاص بـ StockAdjustment
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// StockAccountRate of the StockAdjustment
    /// StockAccountRate الخاص بـ StockAdjustment
    /// </summary>
    public decimal? StockAccountRate { get; private set; }

    /// <summary>
    /// ProjectNumber of the StockAdjustment
    /// ProjectNumber الخاص بـ StockAdjustment
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// StockPostFlag of the StockAdjustment
    /// StockPostFlag الخاص بـ StockAdjustment
    /// </summary>
    public decimal? StockPostFlag { get; private set; }

    /// <summary>
    /// HungFlag of the StockAdjustment
    /// HungFlag الخاص بـ StockAdjustment
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// FillType of the StockAdjustment
    /// FillType الخاص بـ StockAdjustment
    /// </summary>
    public decimal? FillType { get; private set; }

    /// <summary>
    /// DocBrnNo of the StockAdjustment
    /// DocBrnNo الخاص بـ StockAdjustment
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// AuditReference of the StockAdjustment
    /// AuditReference الخاص بـ StockAdjustment
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the StockAdjustment
    /// AuditReferenceDescription الخاص بـ StockAdjustment
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the StockAdjustment
    /// AuditReferenceUserId الخاص بـ StockAdjustment
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the StockAdjustment
    /// AuditReferenceDate الخاص بـ StockAdjustment
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// PostUserId of the StockAdjustment
    /// PostUserId الخاص بـ StockAdjustment
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the StockAdjustment
    /// PostDate الخاص بـ StockAdjustment
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the StockAdjustment
    /// UnpostUserId الخاص بـ StockAdjustment
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the StockAdjustment
    /// UnpostDate الخاص بـ StockAdjustment
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StockAdjustment
    /// CompanyNumberShort الخاص بـ StockAdjustment
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StockAdjustment
    /// BranchNumber الخاص بـ StockAdjustment
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StockAdjustment
    /// BranchYear الخاص بـ StockAdjustment
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StockAdjustment
    /// BranchUser الخاص بـ StockAdjustment
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailCode of the StockAdjustment
    /// AccountDetailCode الخاص بـ StockAdjustment
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the StockAdjustment
    /// AccountDetailType الخاص بـ StockAdjustment
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public StockAdjustmentType StockAdjustmentType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

