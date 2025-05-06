using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AccountsReceivableItemDiscountExcelTemp Entity
/// </summary>
public class AccountsReceivableItemDiscountExcelTemp : Entity<AccountsReceivableItemDiscountExcelTempId>
{

    private AccountsReceivableItemDiscountExcelTemp() { }

    public AccountsReceivableItemDiscountExcelTemp(AccountsReceivableItemDiscountExcelTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableItemDiscountExcelTemp
    /// المعرف الفريد لـ AccountsReceivableItemDiscountExcelTemp
    /// </summary>
    public AccountsReceivableItemDiscountExcelTempId Id { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsReceivableItemDiscountExcelTemp
    /// ItemCode الخاص بـ AccountsReceivableItemDiscountExcelTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// TerminalName of the AccountsReceivableItemDiscountExcelTemp
    /// TerminalName الخاص بـ AccountsReceivableItemDiscountExcelTemp
    /// </summary>
    public string TerminalName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

