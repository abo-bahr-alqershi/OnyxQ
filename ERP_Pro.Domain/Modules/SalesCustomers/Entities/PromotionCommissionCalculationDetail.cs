using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionCommissionCalculationDetail Entity
/// </summary>
public class PromotionCommissionCalculationDetail : Entity<PromotionCommissionCalculationDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<PromotionCommissionCalculationMaster> _promotionCommissionCalculationMaster = new List<PromotionCommissionCalculationMaster>();

    private PromotionCommissionCalculationDetail() { }

    public PromotionCommissionCalculationDetail(PromotionCommissionCalculationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PromotionCommissionCalculationDetail
    /// المعرف الفريد لـ PromotionCommissionCalculationDetail
    /// </summary>
    public PromotionCommissionCalculationDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the PromotionCommissionCalculationDetail
    /// DocNo الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// PromoterCode of the PromotionCommissionCalculationDetail
    /// PromoterCode الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// ItemUnit of the PromotionCommissionCalculationDetail
    /// ItemUnit الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the PromotionCommissionCalculationDetail
    /// PSize الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// CommissionAmount of the PromotionCommissionCalculationDetail
    /// CommissionAmount الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the PromotionCommissionCalculationDetail
    /// CommissionDescriptionShort الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    /// <summary>
    /// CommissionPercent of the PromotionCommissionCalculationDetail
    /// CommissionPercent الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// NetSalesAmount of the PromotionCommissionCalculationDetail
    /// NetSalesAmount الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the PromotionCommissionCalculationDetail
    /// RecordNumber الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the PromotionCommissionCalculationDetail
    /// GuarantorCode الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the PromotionCommissionCalculationDetail
    /// ItemType الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// CGroupCode of the PromotionCommissionCalculationDetail
    /// CGroupCode الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the PromotionCommissionCalculationDetail
    /// CClass الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// BillDocumentType of the PromotionCommissionCalculationDetail
    /// BillDocumentType الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PromotionCommissionCalculationDetail
    /// CompanyNumberShort الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PromotionCommissionCalculationDetail
    /// BranchNumber الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PromotionCommissionCalculationDetail
    /// BranchYear الخاص بـ PromotionCommissionCalculationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PromotionCommissionCalculationDetail
    /// BranchUser الخاص بـ PromotionCommissionCalculationDetail
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
    public ICollection<PromotionCommissionCalculationMaster> PromotionCommissionCalculationMaster => _promotionCommissionCalculationMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
