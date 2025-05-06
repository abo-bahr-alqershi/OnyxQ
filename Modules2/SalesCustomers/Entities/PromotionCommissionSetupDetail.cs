using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionCommissionSetupDetail Entity
/// </summary>
public class PromotionCommissionSetupDetail : Entity<PromotionCommissionSetupDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<PromotionCommissionSetupMaster> _promotionCommissionSetupMaster = new List<PromotionCommissionSetupMaster>();
    private readonly List<Promoter> _promoter = new List<Promoter>();
    private readonly List<CustomerClass> _customerClass = new List<CustomerClass>();
    private readonly List<CustomerGroup> _customerGroup = new List<CustomerGroup>();
    private readonly List<GroupDetail> _groupDetail = new List<GroupDetail>();
    private readonly List<ItemType> _itemType = new List<ItemType>();

    private PromotionCommissionSetupDetail() { }

    public PromotionCommissionSetupDetail(PromotionCommissionSetupDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PromotionCommissionSetupDetail
    /// المعرف الفريد لـ PromotionCommissionSetupDetail
    /// </summary>
    public PromotionCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// ItemUnit of the PromotionCommissionSetupDetail
    /// ItemUnit الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// FValue of the PromotionCommissionSetupDetail
    /// FValue الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the PromotionCommissionSetupDetail
    /// TValue الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the PromotionCommissionSetupDetail
    /// CommissionAmountTypeShort الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the PromotionCommissionSetupDetail
    /// CommissionAmount الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SliceDescription of the PromotionCommissionSetupDetail
    /// SliceDescription الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public string SliceDescription { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the PromotionCommissionSetupDetail
    /// CommissionSliceNumber الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    /// <summary>
    /// PSize of the PromotionCommissionSetupDetail
    /// PSize الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// BillDocumentType of the PromotionCommissionSetupDetail
    /// BillDocumentType الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<PromotionCommissionSetupMaster> PromotionCommissionSetupMaster => _promotionCommissionSetupMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Promoter> Promoter => _promoter;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerClass> CustomerClass => _customerClass;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerGroup> CustomerGroup => _customerGroup;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<GroupDetail> GroupDetail => _groupDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemType> ItemType => _itemType;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

