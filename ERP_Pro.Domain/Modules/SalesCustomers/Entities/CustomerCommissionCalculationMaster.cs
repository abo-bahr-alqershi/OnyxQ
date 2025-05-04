using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCommissionCalculationMaster Entity
/// </summary>
public class CustomerCommissionCalculationMaster : Entity<CustomerCommissionCalculationMasterId>
{

    private CustomerCommissionCalculationMaster() { }

    public CustomerCommissionCalculationMaster(CustomerCommissionCalculationMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the CustomerCommissionCalculationMaster
    /// المعرف الفريد لـ CustomerCommissionCalculationMaster
    /// </summary>
    public CustomerCommissionCalculationMasterId Id { get; private set; }

    /// <summary>
    /// DocSrl of the CustomerCommissionCalculationMaster
    /// DocSrl الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocNo of the CustomerCommissionCalculationMaster
    /// DocNo الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the CustomerCommissionCalculationMaster
    /// DocDate الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FDate of the CustomerCommissionCalculationMaster
    /// FDate الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CustomerCommissionCalculationMaster
    /// TDate الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the CustomerCommissionCalculationMaster
    /// CommissionTypeShort الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// PlanNumber of the CustomerCommissionCalculationMaster
    /// PlanNumber الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CustomerCommissionCalculationMaster
    /// ReferenceNumber الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the CustomerCommissionCalculationMaster
    /// DocDsc الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ProcessedFlag of the CustomerCommissionCalculationMaster
    /// ProcessedFlag الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the CustomerCommissionCalculationMaster
    /// ApprovedFlag الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the CustomerCommissionCalculationMaster
    /// ApprovalDate الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the CustomerCommissionCalculationMaster
    /// ApprovalUserId الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the CustomerCommissionCalculationMaster
    /// ApprovalDescription الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// PlanSerial of the CustomerCommissionCalculationMaster
    /// PlanSerial الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CustomerCommissionCalculationMaster
    /// CompanyNumberShort الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerCommissionCalculationMaster
    /// BranchNumber الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CustomerCommissionCalculationMaster
    /// BranchYear الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CustomerCommissionCalculationMaster
    /// BranchUser الخاص بـ CustomerCommissionCalculationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
