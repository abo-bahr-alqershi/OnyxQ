using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxCodeDetail Entity
/// </summary>
public class TaxCodeDetail : Entity<TaxCodeDetailId>
{
    private TaxCodeDetail() { }

    /// <summary>
    /// The unique identifier for the TaxCodeDetail
    /// المعرف الفريد لـ TaxCodeDetail
    /// </summary>
    public TaxCodeDetailId Id { get; private set; }

    /// <summary>
    /// TaxNumber of the TaxCodeDetail
    /// TaxNumber الخاص بـ TaxCodeDetail
    /// </summary>
    public decimal? TaxNumber { get; private set; }

    /// <summary>
    /// AgencyNumber of the TaxCodeDetail
    /// AgencyNumber الخاص بـ TaxCodeDetail
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// AgencyLastName of the TaxCodeDetail
    /// AgencyLastName الخاص بـ TaxCodeDetail
    /// </summary>
    public string AgencyLastName { get; private set; }

    /// <summary>
    /// AgencyFirstName of the TaxCodeDetail
    /// AgencyFirstName الخاص بـ TaxCodeDetail
    /// </summary>
    public string AgencyFirstName { get; private set; }

    /// <summary>
    /// AccountAccountsReceivableCode of the TaxCodeDetail
    /// AccountAccountsReceivableCode الخاص بـ TaxCodeDetail
    /// </summary>
    public string AccountAccountsReceivableCode { get; private set; }

    /// <summary>
    /// AccountAccountsPayableCode of the TaxCodeDetail
    /// AccountAccountsPayableCode الخاص بـ TaxCodeDetail
    /// </summary>
    public string AccountAccountsPayableCode { get; private set; }

    /// <summary>
    /// TaxPercent of the TaxCodeDetail
    /// TaxPercent الخاص بـ TaxCodeDetail
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to TaxCodeMaster
    /// </summary>
    public TaxCodeMaster TaxCodeMaster { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxCodeDetail to TaxInput
    /// </summary>
    public IReadOnlyCollection<TaxInput> TaxInputs { get; private set; }
    #endregion
}
}
