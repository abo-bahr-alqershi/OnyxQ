using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorGroup Entity
/// </summary>
public class VendorGroup : Entity<VendorGroupId>
{
    private VendorGroup() { }

    /// <summary>
    /// The unique identifier for the VendorGroup
    /// المعرف الفريد لـ VendorGroup
    /// </summary>
    public VendorGroupId Id { get; private set; }

    /// <summary>
    /// VendorGroupCode of the VendorGroup
    /// VendorGroupCode الخاص بـ VendorGroup
    /// </summary>
    public decimal? VendorGroupCode { get; private set; }

    /// <summary>
    /// VendorGroupNameArabic of the VendorGroup
    /// VendorGroupNameArabic الخاص بـ VendorGroup
    /// </summary>
    public string VendorGroupNameArabic { get; private set; }

    /// <summary>
    /// VendorGroupNameEnglish of the VendorGroup
    /// VendorGroupNameEnglish الخاص بـ VendorGroup
    /// </summary>
    public string VendorGroupNameEnglish { get; private set; }

    /// <summary>
    /// VendorAccountCode of the VendorGroup
    /// VendorAccountCode الخاص بـ VendorGroup
    /// </summary>
    public string VendorAccountCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: VendorGroup to VoucherDetails
    /// </summary>
    public IReadOnlyCollection<VoucherDetails> VoucherDetailses { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    #endregion
}
}
