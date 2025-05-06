using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects;

namespace ERP_Pro.Domain.ERP.JudicialLegal.Events
{
/// <summary>
/// Events related to LetterOfCreditDetail entity
/// </summary>
public sealed class LetterOfCreditDetailCreatedEvent : DomainEvent
{
    public LetterOfCreditDetailId LetterOfCreditDetailId { get; }

    public LetterOfCreditDetailCreatedEvent(LetterOfCreditDetailId letterofcreditdetailId)
    {
        LetterOfCreditDetailId = letterofcreditdetailId;
    }
}

public sealed class LetterOfCreditDetailUpdatedEvent : DomainEvent
{
    public LetterOfCreditDetailId LetterOfCreditDetailId { get; }

    public LetterOfCreditDetailUpdatedEvent(LetterOfCreditDetailId letterofcreditdetailId)
    {
        LetterOfCreditDetailId = letterofcreditdetailId;
    }
}

public sealed class LetterOfCreditDetailDeletedEvent : DomainEvent
{
    public LetterOfCreditDetailId LetterOfCreditDetailId { get; }

    public LetterOfCreditDetailDeletedEvent(LetterOfCreditDetailId letterofcreditdetailId)
    {
        LetterOfCreditDetailId = letterofcreditdetailId;
    }
}
}
