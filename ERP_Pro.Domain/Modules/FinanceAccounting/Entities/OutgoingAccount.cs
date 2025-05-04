using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// OutgoingAccount Entity
/// </summary>
public class OutgoingAccount : Entity<OutgoingAccountId>
{

    private OutgoingAccount() { }

    public OutgoingAccount(OutgoingAccountId id, decimal? outgoingTypeFull)
    {
        Id = id;
        OutgoingTypeFull = outgoingTypeFull;
    }

    /// <summary>
    /// The unique identifier for the OutgoingAccount
    /// المعرف الفريد لـ OutgoingAccount
    /// </summary>
    public OutgoingAccountId Id { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the OutgoingAccount
    /// OutgoingTypeFull الخاص بـ OutgoingAccount
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// ManagerCode of the OutgoingAccount
    /// ManagerCode الخاص بـ OutgoingAccount
    /// </summary>
    public string ManagerCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public WarehouseGroup WarehouseGroup { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
