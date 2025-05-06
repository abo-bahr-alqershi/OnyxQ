using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ReservationDetail Entity
/// </summary>
public class ReservationDetail : Entity<ReservationDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<ReservationMaster> _reservationMaster = new List<ReservationMaster>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private ReservationDetail() { }

    public ReservationDetail(ReservationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ReservationDetail
    /// المعرف الفريد لـ ReservationDetail
    /// </summary>
    public ReservationDetailId Id { get; private set; }

    /// <summary>
    /// DocType of the ReservationDetail
    /// DocType الخاص بـ ReservationDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocNo of the ReservationDetail
    /// DocNo الخاص بـ ReservationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocNoRef of the ReservationDetail
    /// DocNoRef الخاص بـ ReservationDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocTypeRef of the ReservationDetail
    /// DocTypeRef الخاص بـ ReservationDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocSerRef of the ReservationDetail
    /// DocSerRef الخاص بـ ReservationDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CCode of the ReservationDetail
    /// CCode الخاص بـ ReservationDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the ReservationDetail
    /// CostCenterCode الخاص بـ ReservationDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ReservationDetail
    /// ProjectNumber الخاص بـ ReservationDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ReservationDetail
    /// ActivityNumber الخاص بـ ReservationDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the ReservationDetail
    /// ItemQuantity الخاص بـ ReservationDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the ReservationDetail
    /// PSize الخاص بـ ReservationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the ReservationDetail
    /// PQuantity الخاص بـ ReservationDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// CompanyQuantity of the ReservationDetail
    /// CompanyQuantity الخاص بـ ReservationDetail
    /// </summary>
    public decimal? CompanyQuantity { get; private set; }

    /// <summary>
    /// ReservedFlag of the ReservationDetail
    /// ReservedFlag الخاص بـ ReservationDetail
    /// </summary>
    public decimal? ReservedFlag { get; private set; }

    /// <summary>
    /// TDate of the ReservationDetail
    /// TDate الخاص بـ ReservationDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// DocSequence of the ReservationDetail
    /// DocSequence الخاص بـ ReservationDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// RecordNumber of the ReservationDetail
    /// RecordNumber الخاص بـ ReservationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the ReservationDetail
    /// ItemDescription الخاص بـ ReservationDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// UnblockUserId of the ReservationDetail
    /// UnblockUserId الخاص بـ ReservationDetail
    /// </summary>
    public decimal? UnblockUserId { get; private set; }

    /// <summary>
    /// UnblockDate of the ReservationDetail
    /// UnblockDate الخاص بـ ReservationDetail
    /// </summary>
    public DateTime? UnblockDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ReservationDetail
    /// ExternalPostFlag الخاص بـ ReservationDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ExpireDate of the ReservationDetail
    /// ExpireDate الخاص بـ ReservationDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ReservationDetail
    /// BatchNumber الخاص بـ ReservationDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the ReservationDetail
    /// BranchNumber الخاص بـ ReservationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ReservationDetail
    /// CompanyNumberShort الخاص بـ ReservationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the ReservationDetail
    /// BranchUser الخاص بـ ReservationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the ReservationDetail
    /// BranchYear الخاص بـ ReservationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ReservationMaster> ReservationMaster => _reservationMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

