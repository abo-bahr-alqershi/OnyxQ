using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableType Entity
/// </summary>
public class AccountsPayableType : Entity<AccountsPayableTypeId>
{
    private AccountsPayableType() { }

    /// <summary>
    /// The unique identifier for the AccountsPayableType
    /// المعرف الفريد لـ AccountsPayableType
    /// </summary>
    public AccountsPayableTypeId Id { get; private set; }

    /// <summary>
    /// TypeNumberShort of the AccountsPayableType
    /// TypeNumberShort الخاص بـ AccountsPayableType
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// TypeLastNameFull of the AccountsPayableType
    /// TypeLastNameFull الخاص بـ AccountsPayableType
    /// </summary>
    public string TypeLastNameFull { get; private set; }

    /// <summary>
    /// TypeFirstNameFull of the AccountsPayableType
    /// TypeFirstNameFull الخاص بـ AccountsPayableType
    /// </summary>
    public string TypeFirstNameFull { get; private set; }

    /// <summary>
    /// AccountsPayableTypeNumber of the AccountsPayableType
    /// AccountsPayableTypeNumber الخاص بـ AccountsPayableType
    /// </summary>
    public decimal? AccountsPayableTypeNumber { get; private set; }

    /// <summary>
    /// AccountsPayableTypeSerial of the AccountsPayableType
    /// AccountsPayableTypeSerial الخاص بـ AccountsPayableType
    /// </summary>
    public decimal? AccountsPayableTypeSerial { get; private set; }
}
}
