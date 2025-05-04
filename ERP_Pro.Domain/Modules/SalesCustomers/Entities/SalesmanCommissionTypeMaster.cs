using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionTypeMaster Entity
/// </summary>
public class SalesmanCommissionTypeMaster : Entity<SalesmanCommissionTypeMasterId>
{

    private SalesmanCommissionTypeMaster() { }

    public SalesmanCommissionTypeMaster(SalesmanCommissionTypeMasterId id, decimal? commissionType)
    {
        Id = id;
        CommissionType = commissionType;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionTypeMaster
    /// المعرف الفريد لـ SalesmanCommissionTypeMaster
    /// </summary>
    public SalesmanCommissionTypeMasterId Id { get; private set; }

    /// <summary>
    /// CommissionType of the SalesmanCommissionTypeMaster
    /// CommissionType الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? CommissionType { get; private set; }

    /// <summary>
    /// CommissionTypeNameArabic of the SalesmanCommissionTypeMaster
    /// CommissionTypeNameArabic الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public string CommissionTypeNameArabic { get; private set; }

    /// <summary>
    /// CommissionTypeNameEnglish of the SalesmanCommissionTypeMaster
    /// CommissionTypeNameEnglish الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public string CommissionTypeNameEnglish { get; private set; }

    /// <summary>
    /// CommissionCalcMethod of the SalesmanCommissionTypeMaster
    /// CommissionCalcMethod الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? CommissionCalcMethod { get; private set; }

    /// <summary>
    /// CommissionApprovedMethod of the SalesmanCommissionTypeMaster
    /// CommissionApprovedMethod الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? CommissionApprovedMethod { get; private set; }

    /// <summary>
    /// CalculateCommissionItemCode of the SalesmanCommissionTypeMaster
    /// CalculateCommissionItemCode الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? CalculateCommissionItemCode { get; private set; }

    /// <summary>
    /// InactiveFlag of the SalesmanCommissionTypeMaster
    /// InactiveFlag الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the SalesmanCommissionTypeMaster
    /// InactiveReason الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the SalesmanCommissionTypeMaster
    /// InactiveDate الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the SalesmanCommissionTypeMaster
    /// InactivatedByUserId الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CommissionDescription of the SalesmanCommissionTypeMaster
    /// CommissionDescription الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public string CommissionDescription { get; private set; }

    /// <summary>
    /// SeparateTargetAddTarget of the SalesmanCommissionTypeMaster
    /// SeparateTargetAddTarget الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? SeparateTargetAddTarget { get; private set; }

    /// <summary>
    /// CommissionCalcTargetMethod of the SalesmanCommissionTypeMaster
    /// CommissionCalcTargetMethod الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? CommissionCalcTargetMethod { get; private set; }

    /// <summary>
    /// CommissionCalcAdditionalTargetMethod of the SalesmanCommissionTypeMaster
    /// CommissionCalcAdditionalTargetMethod الخاص بـ SalesmanCommissionTypeMaster
    /// </summary>
    public decimal? CommissionCalcAdditionalTargetMethod { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
