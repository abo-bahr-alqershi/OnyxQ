using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// AccountsReceivableType Entity
/// </summary>
public class AccountsReceivableType : Entity<AccountsReceivableTypeId>
{

    private AccountsReceivableType() { }

    public AccountsReceivableType(AccountsReceivableTypeId id, decimal? arTypeNumber, decimal? typeNumberShort)
    {
        Id = id;
        ArTypeNumber = arTypeNumber;
        TypeNumberShort = typeNumberShort;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableType
    /// المعرف الفريد لـ AccountsReceivableType
    /// </summary>
    public AccountsReceivableTypeId Id { get; private set; }

    /// <summary>
    /// ArTypeNumber of the AccountsReceivableType
    /// ArTypeNumber الخاص بـ AccountsReceivableType
    /// </summary>
    public decimal? ArTypeNumber { get; private set; }

    /// <summary>
    /// TypeNumberShort of the AccountsReceivableType
    /// TypeNumberShort الخاص بـ AccountsReceivableType
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// TypeLastNameShort of the AccountsReceivableType
    /// TypeLastNameShort الخاص بـ AccountsReceivableType
    /// </summary>
    public string TypeLastNameShort { get; private set; }

    /// <summary>
    /// TypeFirstNameShort of the AccountsReceivableType
    /// TypeFirstNameShort الخاص بـ AccountsReceivableType
    /// </summary>
    public string TypeFirstNameShort { get; private set; }

    /// <summary>
    /// ArTypeSerial of the AccountsReceivableType
    /// ArTypeSerial الخاص بـ AccountsReceivableType
    /// </summary>
    public decimal? ArTypeSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
