using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AccountsReceivableItemDiscountExcelTemp Entity
/// </summary>
public class AccountsReceivableItemDiscountExcelTemp : Entity<AccountsReceivableItemDiscountExcelTempId>
{
    private AccountsReceivableItemDiscountExcelTemp() { }

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
}
}
