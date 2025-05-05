using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// EmployeeCommissionSetupMaster Entity
/// </summary>
public class EmployeeCommissionSetupMaster : AggregateRoot<EmployeeCommissionSetupMasterId>
{

    private EmployeeCommissionSetupMaster() { }

    public EmployeeCommissionSetupMaster(EmployeeCommissionSetupMasterId id, decimal? commissionTypeShort)
    {
        Id = id;
        CommissionTypeShort = commissionTypeShort;
    }

    /// <summary>
    /// The unique identifier for the EmployeeCommissionSetupMaster
    /// المعرف الفريد لـ EmployeeCommissionSetupMaster
    /// </summary>
    public EmployeeCommissionSetupMasterId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the EmployeeCommissionSetupMaster
    /// CommissionTypeShort الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// CommissionTypeLastName of the EmployeeCommissionSetupMaster
    /// CommissionTypeLastName الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public string CommissionTypeLastName { get; private set; }

    /// <summary>
    /// CommissionTypeFirstName of the EmployeeCommissionSetupMaster
    /// CommissionTypeFirstName الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public string CommissionTypeFirstName { get; private set; }

    /// <summary>
    /// EmpCommTyp of the EmployeeCommissionSetupMaster
    /// EmpCommTyp الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? EmpCommTyp { get; private set; }

    /// <summary>
    /// CommissionAmountQuantity of the EmployeeCommissionSetupMaster
    /// CommissionAmountQuantity الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountQuantity { get; private set; }

    /// <summary>
    /// EmpCstCommTyp of the EmployeeCommissionSetupMaster
    /// EmpCstCommTyp الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? EmpCstCommTyp { get; private set; }

    /// <summary>
    /// CalculateCommissionItemType of the EmployeeCommissionSetupMaster
    /// CalculateCommissionItemType الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? CalculateCommissionItemType { get; private set; }

    /// <summary>
    /// CommissionSlicesType of the EmployeeCommissionSetupMaster
    /// CommissionSlicesType الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? CommissionSlicesType { get; private set; }

    /// <summary>
    /// UseCalculateCommissionPayType of the EmployeeCommissionSetupMaster
    /// UseCalculateCommissionPayType الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? UseCalculateCommissionPayType { get; private set; }

    /// <summary>
    /// SeparateTargetAddTargetShort of the EmployeeCommissionSetupMaster
    /// SeparateTargetAddTargetShort الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? SeparateTargetAddTargetShort { get; private set; }

    /// <summary>
    /// CommissionCalcTargetMethodShort of the EmployeeCommissionSetupMaster
    /// CommissionCalcTargetMethodShort الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionCalcAdditionalTargetMethodShort of the EmployeeCommissionSetupMaster
    /// CommissionCalcAdditionalTargetMethodShort الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcAdditionalTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the EmployeeCommissionSetupMaster
    /// CommissionAmountTypeShort الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the EmployeeCommissionSetupMaster
    /// CommissionAmount الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeCommissionSetupMaster
    /// InactiveFlag الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the EmployeeCommissionSetupMaster
    /// InactiveReason الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the EmployeeCommissionSetupMaster
    /// InactiveDate الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the EmployeeCommissionSetupMaster
    /// InactivatedByUserId الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the EmployeeCommissionSetupMaster
    /// CommissionDescriptionShort الخاص بـ EmployeeCommissionSetupMaster
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

