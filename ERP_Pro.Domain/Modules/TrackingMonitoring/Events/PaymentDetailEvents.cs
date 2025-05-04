using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to PaymentDetail entity
/// </summary>
public sealed class PaymentDetailCreatedEvent : DomainEvent
{
    public PaymentDetailId PaymentDetailId { get; }

    public PaymentDetailCreatedEvent(PaymentDetailId paymentdetailId)
    {
        PaymentDetailId = paymentdetailId;
    }
}

public sealed class PaymentDetailUpdatedEvent : DomainEvent
{
    public PaymentDetailId PaymentDetailId { get; }

    public PaymentDetailUpdatedEvent(PaymentDetailId paymentdetailId)
    {
        PaymentDetailId = paymentdetailId;
    }
}

public sealed class PaymentDetailDeletedEvent : DomainEvent
{
    public PaymentDetailId PaymentDetailId { get; }

    public PaymentDetailDeletedEvent(PaymentDetailId paymentdetailId)
    {
        PaymentDetailId = paymentdetailId;
    }
}
}
