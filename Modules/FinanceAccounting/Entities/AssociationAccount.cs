using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AssociationAccount Entity
/// </summary>
public class AssociationAccount : Entity<AssociationAccountId>
{
    private AssociationAccount() { }

    /// <summary>
    /// The unique identifier for the AssociationAccount
    /// المعرف الفريد لـ AssociationAccount
    /// </summary>
    public AssociationAccountId Id { get; private set; }

    /// <summary>
    /// AssessmentNumber of the AssociationAccount
    /// AssessmentNumber الخاص بـ AssociationAccount
    /// </summary>
    public decimal? AssessmentNumber { get; private set; }

    /// <summary>
    /// AssessmentLastName of the AssociationAccount
    /// AssessmentLastName الخاص بـ AssociationAccount
    /// </summary>
    public string AssessmentLastName { get; private set; }

    /// <summary>
    /// AssessmentFirstName of the AssociationAccount
    /// AssessmentFirstName الخاص بـ AssociationAccount
    /// </summary>
    public string AssessmentFirstName { get; private set; }

    /// <summary>
    /// AccountCode of the AssociationAccount
    /// AccountCode الخاص بـ AssociationAccount
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AssociationAccount
    /// AccountDetailCode الخاص بـ AssociationAccount
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AssociationAccount
    /// AccountDetailType الخاص بـ AssociationAccount
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AssessmentDefaultFlag of the AssociationAccount
    /// AssessmentDefaultFlag الخاص بـ AssociationAccount
    /// </summary>
    public decimal? AssessmentDefaultFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the AssociationAccount
    /// InactiveFlag الخاص بـ AssociationAccount
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AssociationAccount
    /// InactivatedByUserId الخاص بـ AssociationAccount
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AssociationAccount
    /// InactiveDate الخاص بـ AssociationAccount
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AssociationAccount
    /// InactiveReason الخاص بـ AssociationAccount
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    #endregion
}
}
