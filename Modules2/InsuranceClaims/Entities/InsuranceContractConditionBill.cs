using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceContractConditionBill Entity
/// </summary>
public class InsuranceContractConditionBill : Entity<InsuranceContractConditionBillId>
{

    private InsuranceContractConditionBill() { }

    public InsuranceContractConditionBill(InsuranceContractConditionBillId id, decimal? conditionNumber)
    {
        Id = id;
        ConditionNumber = conditionNumber;
    }

    /// <summary>
    /// The unique identifier for the InsuranceContractConditionBill
    /// المعرف الفريد لـ InsuranceContractConditionBill
    /// </summary>
    public InsuranceContractConditionBillId Id { get; private set; }

    /// <summary>
    /// BillNumber of the InsuranceContractConditionBill
    /// BillNumber الخاص بـ InsuranceContractConditionBill
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// ConditionNumber of the InsuranceContractConditionBill
    /// ConditionNumber الخاص بـ InsuranceContractConditionBill
    /// </summary>
    public decimal? ConditionNumber { get; private set; }

    /// <summary>
    /// ConditionVerifyFlag of the InsuranceContractConditionBill
    /// ConditionVerifyFlag الخاص بـ InsuranceContractConditionBill
    /// </summary>
    public decimal? ConditionVerifyFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InsuranceContractConditionBill
    /// CompanyNumberShort الخاص بـ InsuranceContractConditionBill
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InsuranceContractConditionBill
    /// BranchNumber الخاص بـ InsuranceContractConditionBill
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InsuranceContractConditionBill
    /// BranchYear الخاص بـ InsuranceContractConditionBill
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InsuranceContractConditionBill
    /// BranchUser الخاص بـ InsuranceContractConditionBill
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InsuranceCompany InsuranceCompany { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public BillMaster BillMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

