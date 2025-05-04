using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// JournalVoucherTypeDetail Entity
/// </summary>
public class JournalVoucherTypeDetail : Entity<JournalVoucherTypeDetailId>
{

    private JournalVoucherTypeDetail() { }

    public JournalVoucherTypeDetail(JournalVoucherTypeDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the JournalVoucherTypeDetail
    /// المعرف الفريد لـ JournalVoucherTypeDetail
    /// </summary>
    public JournalVoucherTypeDetailId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the JournalVoucherTypeDetail
    /// AdditionalFlag الخاص بـ JournalVoucherTypeDetail
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the JournalVoucherTypeDetail
    /// ViewFlag الخاص بـ JournalVoucherTypeDetail
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public JournalVoucherType JournalVoucherType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
