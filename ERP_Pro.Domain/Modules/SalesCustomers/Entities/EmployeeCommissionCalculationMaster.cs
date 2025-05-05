using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// EmployeeCommissionCalculationMaster Entity
/// </summary>
public class EmployeeCommissionCalculationMaster : AggregateRoot<EmployeeCommissionCalculationMasterId>
{

    private EmployeeCommissionCalculationMaster() { }

    public EmployeeCommissionCalculationMaster(EmployeeCommissionCalculationMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the EmployeeCommissionCalculationMaster
    /// المعرف الفريد لـ EmployeeCommissionCalculationMaster
    /// </summary>
    public EmployeeCommissionCalculationMasterId Id { get; private set; }

    /// <summary>
    /// DocSrl of the EmployeeCommissionCalculationMaster
    /// DocSrl الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocNo of the EmployeeCommissionCalculationMaster
    /// DocNo الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the EmployeeCommissionCalculationMaster
    /// DocDate الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FDate of the EmployeeCommissionCalculationMaster
    /// FDate الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the EmployeeCommissionCalculationMaster
    /// TDate الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the EmployeeCommissionCalculationMaster
    /// CommissionTypeShort الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// PlanNumber of the EmployeeCommissionCalculationMaster
    /// PlanNumber الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the EmployeeCommissionCalculationMaster
    /// ReferenceNumber الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the EmployeeCommissionCalculationMaster
    /// DocDsc الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ProcessedFlag of the EmployeeCommissionCalculationMaster
    /// ProcessedFlag الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the EmployeeCommissionCalculationMaster
    /// ApprovedFlag الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the EmployeeCommissionCalculationMaster
    /// ApprovalDate الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the EmployeeCommissionCalculationMaster
    /// ApprovalUserId الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the EmployeeCommissionCalculationMaster
    /// ApprovalDescription الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the EmployeeCommissionCalculationMaster
    /// CompanyNumberShort الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the EmployeeCommissionCalculationMaster
    /// BranchNumber الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the EmployeeCommissionCalculationMaster
    /// BranchYear الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the EmployeeCommissionCalculationMaster
    /// BranchUser الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PlanSerial of the EmployeeCommissionCalculationMaster
    /// PlanSerial الخاص بـ EmployeeCommissionCalculationMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

