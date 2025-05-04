using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxTypeCalculationDetail entity
/// </summary>
public sealed class TaxTypeCalculationDetailCreatedEvent : DomainEvent
{
    public TaxTypeCalculationDetailId TaxTypeCalculationDetailId { get; }

    public TaxTypeCalculationDetailCreatedEvent(TaxTypeCalculationDetailId taxtypecalculationdetailId)
    {
        TaxTypeCalculationDetailId = taxtypecalculationdetailId;
    }
}

public sealed class TaxTypeCalculationDetailUpdatedEvent : DomainEvent
{
    public TaxTypeCalculationDetailId TaxTypeCalculationDetailId { get; }

    public TaxTypeCalculationDetailUpdatedEvent(TaxTypeCalculationDetailId taxtypecalculationdetailId)
    {
        TaxTypeCalculationDetailId = taxtypecalculationdetailId;
    }
}

public sealed class TaxTypeCalculationDetailDeletedEvent : DomainEvent
{
    public TaxTypeCalculationDetailId TaxTypeCalculationDetailId { get; }

    public TaxTypeCalculationDetailDeletedEvent(TaxTypeCalculationDetailId taxtypecalculationdetailId)
    {
        TaxTypeCalculationDetailId = taxtypecalculationdetailId;
    }
}
}
