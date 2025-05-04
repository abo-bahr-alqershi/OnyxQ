using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCommissionSetupMaster Entity
/// </summary>
public class CustomerCommissionSetupMaster : Entity<CustomerCommissionSetupMasterId>
{

    private CustomerCommissionSetupMaster() { }

    public CustomerCommissionSetupMaster(CustomerCommissionSetupMasterId id, decimal? commissionTypeShort)
    {
        Id = id;
        CommissionTypeShort = commissionTypeShort;
    }

    /// <summary>
    /// The unique identifier for the CustomerCommissionSetupMaster
    /// المعرف الفريد لـ CustomerCommissionSetupMaster
    /// </summary>
    public CustomerCommissionSetupMasterId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the CustomerCommissionSetupMaster
    /// CommissionTypeShort الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// CommissionTypeLastName of the CustomerCommissionSetupMaster
    /// CommissionTypeLastName الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public string CommissionTypeLastName { get; private set; }

    /// <summary>
    /// CommissionTypeFirstName of the CustomerCommissionSetupMaster
    /// CommissionTypeFirstName الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public string CommissionTypeFirstName { get; private set; }

    /// <summary>
    /// CustomerCommissionType of the CustomerCommissionSetupMaster
    /// CustomerCommissionType الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CustomerCommissionType { get; private set; }

    /// <summary>
    /// CalculateCommissionItemType of the CustomerCommissionSetupMaster
    /// CalculateCommissionItemType الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CalculateCommissionItemType { get; private set; }

    /// <summary>
    /// CommissionSlicesType of the CustomerCommissionSetupMaster
    /// CommissionSlicesType الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionSlicesType { get; private set; }

    /// <summary>
    /// UseCalculateCommissionPayType of the CustomerCommissionSetupMaster
    /// UseCalculateCommissionPayType الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? UseCalculateCommissionPayType { get; private set; }

    /// <summary>
    /// SeparateTargetAddTargetShort of the CustomerCommissionSetupMaster
    /// SeparateTargetAddTargetShort الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? SeparateTargetAddTargetShort { get; private set; }

    /// <summary>
    /// CommissionCalcTargetMethodShort of the CustomerCommissionSetupMaster
    /// CommissionCalcTargetMethodShort الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionCalcAdditionalTargetMethodShort of the CustomerCommissionSetupMaster
    /// CommissionCalcAdditionalTargetMethodShort الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcAdditionalTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the CustomerCommissionSetupMaster
    /// CommissionAmountTypeShort الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the CustomerCommissionSetupMaster
    /// CommissionAmount الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// InactiveFlag of the CustomerCommissionSetupMaster
    /// InactiveFlag الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CustomerCommissionSetupMaster
    /// InactiveReason الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CustomerCommissionSetupMaster
    /// InactiveDate الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CustomerCommissionSetupMaster
    /// InactivatedByUserId الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the CustomerCommissionSetupMaster
    /// CommissionDescriptionShort الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    /// <summary>
    /// CommissionCalcSalesItemType of the CustomerCommissionSetupMaster
    /// CommissionCalcSalesItemType الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcSalesItemType { get; private set; }

    /// <summary>
    /// CommissionCalcCondition of the CustomerCommissionSetupMaster
    /// CommissionCalcCondition الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcCondition { get; private set; }

    /// <summary>
    /// CustomerPaidDistributionType of the CustomerCommissionSetupMaster
    /// CustomerPaidDistributionType الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CustomerPaidDistributionType { get; private set; }

    /// <summary>
    /// CommissionAmountQuantity of the CustomerCommissionSetupMaster
    /// CommissionAmountQuantity الخاص بـ CustomerCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountQuantity { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
