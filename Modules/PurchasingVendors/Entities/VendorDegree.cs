using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorDegree Entity
/// </summary>
public class VendorDegree : Entity<VendorDegreeId>
{
    private VendorDegree() { }

    /// <summary>
    /// The unique identifier for the VendorDegree
    /// المعرف الفريد لـ VendorDegree
    /// </summary>
    public VendorDegreeId Id { get; private set; }

    /// <summary>
    /// VendorDegree of the VendorDegree
    /// VendorDegree الخاص بـ VendorDegree
    /// </summary>
    public decimal? VendorDegree { get; private set; }

    /// <summary>
    /// VendorDegreeNameArabic of the VendorDegree
    /// VendorDegreeNameArabic الخاص بـ VendorDegree
    /// </summary>
    public string VendorDegreeNameArabic { get; private set; }

    /// <summary>
    /// VendorDegreeNameEnglish of the VendorDegree
    /// VendorDegreeNameEnglish الخاص بـ VendorDegree
    /// </summary>
    public string VendorDegreeNameEnglish { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: VendorDegree to VoucherDetails
    /// </summary>
    public IReadOnlyCollection<VoucherDetails> VoucherDetailses { get; private set; }
    #endregion
}
}
