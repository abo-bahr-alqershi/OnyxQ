using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to Signature entity
/// </summary>
public sealed class SignatureCreatedEvent : DomainEvent
{
    public SignatureId SignatureId { get; }

    public SignatureCreatedEvent(SignatureId signatureId)
    {
        SignatureId = signatureId;
    }
}

public sealed class SignatureUpdatedEvent : DomainEvent
{
    public SignatureId SignatureId { get; }

    public SignatureUpdatedEvent(SignatureId signatureId)
    {
        SignatureId = signatureId;
    }
}

public sealed class SignatureDeletedEvent : DomainEvent
{
    public SignatureId SignatureId { get; }

    public SignatureDeletedEvent(SignatureId signatureId)
    {
        SignatureId = signatureId;
    }
}
}
