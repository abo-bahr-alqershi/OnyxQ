using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AccountsReceivableItemDiscountTemp Entity
/// </summary>
public class AccountsReceivableItemDiscountTemp : Entity<AccountsReceivableItemDiscountTempId>
{
    private AccountsReceivableItemDiscountTemp() { }

    /// <summary>
    /// The unique identifier for the AccountsReceivableItemDiscountTemp
    /// المعرف الفريد لـ AccountsReceivableItemDiscountTemp
    /// </summary>
    public AccountsReceivableItemDiscountTempId Id { get; private set; }

    /// <summary>
    /// FieldCode of the AccountsReceivableItemDiscountTemp
    /// FieldCode الخاص بـ AccountsReceivableItemDiscountTemp
    /// </summary>
    public string FieldCode { get; private set; }

    /// <summary>
    /// FieldCode2 of the AccountsReceivableItemDiscountTemp
    /// FieldCode2 الخاص بـ AccountsReceivableItemDiscountTemp
    /// </summary>
    public string FieldCode2 { get; private set; }

    /// <summary>
    /// FieldName of the AccountsReceivableItemDiscountTemp
    /// FieldName الخاص بـ AccountsReceivableItemDiscountTemp
    /// </summary>
    public string FieldName { get; private set; }

    /// <summary>
    /// TerminalName of the AccountsReceivableItemDiscountTemp
    /// TerminalName الخاص بـ AccountsReceivableItemDiscountTemp
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsReceivableItemDiscountTemp
    /// WarehouseCode الخاص بـ AccountsReceivableItemDiscountTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the AccountsReceivableItemDiscountTemp
    /// BatchNumber الخاص بـ AccountsReceivableItemDiscountTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// GroupLevel of the AccountsReceivableItemDiscountTemp
    /// GroupLevel الخاص بـ AccountsReceivableItemDiscountTemp
    /// </summary>
    public decimal? GroupLevel { get; private set; }
}
}
