using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// VendorTdsAccount Entity
/// </summary>
public class VendorTdsAccount : Entity<VendorTdsAccountId>
{
    private VendorTdsAccount() { }

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

    /// <summary>
    /// AccountCode of the VendorTdsAccount
    /// AccountCode الخاص بـ VendorTdsAccount
    /// </summary>
    public string AccountCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    #endregion
}
}
