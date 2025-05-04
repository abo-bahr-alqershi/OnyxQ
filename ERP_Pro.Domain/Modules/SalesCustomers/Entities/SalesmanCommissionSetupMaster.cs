using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionSetupMaster Entity
/// </summary>
public class SalesmanCommissionSetupMaster : Entity<SalesmanCommissionSetupMasterId>
{

    private SalesmanCommissionSetupMaster() { }

    public SalesmanCommissionSetupMaster(SalesmanCommissionSetupMasterId id, decimal? commissionTypeShort)
    {
        Id = id;
        CommissionTypeShort = commissionTypeShort;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionSetupMaster
    /// المعرف الفريد لـ SalesmanCommissionSetupMaster
    /// </summary>
    public SalesmanCommissionSetupMasterId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the SalesmanCommissionSetupMaster
    /// CommissionTypeShort الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// CommissionTypeLastName of the SalesmanCommissionSetupMaster
    /// CommissionTypeLastName الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public string CommissionTypeLastName { get; private set; }

    /// <summary>
    /// CommissionTypeFirstName of the SalesmanCommissionSetupMaster
    /// CommissionTypeFirstName الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public string CommissionTypeFirstName { get; private set; }

    /// <summary>
    /// SalesmanCommissionType of the SalesmanCommissionSetupMaster
    /// SalesmanCommissionType الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? SalesmanCommissionType { get; private set; }

    /// <summary>
    /// CalculateCommissionItemType of the SalesmanCommissionSetupMaster
    /// CalculateCommissionItemType الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CalculateCommissionItemType { get; private set; }

    /// <summary>
    /// CommissionSlicesType of the SalesmanCommissionSetupMaster
    /// CommissionSlicesType الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CommissionSlicesType { get; private set; }

    /// <summary>
    /// UseCalculateCommissionPayType of the SalesmanCommissionSetupMaster
    /// UseCalculateCommissionPayType الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? UseCalculateCommissionPayType { get; private set; }

    /// <summary>
    /// UseCalculateColumnAmount of the SalesmanCommissionSetupMaster
    /// UseCalculateColumnAmount الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? UseCalculateColumnAmount { get; private set; }

    /// <summary>
    /// SeparateTargetAddTargetShort of the SalesmanCommissionSetupMaster
    /// SeparateTargetAddTargetShort الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? SeparateTargetAddTargetShort { get; private set; }

    /// <summary>
    /// CommissionCalcTargetMethodShort of the SalesmanCommissionSetupMaster
    /// CommissionCalcTargetMethodShort الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionCalcAdditionalTargetMethodShort of the SalesmanCommissionSetupMaster
    /// CommissionCalcAdditionalTargetMethodShort الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcAdditionalTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionAmountQuantity of the SalesmanCommissionSetupMaster
    /// CommissionAmountQuantity الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountQuantity { get; private set; }

    /// <summary>
    /// SalesmanCustomerCommissionType of the SalesmanCommissionSetupMaster
    /// SalesmanCustomerCommissionType الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? SalesmanCustomerCommissionType { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the SalesmanCommissionSetupMaster
    /// CommissionAmountTypeShort الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanCommissionSetupMaster
    /// CommissionAmount الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// InactiveFlag of the SalesmanCommissionSetupMaster
    /// InactiveFlag الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the SalesmanCommissionSetupMaster
    /// InactiveReason الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the SalesmanCommissionSetupMaster
    /// InactiveDate الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the SalesmanCommissionSetupMaster
    /// InactivatedByUserId الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the SalesmanCommissionSetupMaster
    /// CommissionDescriptionShort الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    /// <summary>
    /// SalesmanRegionCommissionType of the SalesmanCommissionSetupMaster
    /// SalesmanRegionCommissionType الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? SalesmanRegionCommissionType { get; private set; }

    /// <summary>
    /// ConnectionSalesmanCommissionCollector of the SalesmanCommissionSetupMaster
    /// ConnectionSalesmanCommissionCollector الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? ConnectionSalesmanCommissionCollector { get; private set; }

    /// <summary>
    /// ConnectionConditionCommissionType of the SalesmanCommissionSetupMaster
    /// ConnectionConditionCommissionType الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? ConnectionConditionCommissionType { get; private set; }

    /// <summary>
    /// ByCompanyQuantity of the SalesmanCommissionSetupMaster
    /// ByCompanyQuantity الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? ByCompanyQuantity { get; private set; }

    /// <summary>
    /// CalculateCommissionPrintSalesman of the SalesmanCommissionSetupMaster
    /// CalculateCommissionPrintSalesman الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? CalculateCommissionPrintSalesman { get; private set; }

    /// <summary>
    /// UseCalculateCommissionLevelPriceFlag of the SalesmanCommissionSetupMaster
    /// UseCalculateCommissionLevelPriceFlag الخاص بـ SalesmanCommissionSetupMaster
    /// </summary>
    public decimal? UseCalculateCommissionLevelPriceFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
