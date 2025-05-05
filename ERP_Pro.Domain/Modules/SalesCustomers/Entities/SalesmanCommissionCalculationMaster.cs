using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionCalculationMaster Entity
/// </summary>
public class SalesmanCommissionCalculationMaster : AggregateRoot<SalesmanCommissionCalculationMasterId>
{

    private SalesmanCommissionCalculationMaster() { }

    public SalesmanCommissionCalculationMaster(SalesmanCommissionCalculationMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionCalculationMaster
    /// المعرف الفريد لـ SalesmanCommissionCalculationMaster
    /// </summary>
    public SalesmanCommissionCalculationMasterId Id { get; private set; }

    /// <summary>
    /// DocSrl of the SalesmanCommissionCalculationMaster
    /// DocSrl الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocNo of the SalesmanCommissionCalculationMaster
    /// DocNo الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the SalesmanCommissionCalculationMaster
    /// DocDate الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FDate of the SalesmanCommissionCalculationMaster
    /// FDate الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesmanCommissionCalculationMaster
    /// TDate الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the SalesmanCommissionCalculationMaster
    /// CommissionTypeShort الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// PlanNumber of the SalesmanCommissionCalculationMaster
    /// PlanNumber الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the SalesmanCommissionCalculationMaster
    /// ReferenceNumber الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the SalesmanCommissionCalculationMaster
    /// DocDsc الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ProcessedFlag of the SalesmanCommissionCalculationMaster
    /// ProcessedFlag الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the SalesmanCommissionCalculationMaster
    /// ApprovedFlag الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the SalesmanCommissionCalculationMaster
    /// ApprovalDate الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the SalesmanCommissionCalculationMaster
    /// ApprovalUserId الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the SalesmanCommissionCalculationMaster
    /// ApprovalDescription الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SalesmanCommissionCalculationMaster
    /// CompanyNumberShort الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesmanCommissionCalculationMaster
    /// BranchNumber الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SalesmanCommissionCalculationMaster
    /// BranchYear الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SalesmanCommissionCalculationMaster
    /// BranchUser الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PlanSerial of the SalesmanCommissionCalculationMaster
    /// PlanSerial الخاص بـ SalesmanCommissionCalculationMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

