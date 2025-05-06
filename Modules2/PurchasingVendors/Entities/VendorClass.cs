using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorClass Entity
/// </summary>
public class VendorClass : Entity<VendorClassId>
{

    private VendorClass() { }

    public VendorClass(VendorClassId id, decimal? vendorClass)
    {
        Id = id;
        VendorClass = vendorClass;
    }

    /// <summary>
    /// The unique identifier for the VendorClass
    /// المعرف الفريد لـ VendorClass
    /// </summary>
    public VendorClassId Id { get; private set; }

    /// <summary>
    /// VendorClass of the VendorClass
    /// VendorClass الخاص بـ VendorClass
    /// </summary>
    public decimal? VendorClass { get; private set; }

    /// <summary>
    /// VendorClassName of the VendorClass
    /// VendorClassName الخاص بـ VendorClass
    /// </summary>
    public string VendorClassName { get; private set; }

    /// <summary>
    /// VendorClassNameEnglish of the VendorClass
    /// VendorClassNameEnglish الخاص بـ VendorClass
    /// </summary>
    public string VendorClassNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

