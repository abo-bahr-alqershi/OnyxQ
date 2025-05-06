using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CalculateCommissionMaster Entity
/// </summary>
public class CalculateCommissionMaster : Entity<CalculateCommissionMasterId>
{

    private CalculateCommissionMaster() { }

    public CalculateCommissionMaster(CalculateCommissionMasterId id, decimal? commissionSerial)
    {
        Id = id;
        CommissionSerial = commissionSerial;
    }

    /// <summary>
    /// The unique identifier for the CalculateCommissionMaster
    /// المعرف الفريد لـ CalculateCommissionMaster
    /// </summary>
    public CalculateCommissionMasterId Id { get; private set; }

    /// <summary>
    /// CommissionNumber of the CalculateCommissionMaster
    /// CommissionNumber الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? CommissionNumber { get; private set; }

    /// <summary>
    /// CommissionDate of the CalculateCommissionMaster
    /// CommissionDate الخاص بـ CalculateCommissionMaster
    /// </summary>
    public DateTime? CommissionDate { get; private set; }

    /// <summary>
    /// FDate of the CalculateCommissionMaster
    /// FDate الخاص بـ CalculateCommissionMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CalculateCommissionMaster
    /// TDate الخاص بـ CalculateCommissionMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CalculationType of the CalculateCommissionMaster
    /// CalculationType الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? CalculationType { get; private set; }

    /// <summary>
    /// CommissionSerial of the CalculateCommissionMaster
    /// CommissionSerial الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? CommissionSerial { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the CalculateCommissionMaster
    /// ProcessedFlagFull الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ApprovedFlag of the CalculateCommissionMaster
    /// ApprovedFlag الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the CalculateCommissionMaster
    /// ApprovalDate الخاص بـ CalculateCommissionMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the CalculateCommissionMaster
    /// ApprovalUserId الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the CalculateCommissionMaster
    /// ApprovalDescription الخاص بـ CalculateCommissionMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CalculateCommissionMaster
    /// CompanyNumberShort الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CalculateCommissionMaster
    /// BranchNumber الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CalculateCommissionMaster
    /// BranchYear الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CalculateCommissionMaster
    /// BranchUser الخاص بـ CalculateCommissionMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

