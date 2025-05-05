using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorDegree Entity
/// </summary>
public class VendorDegree : Entity<VendorDegreeId>
{

    private VendorDegree() { }

    public VendorDegree(VendorDegreeId id, decimal? vendorDegree)
    {
        Id = id;
        VendorDegree = vendorDegree;
    }

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

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

