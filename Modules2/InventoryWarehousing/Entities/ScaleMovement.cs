using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.TransportationShipping.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ScaleMovement Entity
/// </summary>
public class ScaleMovement : Entity<ScaleMovementId>
{

    private ScaleMovement() { }

    public ScaleMovement(ScaleMovementId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the ScaleMovement
    /// المعرف الفريد لـ ScaleMovement
    /// </summary>
    public ScaleMovementId Id { get; private set; }

    /// <summary>
    /// DocNo of the ScaleMovement
    /// DocNo الخاص بـ ScaleMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the ScaleMovement
    /// DocSrl الخاص بـ ScaleMovement
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocDate of the ScaleMovement
    /// DocDate الخاص بـ ScaleMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// TransactionTypeShort of the ScaleMovement
    /// TransactionTypeShort الخاص بـ ScaleMovement
    /// </summary>
    public decimal? TransactionTypeShort { get; private set; }

    /// <summary>
    /// DocTyp of the ScaleMovement
    /// DocTyp الخاص بـ ScaleMovement
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// DocTypeRef of the ScaleMovement
    /// DocTypeRef الخاص بـ ScaleMovement
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ScaleMovement
    /// DocNoRef الخاص بـ ScaleMovement
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the ScaleMovement
    /// DocSrlRef الخاص بـ ScaleMovement
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// BranchNumber of the ScaleMovement
    /// BranchNumber الخاص بـ ScaleMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CarNumber of the ScaleMovement
    /// CarNumber الخاص بـ ScaleMovement
    /// </summary>
    public string CarNumber { get; private set; }

    /// <summary>
    /// TareWeight of the ScaleMovement
    /// TareWeight الخاص بـ ScaleMovement
    /// </summary>
    public decimal? TareWeight { get; private set; }

    /// <summary>
    /// TareWeightDate of the ScaleMovement
    /// TareWeightDate الخاص بـ ScaleMovement
    /// </summary>
    public DateTime? TareWeightDate { get; private set; }

    /// <summary>
    /// GrossWeight of the ScaleMovement
    /// GrossWeight الخاص بـ ScaleMovement
    /// </summary>
    public decimal? GrossWeight { get; private set; }

    /// <summary>
    /// GrossWeightDate of the ScaleMovement
    /// GrossWeightDate الخاص بـ ScaleMovement
    /// </summary>
    public DateTime? GrossWeightDate { get; private set; }

    /// <summary>
    /// NetWeight of the ScaleMovement
    /// NetWeight الخاص بـ ScaleMovement
    /// </summary>
    public decimal? NetWeight { get; private set; }

    /// <summary>
    /// ItemUnit of the ScaleMovement
    /// ItemUnit الخاص بـ ScaleMovement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemQuantity of the ScaleMovement
    /// ItemQuantity الخاص بـ ScaleMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ScaleMovement
    /// CompanyNumberShort الخاص بـ ScaleMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchYear of the ScaleMovement
    /// BranchYear الخاص بـ ScaleMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ScaleMovement
    /// BranchUser الخاص بـ ScaleMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ProcessFlag of the ScaleMovement
    /// ProcessFlag الخاص بـ ScaleMovement
    /// </summary>
    public decimal? ProcessFlag { get; private set; }

    /// <summary>
    /// UnitWeight of the ScaleMovement
    /// UnitWeight الخاص بـ ScaleMovement
    /// </summary>
    public decimal? UnitWeight { get; private set; }

    /// <summary>
    /// WeightQuantity of the ScaleMovement
    /// WeightQuantity الخاص بـ ScaleMovement
    /// </summary>
    public decimal? WeightQuantity { get; private set; }

    /// <summary>
    /// AccountDescription of the ScaleMovement
    /// AccountDescription الخاص بـ ScaleMovement
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReferenceDocumentNumber of the ScaleMovement
    /// ReferenceDocumentNumber الخاص بـ ScaleMovement
    /// </summary>
    public string ReferenceDocumentNumber { get; private set; }

    /// <summary>
    /// DocDateRef of the ScaleMovement
    /// DocDateRef الخاص بـ ScaleMovement
    /// </summary>
    public DateTime? DocDateRef { get; private set; }

    /// <summary>
    /// ApprovedFlag of the ScaleMovement
    /// ApprovedFlag الخاص بـ ScaleMovement
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDescription of the ScaleMovement
    /// ApprovalDescription الخاص بـ ScaleMovement
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ApprovalUserId of the ScaleMovement
    /// ApprovalUserId الخاص بـ ScaleMovement
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the ScaleMovement
    /// ApprovalDate الخاص بـ ScaleMovement
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// DrvrNm of the ScaleMovement
    /// DrvrNm الخاص بـ ScaleMovement
    /// </summary>
    public string DrvrNm { get; private set; }

    /// <summary>
    /// DiffAcutlWghtQty of the ScaleMovement
    /// DiffAcutlWghtQty الخاص بـ ScaleMovement
    /// </summary>
    public decimal? DiffAcutlWghtQty { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User UserTareWghtUId { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Driver Driver { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

