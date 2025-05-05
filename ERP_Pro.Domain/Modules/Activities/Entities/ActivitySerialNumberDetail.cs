using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.Activities.ValueObjects;
namespace ERP_Pro.Domain.ERP.Activities.Entities
{
/// <summary>
/// ActivitySerialNumberDetail Entity
/// </summary>
public class ActivitySerialNumberDetail : Entity<ActivitySerialNumberDetailId>
{
    private readonly List<ActivitySerialNumberMaster> _activitySerialNumberMaster = new List<ActivitySerialNumberMaster>();
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private ActivitySerialNumberDetail() { }

    public ActivitySerialNumberDetail(ActivitySerialNumberDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ActivitySerialNumberDetail
    /// المعرف الفريد لـ ActivitySerialNumberDetail
    /// </summary>
    public ActivitySerialNumberDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the ActivitySerialNumberDetail
    /// DocNo الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemUnit of the ActivitySerialNumberDetail
    /// ItemUnit الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ActivitySerialNumberDetail
    /// PSize الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// SerialNumber of the ActivitySerialNumberDetail
    /// SerialNumber الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public string SerialNumber { get; private set; }

    /// <summary>
    /// ActiveFlag of the ActivitySerialNumberDetail
    /// ActiveFlag الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? ActiveFlag { get; private set; }

    /// <summary>
    /// DocTypeRef of the ActivitySerialNumberDetail
    /// DocTypeRef الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ActivitySerialNumberDetail
    /// DocNoRef الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the ActivitySerialNumberDetail
    /// DocSerRef الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ActivitySerialNumberDetail
    /// ItemPriceShort الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// CCode of the ActivitySerialNumberDetail
    /// CCode الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the ActivitySerialNumberDetail
    /// CName الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ActivitySerialNumberDetail
    /// CompanyNumberShort الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ActivitySerialNumberDetail
    /// BranchNumber الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ActivitySerialNumberDetail
    /// BranchYear الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ActivitySerialNumberDetail
    /// BranchUser الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ActivitySerialNumberMaster> ActivitySerialNumberMaster => _activitySerialNumberMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
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

