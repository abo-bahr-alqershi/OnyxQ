using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionCommissionSetupMaster Entity
/// </summary>
public class PromotionCommissionSetupMaster : Entity<PromotionCommissionSetupMasterId>
{
    private PromotionCommissionSetupMaster() { }

    /// <summary>
    /// The unique identifier for the PromotionCommissionSetupMaster
    /// المعرف الفريد لـ PromotionCommissionSetupMaster
    /// </summary>
    public PromotionCommissionSetupMasterId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the PromotionCommissionSetupMaster
    /// CommissionTypeShort الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// CommissionTypeLastName of the PromotionCommissionSetupMaster
    /// CommissionTypeLastName الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public string CommissionTypeLastName { get; private set; }

    /// <summary>
    /// CommissionTypeFirstName of the PromotionCommissionSetupMaster
    /// CommissionTypeFirstName الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public string CommissionTypeFirstName { get; private set; }

    /// <summary>
    /// PromoterCommissionType of the PromotionCommissionSetupMaster
    /// PromoterCommissionType الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? PromoterCommissionType { get; private set; }

    /// <summary>
    /// CalculateCommissionItemType of the PromotionCommissionSetupMaster
    /// CalculateCommissionItemType الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? CalculateCommissionItemType { get; private set; }

    /// <summary>
    /// CommissionSlicesType of the PromotionCommissionSetupMaster
    /// CommissionSlicesType الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? CommissionSlicesType { get; private set; }

    /// <summary>
    /// UseCalculateCommissionPayType of the PromotionCommissionSetupMaster
    /// UseCalculateCommissionPayType الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? UseCalculateCommissionPayType { get; private set; }

    /// <summary>
    /// SeparateTargetAddTargetShort of the PromotionCommissionSetupMaster
    /// SeparateTargetAddTargetShort الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? SeparateTargetAddTargetShort { get; private set; }

    /// <summary>
    /// CommissionCalcTargetMethodShort of the PromotionCommissionSetupMaster
    /// CommissionCalcTargetMethodShort الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionCalcAdditionalTargetMethodShort of the PromotionCommissionSetupMaster
    /// CommissionCalcAdditionalTargetMethodShort الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcAdditionalTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the PromotionCommissionSetupMaster
    /// CommissionAmountTypeShort الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the PromotionCommissionSetupMaster
    /// CommissionAmount الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// CommissionAmountQuantity of the PromotionCommissionSetupMaster
    /// CommissionAmountQuantity الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountQuantity { get; private set; }

    /// <summary>
    /// PromoterCustomerCommissionType of the PromotionCommissionSetupMaster
    /// PromoterCustomerCommissionType الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? PromoterCustomerCommissionType { get; private set; }

    /// <summary>
    /// InactiveFlag of the PromotionCommissionSetupMaster
    /// InactiveFlag الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the PromotionCommissionSetupMaster
    /// InactiveReason الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the PromotionCommissionSetupMaster
    /// InactiveDate الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the PromotionCommissionSetupMaster
    /// InactivatedByUserId الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the PromotionCommissionSetupMaster
    /// CommissionDescriptionShort الخاص بـ PromotionCommissionSetupMaster
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: PromotionCommissionSetupMaster to PromotionCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<PromotionCommissionSetupDetail> PromotionCommissionSetupDetails { get; private set; }
    #endregion
}
}
