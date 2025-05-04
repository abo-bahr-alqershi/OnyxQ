using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionCommissionCalculationMaster Entity
/// </summary>
public class PromotionCommissionCalculationMaster : Entity<PromotionCommissionCalculationMasterId>
{
    private PromotionCommissionCalculationMaster() { }

    /// <summary>
    /// The unique identifier for the PromotionCommissionCalculationMaster
    /// المعرف الفريد لـ PromotionCommissionCalculationMaster
    /// </summary>
    public PromotionCommissionCalculationMasterId Id { get; private set; }

    /// <summary>
    /// DocSrl of the PromotionCommissionCalculationMaster
    /// DocSrl الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocNo of the PromotionCommissionCalculationMaster
    /// DocNo الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the PromotionCommissionCalculationMaster
    /// DocDate الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FDate of the PromotionCommissionCalculationMaster
    /// FDate الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the PromotionCommissionCalculationMaster
    /// TDate الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the PromotionCommissionCalculationMaster
    /// CommissionTypeShort الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// PlanNumber of the PromotionCommissionCalculationMaster
    /// PlanNumber الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PromotionCommissionCalculationMaster
    /// ReferenceNumber الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the PromotionCommissionCalculationMaster
    /// DocDsc الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ProcessedFlag of the PromotionCommissionCalculationMaster
    /// ProcessedFlag الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the PromotionCommissionCalculationMaster
    /// ApprovedFlag الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the PromotionCommissionCalculationMaster
    /// ApprovalDate الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the PromotionCommissionCalculationMaster
    /// ApprovalUserId الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the PromotionCommissionCalculationMaster
    /// ApprovalDescription الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PromotionCommissionCalculationMaster
    /// CompanyNumberShort الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PromotionCommissionCalculationMaster
    /// BranchNumber الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PromotionCommissionCalculationMaster
    /// BranchYear الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PromotionCommissionCalculationMaster
    /// BranchUser الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PlanSerial of the PromotionCommissionCalculationMaster
    /// PlanSerial الخاص بـ PromotionCommissionCalculationMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: PromotionCommissionCalculationMaster to PromotionCommissionCalculationDetail
    /// </summary>
    public IReadOnlyCollection<PromotionCommissionCalculationDetail> PromotionCommissionCalculationDetails { get; private set; }
    #endregion
}
}
