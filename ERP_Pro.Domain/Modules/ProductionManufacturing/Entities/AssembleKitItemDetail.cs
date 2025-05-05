using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// AssembleKitItemDetail Entity
/// </summary>
public class AssembleKitItemDetail : Entity<AssembleKitItemDetailId>
{

    private AssembleKitItemDetail() { }

    public AssembleKitItemDetail(AssembleKitItemDetailId id, string kitItemNumber, string itemUnit, decimal? recordNumber)
    {
        Id = id;
        KitItemNumber = kitItemNumber;
        ItemUnit = itemUnit;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the AssembleKitItemDetail
    /// المعرف الفريد لـ AssembleKitItemDetail
    /// </summary>
    public AssembleKitItemDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AssembleKitItemDetail
    /// DocNo الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// KitItemNumber of the AssembleKitItemDetail
    /// KitItemNumber الخاص بـ AssembleKitItemDetail
    /// </summary>
    public string KitItemNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the AssembleKitItemDetail
    /// ItemUnit الخاص بـ AssembleKitItemDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AssembleKitItemDetail
    /// PSize الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the AssembleKitItemDetail
    /// ItemQuantity الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FWarehouseCode of the AssembleKitItemDetail
    /// FWarehouseCode الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the AssembleKitItemDetail
    /// TWarehouseCode الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AssembleKitItemDetail
    /// CostCenterCode الخاص بـ AssembleKitItemDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// KitCost of the AssembleKitItemDetail
    /// KitCost الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? KitCost { get; private set; }

    /// <summary>
    /// ExpenseAmount of the AssembleKitItemDetail
    /// ExpenseAmount الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the AssembleKitItemDetail
    /// RecordNumber الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the AssembleKitItemDetail
    /// DocSequence الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// PostCode of the AssembleKitItemDetail
    /// PostCode الخاص بـ AssembleKitItemDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// ExpireDate of the AssembleKitItemDetail
    /// ExpireDate الخاص بـ AssembleKitItemDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the AssembleKitItemDetail
    /// BatchNumber الخاص بـ AssembleKitItemDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AssembleKitItemDetail
    /// CompanyNumberShort الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AssembleKitItemDetail
    /// BranchNumber الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AssembleKitItemDetail
    /// BranchYear الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AssembleKitItemDetail
    /// BranchUser الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemPriceShort of the AssembleKitItemDetail
    /// ItemPriceShort الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DocTypeRef of the AssembleKitItemDetail
    /// DocTypeRef الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the AssembleKitItemDetail
    /// DocNoRef الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AssembleKitItemDetail
    /// DocSerRef الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the AssembleKitItemDetail
    /// DocSequenceRef الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// DocSequenceM of the AssembleKitItemDetail
    /// DocSequenceM الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? DocSequenceM { get; private set; }

    /// <summary>
    /// RecordSequence of the AssembleKitItemDetail
    /// RecordSequence الخاص بـ AssembleKitItemDetail
    /// </summary>
    public decimal? RecordSequence { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AssembleKitItem AssembleKitItem { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

