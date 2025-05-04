using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Events
{
/// <summary>
/// Events related to StationBillCashPayment entity
/// </summary>
public sealed class StationBillCashPaymentCreatedEvent : DomainEvent
{
    public StationBillCashPaymentId StationBillCashPaymentId { get; }

    public StationBillCashPaymentCreatedEvent(StationBillCashPaymentId stationbillcashpaymentId)
    {
        StationBillCashPaymentId = stationbillcashpaymentId;
    }
}

public sealed class StationBillCashPaymentUpdatedEvent : DomainEvent
{
    public StationBillCashPaymentId StationBillCashPaymentId { get; }

    public StationBillCashPaymentUpdatedEvent(StationBillCashPaymentId stationbillcashpaymentId)
    {
        StationBillCashPaymentId = stationbillcashpaymentId;
    }
}

public sealed class StationBillCashPaymentDeletedEvent : DomainEvent
{
    public StationBillCashPaymentId StationBillCashPaymentId { get; }

    public StationBillCashPaymentDeletedEvent(StationBillCashPaymentId stationbillcashpaymentId)
    {
        StationBillCashPaymentId = stationbillcashpaymentId;
    }
}
}
