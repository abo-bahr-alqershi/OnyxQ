using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AccountsReceivableGetDiscountTemp Entity
/// </summary>
public class AccountsReceivableGetDiscountTemp : Entity<AccountsReceivableGetDiscountTempId>
{

    private AccountsReceivableGetDiscountTemp() { }

    public AccountsReceivableGetDiscountTemp(AccountsReceivableGetDiscountTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableGetDiscountTemp
    /// المعرف الفريد لـ AccountsReceivableGetDiscountTemp
    /// </summary>
    public AccountsReceivableGetDiscountTempId Id { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsReceivableGetDiscountTemp
    /// WarehouseCode الخاص بـ AccountsReceivableGetDiscountTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsReceivableGetDiscountTemp
    /// ItemCode الخاص بـ AccountsReceivableGetDiscountTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// TerminalName of the AccountsReceivableGetDiscountTemp
    /// TerminalName الخاص بـ AccountsReceivableGetDiscountTemp
    /// </summary>
    public string TerminalName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

