using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects;

namespace ERP_Pro.Domain.ERP.JudicialLegal.Events
{
/// <summary>
/// Events related to LetterOfCreditMaster entity
/// </summary>
public sealed class LetterOfCreditMasterCreatedEvent : DomainEvent
{
    public LetterOfCreditMasterId LetterOfCreditMasterId { get; }

    public LetterOfCreditMasterCreatedEvent(LetterOfCreditMasterId letterofcreditmasterId)
    {
        LetterOfCreditMasterId = letterofcreditmasterId;
    }
}

public sealed class LetterOfCreditMasterUpdatedEvent : DomainEvent
{
    public LetterOfCreditMasterId LetterOfCreditMasterId { get; }

    public LetterOfCreditMasterUpdatedEvent(LetterOfCreditMasterId letterofcreditmasterId)
    {
        LetterOfCreditMasterId = letterofcreditmasterId;
    }
}

public sealed class LetterOfCreditMasterDeletedEvent : DomainEvent
{
    public LetterOfCreditMasterId LetterOfCreditMasterId { get; }

    public LetterOfCreditMasterDeletedEvent(LetterOfCreditMasterId letterofcreditmasterId)
    {
        LetterOfCreditMasterId = letterofcreditmasterId;
    }
}
}
