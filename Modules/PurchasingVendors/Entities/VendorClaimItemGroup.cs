using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorClaimItemGroup Entity
/// </summary>
public class VendorClaimItemGroup : Entity<VendorClaimItemGroupId>
{
    private VendorClaimItemGroup() { }

    /// <summary>
    /// The unique identifier for the VendorClaimItemGroup
    /// المعرف الفريد لـ VendorClaimItemGroup
    /// </summary>
    public VendorClaimItemGroupId Id { get; private set; }

    /// <summary>
    /// VendorCode of the VendorClaimItemGroup
    /// VendorCode الخاص بـ VendorClaimItemGroup
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// RecordNumber of the VendorClaimItemGroup
    /// RecordNumber الخاص بـ VendorClaimItemGroup
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemGroupType of the VendorClaimItemGroup
    /// ItemGroupType الخاص بـ VendorClaimItemGroup
    /// </summary>
    public decimal? ItemGroupType { get; private set; }

    /// <summary>
    /// ItemGroupValue of the VendorClaimItemGroup
    /// ItemGroupValue الخاص بـ VendorClaimItemGroup
    /// </summary>
    public string ItemGroupValue { get; private set; }

    /// <summary>
    /// BranchYear of the VendorClaimItemGroup
    /// BranchYear الخاص بـ VendorClaimItemGroup
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the VendorClaimItemGroup
    /// BranchUser الخاص بـ VendorClaimItemGroup
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion
}
}
