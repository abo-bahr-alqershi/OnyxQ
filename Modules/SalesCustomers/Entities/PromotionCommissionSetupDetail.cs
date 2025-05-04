using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionCommissionSetupDetail Entity
/// </summary>
public class PromotionCommissionSetupDetail : Entity<PromotionCommissionSetupDetailId>
{
    private PromotionCommissionSetupDetail() { }

    /// <summary>
    /// The unique identifier for the PromotionCommissionSetupDetail
    /// المعرف الفريد لـ PromotionCommissionSetupDetail
    /// </summary>
    public PromotionCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the PromotionCommissionSetupDetail
    /// CommissionTypeShort الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// PromoterCode of the PromotionCommissionSetupDetail
    /// PromoterCode الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// CClass of the PromotionCommissionSetupDetail
    /// CClass الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// ItemCode of the PromotionCommissionSetupDetail
    /// ItemCode الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the PromotionCommissionSetupDetail
    /// ItemUnit الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// GuarantorCode of the PromotionCommissionSetupDetail
    /// GuarantorCode الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the PromotionCommissionSetupDetail
    /// ItemType الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

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
    /// CGroupCode of the PromotionCommissionSetupDetail
    /// CGroupCode الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// BillDocumentType of the PromotionCommissionSetupDetail
    /// BillDocumentType الخاص بـ PromotionCommissionSetupDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to PromotionCommissionSetupMaster
    /// </summary>
    public PromotionCommissionSetupMaster PromotionCommissionSetupMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Promoter
    /// </summary>
    public Promoter Promoter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerClass
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerGroup
    /// </summary>
    public CustomerGroup CustomerGroup { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemType
    /// </summary>
    public ItemType ItemType { get; private set; }
    #endregion
}
}
