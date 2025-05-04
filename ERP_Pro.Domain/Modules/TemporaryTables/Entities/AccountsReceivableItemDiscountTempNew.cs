using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AccountsReceivableItemDiscountTempNew Entity
/// </summary>
public class AccountsReceivableItemDiscountTempNew : Entity<AccountsReceivableItemDiscountTempNewId>
{

    private AccountsReceivableItemDiscountTempNew() { }

    public AccountsReceivableItemDiscountTempNew(AccountsReceivableItemDiscountTempNewId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableItemDiscountTempNew
    /// المعرف الفريد لـ AccountsReceivableItemDiscountTempNew
    /// </summary>
    public AccountsReceivableItemDiscountTempNewId Id { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsReceivableItemDiscountTempNew
    /// ItemCode الخاص بـ AccountsReceivableItemDiscountTempNew
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// TerminalName of the AccountsReceivableItemDiscountTempNew
    /// TerminalName الخاص بـ AccountsReceivableItemDiscountTempNew
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsReceivableItemDiscountTempNew
    /// WarehouseCode الخاص بـ AccountsReceivableItemDiscountTempNew
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// FieldValueAlt of the AccountsReceivableItemDiscountTempNew
    /// FieldValueAlt الخاص بـ AccountsReceivableItemDiscountTempNew
    /// </summary>
    public string FieldValueAlt { get; private set; }

    /// <summary>
    /// FieldValue2 of the AccountsReceivableItemDiscountTempNew
    /// FieldValue2 الخاص بـ AccountsReceivableItemDiscountTempNew
    /// </summary>
    public string FieldValue2 { get; private set; }

    /// <summary>
    /// BatchNumber of the AccountsReceivableItemDiscountTempNew
    /// BatchNumber الخاص بـ AccountsReceivableItemDiscountTempNew
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// BatchCollector of the AccountsReceivableItemDiscountTempNew
    /// BatchCollector الخاص بـ AccountsReceivableItemDiscountTempNew
    /// </summary>
    public string BatchCollector { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
