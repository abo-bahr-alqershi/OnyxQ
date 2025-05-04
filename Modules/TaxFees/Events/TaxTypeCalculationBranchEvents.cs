using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxTypeCalculationBranch entity
/// </summary>
public sealed class TaxTypeCalculationBranchCreatedEvent : DomainEvent
{
    public TaxTypeCalculationBranchId TaxTypeCalculationBranchId { get; }

    public TaxTypeCalculationBranchCreatedEvent(TaxTypeCalculationBranchId taxtypecalculationbranchId)
    {
        TaxTypeCalculationBranchId = taxtypecalculationbranchId;
    }
}

public sealed class TaxTypeCalculationBranchUpdatedEvent : DomainEvent
{
    public TaxTypeCalculationBranchId TaxTypeCalculationBranchId { get; }

    public TaxTypeCalculationBranchUpdatedEvent(TaxTypeCalculationBranchId taxtypecalculationbranchId)
    {
        TaxTypeCalculationBranchId = taxtypecalculationbranchId;
    }
}

public sealed class TaxTypeCalculationBranchDeletedEvent : DomainEvent
{
    public TaxTypeCalculationBranchId TaxTypeCalculationBranchId { get; }

    public TaxTypeCalculationBranchDeletedEvent(TaxTypeCalculationBranchId taxtypecalculationbranchId)
    {
        TaxTypeCalculationBranchId = taxtypecalculationbranchId;
    }
}
}
