using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// CheckDocumentInOutQuantityDetail Entity
/// </summary>
public class CheckDocumentInOutQuantityDetail : Entity<CheckDocumentInOutQuantityDetailId>
{

    private CheckDocumentInOutQuantityDetail() { }

    public CheckDocumentInOutQuantityDetail(CheckDocumentInOutQuantityDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CheckDocumentInOutQuantityDetail
    /// المعرف الفريد لـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public CheckDocumentInOutQuantityDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the CheckDocumentInOutQuantityDetail
    /// DocNo الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the CheckDocumentInOutQuantityDetail
    /// ItemCode الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the CheckDocumentInOutQuantityDetail
    /// ItemUnit الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the CheckDocumentInOutQuantityDetail
    /// PSize الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the CheckDocumentInOutQuantityDetail
    /// PQuantity الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the CheckDocumentInOutQuantityDetail
    /// WarehouseCode الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ExpireDate of the CheckDocumentInOutQuantityDetail
    /// ExpireDate الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the CheckDocumentInOutQuantityDetail
    /// BatchNumber الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the CheckDocumentInOutQuantityDetail
    /// ItemQuantity الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the CheckDocumentInOutQuantityDetail
    /// RecordNumber الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Barcode of the CheckDocumentInOutQuantityDetail
    /// Barcode الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// DocTypeRef of the CheckDocumentInOutQuantityDetail
    /// DocTypeRef الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the CheckDocumentInOutQuantityDetail
    /// DocJvTypeRef الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the CheckDocumentInOutQuantityDetail
    /// DocNoRef الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the CheckDocumentInOutQuantityDetail
    /// DocSerRef الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the CheckDocumentInOutQuantityDetail
    /// ExternalPostFlag الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CheckDocumentInOutQuantityDetail
    /// CompanyNumberShort الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CheckDocumentInOutQuantityDetail
    /// BranchNumber الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CheckDocumentInOutQuantityDetail
    /// BranchYear الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CheckDocumentInOutQuantityDetail
    /// BranchUser الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// RecordNumberReference of the CheckDocumentInOutQuantityDetail
    /// RecordNumberReference الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// DocSeq of the CheckDocumentInOutQuantityDetail
    /// DocSeq الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// KitItemNumber of the CheckDocumentInOutQuantityDetail
    /// KitItemNumber الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public string KitItemNumber { get; private set; }

    /// <summary>
    /// KitItem of the CheckDocumentInOutQuantityDetail
    /// KitItem الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? KitItem { get; private set; }

    /// <summary>
    /// DmgFlg of the CheckDocumentInOutQuantityDetail
    /// DmgFlg الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DmgFlg { get; private set; }

    /// <summary>
    /// BankCode of the CheckDocumentInOutQuantityDetail
    /// BankCode الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public string BankCode { get; private set; }

    /// <summary>
    /// InOutFlag of the CheckDocumentInOutQuantityDetail
    /// InOutFlag الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// PriceTypeFull of the CheckDocumentInOutQuantityDetail
    /// PriceTypeFull الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? PriceTypeFull { get; private set; }

    /// <summary>
    /// TypeNumberShort of the CheckDocumentInOutQuantityDetail
    /// TypeNumberShort الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// KitItemUnit of the CheckDocumentInOutQuantityDetail
    /// KitItemUnit الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public string KitItemUnit { get; private set; }

    /// <summary>
    /// KitPackageSize of the CheckDocumentInOutQuantityDetail
    /// KitPackageSize الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? KitPackageSize { get; private set; }

    /// <summary>
    /// DocNoPrptnRef of the CheckDocumentInOutQuantityDetail
    /// DocNoPrptnRef الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DocNoPrptnRef { get; private set; }

    /// <summary>
    /// DocSerPrptnRef of the CheckDocumentInOutQuantityDetail
    /// DocSerPrptnRef الخاص بـ CheckDocumentInOutQuantityDetail
    /// </summary>
    public decimal? DocSerPrptnRef { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CheckDocumentInOutQuantityMaster CheckDocumentInOutQuantityMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
