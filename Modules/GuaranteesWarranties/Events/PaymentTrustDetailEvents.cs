using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to PaymentTrustDetail entity
/// </summary>
public sealed class PaymentTrustDetailCreatedEvent : DomainEvent
{
    public PaymentTrustDetailId PaymentTrustDetailId { get; }

    public PaymentTrustDetailCreatedEvent(PaymentTrustDetailId paymenttrustdetailId)
    {
        PaymentTrustDetailId = paymenttrustdetailId;
    }
}

public sealed class PaymentTrustDetailUpdatedEvent : DomainEvent
{
    public PaymentTrustDetailId PaymentTrustDetailId { get; }

    public PaymentTrustDetailUpdatedEvent(PaymentTrustDetailId paymenttrustdetailId)
    {
        PaymentTrustDetailId = paymenttrustdetailId;
    }
}

public sealed class PaymentTrustDetailDeletedEvent : DomainEvent
{
    public PaymentTrustDetailId PaymentTrustDetailId { get; }

    public PaymentTrustDetailDeletedEvent(PaymentTrustDetailId paymenttrustdetailId)
    {
        PaymentTrustDetailId = paymenttrustdetailId;
    }
}
}
