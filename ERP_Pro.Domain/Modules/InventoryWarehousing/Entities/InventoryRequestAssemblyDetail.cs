using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryRequestAssemblyDetail Entity
/// </summary>
public class InventoryRequestAssemblyDetail : Entity<InventoryRequestAssemblyDetailId>
{

    private InventoryRequestAssemblyDetail() { }

    public InventoryRequestAssemblyDetail(InventoryRequestAssemblyDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InventoryRequestAssemblyDetail
    /// المعرف الفريد لـ InventoryRequestAssemblyDetail
    /// </summary>
    public InventoryRequestAssemblyDetailId Id { get; private set; }

    /// <summary>
    /// TypeNumberShort of the InventoryRequestAssemblyDetail
    /// TypeNumberShort الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// DocNo of the InventoryRequestAssemblyDetail
    /// DocNo الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the InventoryRequestAssemblyDetail
    /// ItemCode الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the InventoryRequestAssemblyDetail
    /// ItemUnit الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemQuantity of the InventoryRequestAssemblyDetail
    /// ItemQuantity الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the InventoryRequestAssemblyDetail
    /// PSize الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the InventoryRequestAssemblyDetail
    /// PQuantity الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the InventoryRequestAssemblyDetail
    /// WarehouseCode الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the InventoryRequestAssemblyDetail
    /// CostCenterCode الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the InventoryRequestAssemblyDetail
    /// ProjectNumber الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the InventoryRequestAssemblyDetail
    /// ActivityNumber الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the InventoryRequestAssemblyDetail
    /// ExpireDate الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the InventoryRequestAssemblyDetail
    /// BatchNumber الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the InventoryRequestAssemblyDetail
    /// ItemDescription الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryRequestAssemblyDetail
    /// RecordNumber الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the InventoryRequestAssemblyDetail
    /// UseAttachment الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the InventoryRequestAssemblyDetail
    /// ReceiveAttachment الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemLength of the InventoryRequestAssemblyDetail
    /// ItemLength الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the InventoryRequestAssemblyDetail
    /// ItemWidth الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the InventoryRequestAssemblyDetail
    /// ItemHeightShort الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the InventoryRequestAssemblyDetail
    /// ItemNumberShort الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the InventoryRequestAssemblyDetail
    /// WeightedQuantity الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the InventoryRequestAssemblyDetail
    /// WeightedUnit الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// Barcode of the InventoryRequestAssemblyDetail
    /// Barcode الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ArgumentNumber of the InventoryRequestAssemblyDetail
    /// ArgumentNumber الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InventoryRequestAssemblyDetail
    /// ExternalPostFlag الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryRequestAssemblyDetail
    /// CompanyNumberShort الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryRequestAssemblyDetail
    /// BranchNumber الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryRequestAssemblyDetail
    /// BranchYear الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryRequestAssemblyDetail
    /// BranchUser الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocTypeRef of the InventoryRequestAssemblyDetail
    /// DocTypeRef الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the InventoryRequestAssemblyDetail
    /// DocNoRef الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the InventoryRequestAssemblyDetail
    /// DocSerRef الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// AvailableQuantity of the InventoryRequestAssemblyDetail
    /// AvailableQuantity الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// DocSequence of the InventoryRequestAssemblyDetail
    /// DocSequence الخاص بـ InventoryRequestAssemblyDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InventoryRequestAssemblyMaster InventoryRequestAssemblyMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
