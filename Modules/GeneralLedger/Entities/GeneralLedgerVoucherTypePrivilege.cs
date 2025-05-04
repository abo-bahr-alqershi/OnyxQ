using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerVoucherTypePrivilege Entity
/// </summary>
public class GeneralLedgerVoucherTypePrivilege : Entity<GeneralLedgerVoucherTypePrivilegeId>
{
    private GeneralLedgerVoucherTypePrivilege() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerVoucherTypePrivilege
    /// المعرف الفريد لـ GeneralLedgerVoucherTypePrivilege
    /// </summary>
    public GeneralLedgerVoucherTypePrivilegeId Id { get; private set; }

    /// <summary>
    /// VendorTypeShort of the GeneralLedgerVoucherTypePrivilege
    /// VendorTypeShort الخاص بـ GeneralLedgerVoucherTypePrivilege
    /// </summary>
    public decimal? VendorTypeShort { get; private set; }

    /// <summary>
    /// VendorTypeNumberShort of the GeneralLedgerVoucherTypePrivilege
    /// VendorTypeNumberShort الخاص بـ GeneralLedgerVoucherTypePrivilege
    /// </summary>
    public decimal? VendorTypeNumberShort { get; private set; }

    /// <summary>
    /// UserId of the GeneralLedgerVoucherTypePrivilege
    /// UserId الخاص بـ GeneralLedgerVoucherTypePrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AdditionalFlag of the GeneralLedgerVoucherTypePrivilege
    /// AdditionalFlag الخاص بـ GeneralLedgerVoucherTypePrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the GeneralLedgerVoucherTypePrivilege
    /// ViewFlag الخاص بـ GeneralLedgerVoucherTypePrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to VoucherType
    /// </summary>
    public VoucherType VoucherType { get; private set; }
    #endregion
}
}
