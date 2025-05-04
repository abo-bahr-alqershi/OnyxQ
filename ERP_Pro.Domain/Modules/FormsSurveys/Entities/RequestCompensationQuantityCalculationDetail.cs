using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// RequestCompensationQuantityCalculationDetail Entity
/// </summary>
public class RequestCompensationQuantityCalculationDetail : Entity<RequestCompensationQuantityCalculationDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<RequestCompensationQuantityCalculationMaster> _requestCompensationQuantityCalculationMaster = new List<RequestCompensationQuantityCalculationMaster>();

    private RequestCompensationQuantityCalculationDetail() { }

    public RequestCompensationQuantityCalculationDetail(RequestCompensationQuantityCalculationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the RequestCompensationQuantityCalculationDetail
    /// المعرف الفريد لـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public RequestCompensationQuantityCalculationDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the RequestCompensationQuantityCalculationDetail
    /// DocNo الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemUnit of the RequestCompensationQuantityCalculationDetail
    /// ItemUnit الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the RequestCompensationQuantityCalculationDetail
    /// PSize الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemType of the RequestCompensationQuantityCalculationDetail
    /// ItemType الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// ActivityNumber of the RequestCompensationQuantityCalculationDetail
    /// ActivityNumber الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the RequestCompensationQuantityCalculationDetail
    /// CostCenterCode الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the RequestCompensationQuantityCalculationDetail
    /// ActivityNumber الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the RequestCompensationQuantityCalculationDetail
    /// ProjectNumber الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestCompensationQuantityCalculationDetail
    /// BranchNumber الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the RequestCompensationQuantityCalculationDetail
    /// WarehouseCode الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CompensationQuantity of the RequestCompensationQuantityCalculationDetail
    /// CompensationQuantity الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? CompensationQuantity { get; private set; }

    /// <summary>
    /// CompensationDescription of the RequestCompensationQuantityCalculationDetail
    /// CompensationDescription الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public string CompensationDescription { get; private set; }

    /// <summary>
    /// CompensationPercent of the RequestCompensationQuantityCalculationDetail
    /// CompensationPercent الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? CompensationPercent { get; private set; }

    /// <summary>
    /// NetSalesAmount of the RequestCompensationQuantityCalculationDetail
    /// NetSalesAmount الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// NetSalesQuantity of the RequestCompensationQuantityCalculationDetail
    /// NetSalesQuantity الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? NetSalesQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the RequestCompensationQuantityCalculationDetail
    /// RecordNumber الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSeq of the RequestCompensationQuantityCalculationDetail
    /// DocSeq الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// GuarantorCode of the RequestCompensationQuantityCalculationDetail
    /// GuarantorCode الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// BillNumber of the RequestCompensationQuantityCalculationDetail
    /// BillNumber الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the RequestCompensationQuantityCalculationDetail
    /// BillSerial الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ColumnAmount of the RequestCompensationQuantityCalculationDetail
    /// ColumnAmount الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? ColumnAmount { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the RequestCompensationQuantityCalculationDetail
    /// BillDocumentTypeFull الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// PrivilegeQuantity of the RequestCompensationQuantityCalculationDetail
    /// PrivilegeQuantity الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? PrivilegeQuantity { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestCompensationQuantityCalculationDetail
    /// CompanyNumberShort الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchYear of the RequestCompensationQuantityCalculationDetail
    /// BranchYear الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestCompensationQuantityCalculationDetail
    /// BranchUser الخاص بـ RequestCompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<RequestCompensationQuantityCalculationMaster> RequestCompensationQuantityCalculationMaster => _requestCompensationQuantityCalculationMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
