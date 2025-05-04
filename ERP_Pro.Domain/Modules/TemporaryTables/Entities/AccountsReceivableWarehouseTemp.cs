using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AccountsReceivableWarehouseTemp Entity
/// </summary>
public class AccountsReceivableWarehouseTemp : Entity<AccountsReceivableWarehouseTempId>
{

    private AccountsReceivableWarehouseTemp() { }

    public AccountsReceivableWarehouseTemp(AccountsReceivableWarehouseTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableWarehouseTemp
    /// المعرف الفريد لـ AccountsReceivableWarehouseTemp
    /// </summary>
    public AccountsReceivableWarehouseTempId Id { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsReceivableWarehouseTemp
    /// WarehouseCode الخاص بـ AccountsReceivableWarehouseTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// MainWarehouseCode of the AccountsReceivableWarehouseTemp
    /// MainWarehouseCode الخاص بـ AccountsReceivableWarehouseTemp
    /// </summary>
    public decimal? MainWarehouseCode { get; private set; }

    /// <summary>
    /// TerminalName of the AccountsReceivableWarehouseTemp
    /// TerminalName الخاص بـ AccountsReceivableWarehouseTemp
    /// </summary>
    public string TerminalName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
