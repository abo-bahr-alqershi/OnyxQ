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
    /// GuarantorCode of the OutgoingAccount
    /// GuarantorCode الخاص بـ OutgoingAccount
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the OutgoingAccount
    /// WarehouseGroupCode الخاص بـ OutgoingAccount
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// AccountCode of the OutgoingAccount
    /// AccountCode الخاص بـ OutgoingAccount
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// ManagerCode of the OutgoingAccount
    /// ManagerCode الخاص بـ OutgoingAccount
    /// </summary>
    public string ManagerCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to WarehouseGroup
    /// </summary>
    public WarehouseGroup WarehouseGroup { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion
}
}
