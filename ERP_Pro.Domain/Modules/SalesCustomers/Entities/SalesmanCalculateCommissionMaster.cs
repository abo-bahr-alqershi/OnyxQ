using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCalculateCommissionMaster Entity
/// </summary>
public class SalesmanCalculateCommissionMaster : AggregateRoot<SalesmanCalculateCommissionMasterId>
{

    private SalesmanCalculateCommissionMaster() { }

    public SalesmanCalculateCommissionMaster(SalesmanCalculateCommissionMasterId id, decimal? commissionSerial)
    {
        Id = id;
        CommissionSerial = commissionSerial;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCalculateCommissionMaster
    /// المعرف الفريد لـ SalesmanCalculateCommissionMaster
    /// </summary>
    public SalesmanCalculateCommissionMasterId Id { get; private set; }

    /// <summary>
    /// CommissionNumber of the SalesmanCalculateCommissionMaster
    /// CommissionNumber الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? CommissionNumber { get; private set; }

    /// <summary>
    /// CommissionDate of the SalesmanCalculateCommissionMaster
    /// CommissionDate الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public DateTime? CommissionDate { get; private set; }

    /// <summary>
    /// FDate of the SalesmanCalculateCommissionMaster
    /// FDate الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesmanCalculateCommissionMaster
    /// TDate الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CommissionType of the SalesmanCalculateCommissionMaster
    /// CommissionType الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? CommissionType { get; private set; }

    /// <summary>
    /// PlanPeriodType of the SalesmanCalculateCommissionMaster
    /// PlanPeriodType الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// ReferenceNumber of the SalesmanCalculateCommissionMaster
    /// ReferenceNumber الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CommissionDescription of the SalesmanCalculateCommissionMaster
    /// CommissionDescription الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public string CommissionDescription { get; private set; }

    /// <summary>
    /// CommissionSerial of the SalesmanCalculateCommissionMaster
    /// CommissionSerial الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? CommissionSerial { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the SalesmanCalculateCommissionMaster
    /// ProcessedFlagFull الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ApprovedFlag of the SalesmanCalculateCommissionMaster
    /// ApprovedFlag الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the SalesmanCalculateCommissionMaster
    /// ApprovalDate الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the SalesmanCalculateCommissionMaster
    /// ApprovalUserId الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the SalesmanCalculateCommissionMaster
    /// ApprovalDescription الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SalesmanCalculateCommissionMaster
    /// CompanyNumberShort الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesmanCalculateCommissionMaster
    /// BranchNumber الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SalesmanCalculateCommissionMaster
    /// BranchYear الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SalesmanCalculateCommissionMaster
    /// BranchUser الخاص بـ SalesmanCalculateCommissionMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

