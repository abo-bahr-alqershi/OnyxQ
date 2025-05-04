using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// VendorAccount Entity
/// </summary>
public class VendorAccount : Entity<VendorAccountId>
{

    private VendorAccount() { }

    public VendorAccount(VendorAccountId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the VendorAccount
    /// المعرف الفريد لـ VendorAccount
    /// </summary>
    public VendorAccountId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the VendorAccount
    /// RecordNumber الخاص بـ VendorAccount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the VendorAccount
    /// InactiveFlag الخاص بـ VendorAccount
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the VendorAccount
    /// InactiveDate الخاص بـ VendorAccount
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the VendorAccount
    /// InactiveReason الخاص بـ VendorAccount
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the VendorAccount
    /// InactivatedByUserId الخاص بـ VendorAccount
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
