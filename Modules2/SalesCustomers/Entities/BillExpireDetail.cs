using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillExpireDetail Entity
/// </summary>
public class BillExpireDetail : Entity<BillExpireDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<BillExpireMaster> _billExpireMaster = new List<BillExpireMaster>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private BillExpireDetail() { }

    public BillExpireDetail(BillExpireDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BillExpireDetail
    /// المعرف الفريد لـ BillExpireDetail
    /// </summary>
    public BillExpireDetailId Id { get; private set; }

    /// <summary>
    /// BillNumber of the BillExpireDetail
    /// BillNumber الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// PSize of the BillExpireDetail
    /// PSize الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemNameFull of the BillExpireDetail
    /// ItemNameFull الخاص بـ BillExpireDetail
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemQuantity of the BillExpireDetail
    /// ItemQuantity الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the BillExpireDetail
    /// PQuantity الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BillExpireDetail
    /// ItemPriceShort الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// RecordNumber of the BillExpireDetail
    /// RecordNumber الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillExpireDetail
    /// CompanyNumberShort الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillExpireDetail
    /// BranchNumber الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BillExpireDetail
    /// BranchYear الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BillExpireDetail
    /// BranchUser الخاص بـ BillExpireDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// VendorCode of the BillExpireDetail
    /// VendorCode الخاص بـ BillExpireDetail
    /// </summary>
    public string VendorCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<BillExpireMaster> BillExpireMaster => _billExpireMaster;
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

