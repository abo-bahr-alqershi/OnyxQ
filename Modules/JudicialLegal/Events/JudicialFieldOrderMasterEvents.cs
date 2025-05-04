using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.JudicialLegal.Events
{
/// <summary>
/// Events related to JudicialFieldOrderMaster entity
/// </summary>
public sealed class JudicialFieldOrderMasterCreatedEvent : DomainEvent
{
    public JudicialFieldOrderMasterId JudicialFieldOrderMasterId { get; }

    public JudicialFieldOrderMasterCreatedEvent(JudicialFieldOrderMasterId judicialfieldordermasterId)
    {
        JudicialFieldOrderMasterId = judicialfieldordermasterId;
    }
}

public sealed class JudicialFieldOrderMasterUpdatedEvent : DomainEvent
{
    public JudicialFieldOrderMasterId JudicialFieldOrderMasterId { get; }

    public JudicialFieldOrderMasterUpdatedEvent(JudicialFieldOrderMasterId judicialfieldordermasterId)
    {
        JudicialFieldOrderMasterId = judicialfieldordermasterId;
    }
}

public sealed class JudicialFieldOrderMasterDeletedEvent : DomainEvent
{
    public JudicialFieldOrderMasterId JudicialFieldOrderMasterId { get; }

    public JudicialFieldOrderMasterDeletedEvent(JudicialFieldOrderMasterId judicialfieldordermasterId)
    {
        JudicialFieldOrderMasterId = judicialfieldordermasterId;
    }
}
}
