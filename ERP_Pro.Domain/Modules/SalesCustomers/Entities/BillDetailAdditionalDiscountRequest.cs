using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillDetailAdditionalDiscountRequest Entity
/// </summary>
public class BillDetailAdditionalDiscountRequest : Entity<BillDetailAdditionalDiscountRequestId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<BillMasterAdditionalDiscountRequest> _billMasterAdditionalDiscountRequest = new List<BillMasterAdditionalDiscountRequest>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private BillDetailAdditionalDiscountRequest() { }

    public BillDetailAdditionalDiscountRequest(BillDetailAdditionalDiscountRequestId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BillDetailAdditionalDiscountRequest
    /// المعرف الفريد لـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public BillDetailAdditionalDiscountRequestId Id { get; private set; }

    /// <summary>
    /// DocNo of the BillDetailAdditionalDiscountRequest
    /// DocNo الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// BillNumber of the BillDetailAdditionalDiscountRequest
    /// BillNumber الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BillDetailAdditionalDiscountRequest
    /// BillSerial الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemUnit of the BillDetailAdditionalDiscountRequest
    /// ItemUnit الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BillDetailAdditionalDiscountRequest
    /// PSize الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// NetQuantity of the BillDetailAdditionalDiscountRequest
    /// NetQuantity الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? NetQuantity { get; private set; }

    /// <summary>
    /// AdditionalDiscountPercent of the BillDetailAdditionalDiscountRequest
    /// AdditionalDiscountPercent الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalDiscountPercent { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the BillDetailAdditionalDiscountRequest
    /// AdditionalDiscountAmountDetailShort الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailPrevious of the BillDetailAdditionalDiscountRequest
    /// AdditionalDiscountAmountDetailPrevious الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailPrevious { get; private set; }

    /// <summary>
    /// AdditionalDiscountQuantity of the BillDetailAdditionalDiscountRequest
    /// AdditionalDiscountQuantity الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalDiscountQuantity { get; private set; }

    /// <summary>
    /// ReturnAmount of the BillDetailAdditionalDiscountRequest
    /// ReturnAmount الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? ReturnAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the BillDetailAdditionalDiscountRequest
    /// RecordNumber الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BillDetailAdditionalDiscountRequest
    /// DocSequence الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BillDetailAdditionalDiscountRequest
    /// ExternalPostFlag الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ItemDescription of the BillDetailAdditionalDiscountRequest
    /// ItemDescription الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// PriceAfterDiscount of the BillDetailAdditionalDiscountRequest
    /// PriceAfterDiscount الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? PriceAfterDiscount { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillDetailAdditionalDiscountRequest
    /// CompanyNumberShort الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillDetailAdditionalDiscountRequest
    /// BranchNumber الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the BillDetailAdditionalDiscountRequest
    /// BranchUser الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the BillDetailAdditionalDiscountRequest
    /// BranchYear الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// DocTypeRef of the BillDetailAdditionalDiscountRequest
    /// DocTypeRef الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BillDetailAdditionalDiscountRequest
    /// DocSerRef الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BillDetailAdditionalDiscountRequest
    /// DocNoRef الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// AdditionalVatAmount of the BillDetailAdditionalDiscountRequest
    /// AdditionalVatAmount الخاص بـ BillDetailAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalVatAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<BillMasterAdditionalDiscountRequest> BillMasterAdditionalDiscountRequest => _billMasterAdditionalDiscountRequest;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
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
