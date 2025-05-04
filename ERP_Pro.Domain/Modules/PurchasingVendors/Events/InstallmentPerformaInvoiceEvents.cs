using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to InstallmentPerformaInvoice entity
/// </summary>
public sealed class InstallmentPerformaInvoiceCreatedEvent : DomainEvent
{
    public InstallmentPerformaInvoiceId InstallmentPerformaInvoiceId { get; }

    public InstallmentPerformaInvoiceCreatedEvent(InstallmentPerformaInvoiceId installmentperformainvoiceId)
    {
        InstallmentPerformaInvoiceId = installmentperformainvoiceId;
    }
}

public sealed class InstallmentPerformaInvoiceUpdatedEvent : DomainEvent
{
    public InstallmentPerformaInvoiceId InstallmentPerformaInvoiceId { get; }

    public InstallmentPerformaInvoiceUpdatedEvent(InstallmentPerformaInvoiceId installmentperformainvoiceId)
    {
        InstallmentPerformaInvoiceId = installmentperformainvoiceId;
    }
}

public sealed class InstallmentPerformaInvoiceDeletedEvent : DomainEvent
{
    public InstallmentPerformaInvoiceId InstallmentPerformaInvoiceId { get; }

    public InstallmentPerformaInvoiceDeletedEvent(InstallmentPerformaInvoiceId installmentperformainvoiceId)
    {
        InstallmentPerformaInvoiceId = installmentperformainvoiceId;
    }
}
}
