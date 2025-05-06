using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxTypeCalculationMaster entity
/// </summary>
public sealed class TaxTypeCalculationMasterCreatedEvent : DomainEvent
{
    public TaxTypeCalculationMasterId TaxTypeCalculationMasterId { get; }

    public TaxTypeCalculationMasterCreatedEvent(TaxTypeCalculationMasterId taxtypecalculationmasterId)
    {
        TaxTypeCalculationMasterId = taxtypecalculationmasterId;
    }
}

public sealed class TaxTypeCalculationMasterUpdatedEvent : DomainEvent
{
    public TaxTypeCalculationMasterId TaxTypeCalculationMasterId { get; }

    public TaxTypeCalculationMasterUpdatedEvent(TaxTypeCalculationMasterId taxtypecalculationmasterId)
    {
        TaxTypeCalculationMasterId = taxtypecalculationmasterId;
    }
}

public sealed class TaxTypeCalculationMasterDeletedEvent : DomainEvent
{
    public TaxTypeCalculationMasterId TaxTypeCalculationMasterId { get; }

    public TaxTypeCalculationMasterDeletedEvent(TaxTypeCalculationMasterId taxtypecalculationmasterId)
    {
        TaxTypeCalculationMasterId = taxtypecalculationmasterId;
    }
}
}
