using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// AssembleKitItem Entity
/// </summary>
public class AssembleKitItem : Entity<AssembleKitItemId>
{
    private AssembleKitItem() { }

    /// <summary>
    /// The unique identifier for the AssembleKitItem
    /// المعرف الفريد لـ AssembleKitItem
    /// </summary>
    public AssembleKitItemId Id { get; private set; }

    /// <summary>
    /// DocNo of the AssembleKitItem
    /// DocNo الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AssembleKitItem
    /// DocSer الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AssembleKitItem
    /// DocDate الخاص بـ AssembleKitItem
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FromWarehouse of the AssembleKitItem
    /// FromWarehouse الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? FromWarehouse { get; private set; }

    /// <summary>
    /// ToWarehouse of the AssembleKitItem
    /// ToWarehouse الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? ToWarehouse { get; private set; }

    /// <summary>
    /// ExpenseAmountType of the AssembleKitItem
    /// ExpenseAmountType الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? ExpenseAmountType { get; private set; }

    /// <summary>
    /// CostCenterCode of the AssembleKitItem
    /// CostCenterCode الخاص بـ AssembleKitItem
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AssembleKitItem
    /// ProjectNumber الخاص بـ AssembleKitItem
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AssembleKitItem
    /// ActivityNumber الخاص بـ AssembleKitItem
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// StockRate of the AssembleKitItem
    /// StockRate الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// DocDesc of the AssembleKitItem
    /// DocDesc الخاص بـ AssembleKitItem
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AssembleKitItem
    /// ReferenceNumber الخاص بـ AssembleKitItem
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ExpenseAmount of the AssembleKitItem
    /// ExpenseAmount الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AssembleKitItem
    /// ProcessedFlagFull الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// HungFlag of the AssembleKitItem
    /// HungFlag الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// DocPost of the AssembleKitItem
    /// DocPost الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// EmpNo of the AssembleKitItem
    /// EmpNo الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// PostUserId of the AssembleKitItem
    /// PostUserId الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the AssembleKitItem
    /// PostDate الخاص بـ AssembleKitItem
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the AssembleKitItem
    /// UnpostUserId الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the AssembleKitItem
    /// UnpostDate الخاص بـ AssembleKitItem
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// AuditReference of the AssembleKitItem
    /// AuditReference الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the AssembleKitItem
    /// AuditReferenceDescription الخاص بـ AssembleKitItem
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the AssembleKitItem
    /// AuditReferenceUserId الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the AssembleKitItem
    /// AuditReferenceDate الخاص بـ AssembleKitItem
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AssembleKitItem
    /// CompanyNumberShort الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AssembleKitItem
    /// BranchNumber الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AssembleKitItem
    /// BranchYear الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AssembleKitItem
    /// BranchUser الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// TypeNumberShort of the AssembleKitItem
    /// TypeNumberShort الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// PeriodDocument of the AssembleKitItem
    /// PeriodDocument الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? PeriodDocument { get; private set; }

    /// <summary>
    /// DocSequenceM of the AssembleKitItem
    /// DocSequenceM الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? DocSequenceM { get; private set; }

    /// <summary>
    /// AdditionalExpenseType of the AssembleKitItem
    /// AdditionalExpenseType الخاص بـ AssembleKitItem
    /// </summary>
    public decimal? AdditionalExpenseType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// One-to-many relationship: AssembleKitItem to AssembleKitItemDetail
    /// </summary>
    public IReadOnlyCollection<AssembleKitItemDetail> AssembleKitItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AssembleKitItem to AssembleItemExpand
    /// </summary>
    public IReadOnlyCollection<AssembleItemExpand> AssembleItemExpands { get; private set; }
    #endregion
}
}
