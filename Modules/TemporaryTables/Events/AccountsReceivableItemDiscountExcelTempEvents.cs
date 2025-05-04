using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to AccountsReceivableItemDiscountExcelTemp entity
/// </summary>
public sealed class AccountsReceivableItemDiscountExcelTempCreatedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountExcelTempId AccountsReceivableItemDiscountExcelTempId { get; }

    public AccountsReceivableItemDiscountExcelTempCreatedEvent(AccountsReceivableItemDiscountExcelTempId accountsreceivableitemdiscountexceltempId)
    {
        AccountsReceivableItemDiscountExcelTempId = accountsreceivableitemdiscountexceltempId;
    }
}

public sealed class AccountsReceivableItemDiscountExcelTempUpdatedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountExcelTempId AccountsReceivableItemDiscountExcelTempId { get; }

    public AccountsReceivableItemDiscountExcelTempUpdatedEvent(AccountsReceivableItemDiscountExcelTempId accountsreceivableitemdiscountexceltempId)
    {
        AccountsReceivableItemDiscountExcelTempId = accountsreceivableitemdiscountexceltempId;
    }
}

public sealed class AccountsReceivableItemDiscountExcelTempDeletedEvent : DomainEvent
{
    public AccountsReceivableItemDiscountExcelTempId AccountsReceivableItemDiscountExcelTempId { get; }

    public AccountsReceivableItemDiscountExcelTempDeletedEvent(AccountsReceivableItemDiscountExcelTempId accountsreceivableitemdiscountexceltempId)
    {
        AccountsReceivableItemDiscountExcelTempId = accountsreceivableitemdiscountexceltempId;
    }
}
}
