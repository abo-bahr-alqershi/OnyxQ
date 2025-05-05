using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableQuotationCompareMember Entity
/// </summary>
public class AccountsPayableQuotationCompareMember : Entity<AccountsPayableQuotationCompareMemberId>
{

    private AccountsPayableQuotationCompareMember() { }

    public AccountsPayableQuotationCompareMember(AccountsPayableQuotationCompareMemberId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareMember
    /// المعرف الفريد لـ AccountsPayableQuotationCompareMember
    /// </summary>
    public AccountsPayableQuotationCompareMemberId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsPayableQuotationCompareMember
    /// DocNo الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDDsc of the AccountsPayableQuotationCompareMember
    /// DocDDsc الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public string DocDDsc { get; private set; }

    /// <summary>
    /// 1000 of the AccountsPayableQuotationCompareMember
    /// 1000 الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public string 1000 { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableQuotationCompareMember
    /// RecordNumber الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// MemberNumber of the AccountsPayableQuotationCompareMember
    /// MemberNumber الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? MemberNumber { get; private set; }

    /// <summary>
    /// EmpNo of the AccountsPayableQuotationCompareMember
    /// EmpNo الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// HierarchyNumber of the AccountsPayableQuotationCompareMember
    /// HierarchyNumber الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public string HierarchyNumber { get; private set; }

    /// <summary>
    /// 30 of the AccountsPayableQuotationCompareMember
    /// 30 الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsPayableQuotationCompareMember
    /// InactiveFlag الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AccountsPayableQuotationCompareMember
    /// InactivatedByUserId الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AccountsPayableQuotationCompareMember
    /// InactiveDate الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AccountsPayableQuotationCompareMember
    /// InactiveReason الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableQuotationCompareMember
    /// CompanyNumberShort الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableQuotationCompareMember
    /// BranchNumber الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableQuotationCompareMember
    /// BranchYear الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableQuotationCompareMember
    /// BranchUser الخاص بـ AccountsPayableQuotationCompareMember
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsPayableQuotationCompareMaster AccountsPayableQuotationCompareMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

