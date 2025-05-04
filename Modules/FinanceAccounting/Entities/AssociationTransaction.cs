using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AssociationTransaction Entity
/// </summary>
public class AssociationTransaction : Entity<AssociationTransactionId>
{
    private AssociationTransaction() { }

    /// <summary>
    /// The unique identifier for the AssociationTransaction
    /// المعرف الفريد لـ AssociationTransaction
    /// </summary>
    public AssociationTransactionId Id { get; private set; }

    /// <summary>
    /// BillNumber of the AssociationTransaction
    /// BillNumber الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the AssociationTransaction
    /// BillSerial الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// AssessmentNumber of the AssociationTransaction
    /// AssessmentNumber الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? AssessmentNumber { get; private set; }

    /// <summary>
    /// AccountCode of the AssociationTransaction
    /// AccountCode الخاص بـ AssociationTransaction
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AssociationTransaction
    /// AccountDetailCode الخاص بـ AssociationTransaction
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AssociationTransaction
    /// AccountDetailType الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AssessmentAmount of the AssociationTransaction
    /// AssessmentAmount الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? AssessmentAmount { get; private set; }

    /// <summary>
    /// CostCenterCode of the AssociationTransaction
    /// CostCenterCode الخاص بـ AssociationTransaction
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AssociationTransaction
    /// ProjectNumber الخاص بـ AssociationTransaction
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AssociationTransaction
    /// ActivityNumber الخاص بـ AssociationTransaction
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// BillDate of the AssociationTransaction
    /// BillDate الخاص بـ AssociationTransaction
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AssociationTransaction
    /// ExternalPostFlag الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AssociationTransaction
    /// CompanyNumberShort الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AssociationTransaction
    /// BranchNumber الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AssociationTransaction
    /// BranchYear الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AssociationTransaction
    /// BranchUser الخاص بـ AssociationTransaction
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to BillMaster
    /// </summary>
    public BillMaster BillMaster { get; private set; }
    #endregion
}
}
