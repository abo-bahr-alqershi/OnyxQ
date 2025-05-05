using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CollectorCommissionCalculationMaster Entity
/// </summary>
public class CollectorCommissionCalculationMaster : AggregateRoot<CollectorCommissionCalculationMasterId>
{

    private CollectorCommissionCalculationMaster() { }

    public CollectorCommissionCalculationMaster(CollectorCommissionCalculationMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the CollectorCommissionCalculationMaster
    /// المعرف الفريد لـ CollectorCommissionCalculationMaster
    /// </summary>
    public CollectorCommissionCalculationMasterId Id { get; private set; }

    /// <summary>
    /// DocSrl of the CollectorCommissionCalculationMaster
    /// DocSrl الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocNo of the CollectorCommissionCalculationMaster
    /// DocNo الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the CollectorCommissionCalculationMaster
    /// DocDate الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FDate of the CollectorCommissionCalculationMaster
    /// FDate الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CollectorCommissionCalculationMaster
    /// TDate الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the CollectorCommissionCalculationMaster
    /// CommissionTypeShort الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// PlanNumber of the CollectorCommissionCalculationMaster
    /// PlanNumber الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CollectorCommissionCalculationMaster
    /// ReferenceNumber الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the CollectorCommissionCalculationMaster
    /// DocDsc الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// DocSeq of the CollectorCommissionCalculationMaster
    /// DocSeq الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// ProcessedFlag of the CollectorCommissionCalculationMaster
    /// ProcessedFlag الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the CollectorCommissionCalculationMaster
    /// ApprovedFlag الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the CollectorCommissionCalculationMaster
    /// ApprovalDate الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the CollectorCommissionCalculationMaster
    /// ApprovalUserId الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the CollectorCommissionCalculationMaster
    /// ApprovalDescription الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CollectorCommissionCalculationMaster
    /// CompanyNumberShort الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CollectorCommissionCalculationMaster
    /// BranchNumber الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CollectorCommissionCalculationMaster
    /// BranchYear الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CollectorCommissionCalculationMaster
    /// BranchUser الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PlanSerial of the CollectorCommissionCalculationMaster
    /// PlanSerial الخاص بـ CollectorCommissionCalculationMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

