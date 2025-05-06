using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;
namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxCodeDetail Entity
/// </summary>
public class TaxCodeDetail : Entity<TaxCodeDetailId>
{
    private readonly List<Account> _account = new List<Account>();
    private readonly List<Account> _accountAcCodeAp = new List<Account>();
    private readonly List<TaxCodeMaster> _taxCodeMaster = new List<TaxCodeMaster>();

    private TaxCodeDetail() { }

    public TaxCodeDetail(TaxCodeDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TaxCodeDetail
    /// المعرف الفريد لـ TaxCodeDetail
    /// </summary>
    public TaxCodeDetailId Id { get; private set; }

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
    /// TaxPercent of the TaxCodeDetail
    /// TaxPercent الخاص بـ TaxCodeDetail
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Account> Account => _account;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Account> AccountAcCodeAp => _accountAcCodeAp;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<TaxCodeMaster> TaxCodeMaster => _taxCodeMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

