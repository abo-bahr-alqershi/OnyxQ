using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.Activities.Entities
{
/// <summary>
/// ActivitySerialNumberDetail Entity
/// </summary>
public class ActivitySerialNumberDetail : Entity<ActivitySerialNumberDetailId>
{
    private ActivitySerialNumberDetail() { }

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
    /// DocSer of the ActivitySerialNumberDetail
    /// DocSer الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ItemCode of the ActivitySerialNumberDetail
    /// ItemCode الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public string ItemCode { get; private set; }

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
    /// WarehouseCode of the ActivitySerialNumberDetail
    /// WarehouseCode الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the ActivitySerialNumberDetail
    /// CostCenterCode الخاص بـ ActivitySerialNumberDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

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
    /// ManyToOne relationship to ActivitySerialNumberMaster
    /// </summary>
    public ActivitySerialNumberMaster ActivitySerialNumberMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
