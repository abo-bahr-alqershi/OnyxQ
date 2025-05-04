using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// VoucherType Entity
/// </summary>
public class VoucherType : Entity<VoucherTypeId>
{

    private VoucherType() { }

    public VoucherType(VoucherTypeId id, decimal? vendorType, decimal? vendorTypeNumber)
    {
        Id = id;
        VendorType = vendorType;
        VendorTypeNumber = vendorTypeNumber;
    }

    /// <summary>
    /// The unique identifier for the VoucherType
    /// المعرف الفريد لـ VoucherType
    /// </summary>
    public VoucherTypeId Id { get; private set; }

    /// <summary>
    /// VendorType of the VoucherType
    /// VendorType الخاص بـ VoucherType
    /// </summary>
    public decimal? VendorType { get; private set; }

    /// <summary>
    /// VendorTypeNumber of the VoucherType
    /// VendorTypeNumber الخاص بـ VoucherType
    /// </summary>
    public decimal? VendorTypeNumber { get; private set; }

    /// <summary>
    /// VendorTypeNameArabic of the VoucherType
    /// VendorTypeNameArabic الخاص بـ VoucherType
    /// </summary>
    public string VendorTypeNameArabic { get; private set; }

    /// <summary>
    /// VendorTypeNameEnglish of the VoucherType
    /// VendorTypeNameEnglish الخاص بـ VoucherType
    /// </summary>
    public string VendorTypeNameEnglish { get; private set; }

    /// <summary>
    /// ConnectionVoucherRequest of the VoucherType
    /// ConnectionVoucherRequest الخاص بـ VoucherType
    /// </summary>
    public decimal? ConnectionVoucherRequest { get; private set; }

    /// <summary>
    /// TransactionType of the VoucherType
    /// TransactionType الخاص بـ VoucherType
    /// </summary>
    public decimal? TransactionType { get; private set; }

    /// <summary>
    /// VatDeferredProvider of the VoucherType
    /// VatDeferredProvider الخاص بـ VoucherType
    /// </summary>
    public decimal? VatDeferredProvider { get; private set; }

    /// <summary>
    /// ExpenseTaxFlag of the VoucherType
    /// ExpenseTaxFlag الخاص بـ VoucherType
    /// </summary>
    public decimal? ExpenseTaxFlag { get; private set; }

    /// <summary>
    /// CashBranchesTransfer of the VoucherType
    /// CashBranchesTransfer الخاص بـ VoucherType
    /// </summary>
    public decimal? CashBranchesTransfer { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
