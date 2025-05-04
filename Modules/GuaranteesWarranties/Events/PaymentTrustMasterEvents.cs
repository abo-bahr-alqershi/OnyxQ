using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to PaymentTrustMaster entity
/// </summary>
public sealed class PaymentTrustMasterCreatedEvent : DomainEvent
{
    public PaymentTrustMasterId PaymentTrustMasterId { get; }

    public PaymentTrustMasterCreatedEvent(PaymentTrustMasterId paymenttrustmasterId)
    {
        PaymentTrustMasterId = paymenttrustmasterId;
    }
}

public sealed class PaymentTrustMasterUpdatedEvent : DomainEvent
{
    public PaymentTrustMasterId PaymentTrustMasterId { get; }

    public PaymentTrustMasterUpdatedEvent(PaymentTrustMasterId paymenttrustmasterId)
    {
        PaymentTrustMasterId = paymenttrustmasterId;
    }
}

public sealed class PaymentTrustMasterDeletedEvent : DomainEvent
{
    public PaymentTrustMasterId PaymentTrustMasterId { get; }

    public PaymentTrustMasterDeletedEvent(PaymentTrustMasterId paymenttrustmasterId)
    {
        PaymentTrustMasterId = paymenttrustmasterId;
    }
}
}
