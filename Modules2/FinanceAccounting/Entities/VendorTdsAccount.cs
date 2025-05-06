using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// VendorTdsAccount Entity
/// </summary>
public class VendorTdsAccount : Entity<VendorTdsAccountId>
{

    private VendorTdsAccount() { }

    public VendorTdsAccount(VendorTdsAccountId id, string vendorCode)
    {
        Id = id;
        VendorCode = vendorCode;
    }

    /// <summary>
    /// The unique identifier for the VendorTdsAccount
    /// المعرف الفريد لـ VendorTdsAccount
    /// </summary>
    public VendorTdsAccountId Id { get; private set; }

    /// <summary>
    /// VendorCode of the VendorTdsAccount
    /// VendorCode الخاص بـ VendorTdsAccount
    /// </summary>
    public string VendorCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

