using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApprovalAppDevice entity
/// </summary>
public sealed class ApprovalAppDeviceCreatedEvent : DomainEvent
{
    public ApprovalAppDeviceId ApprovalAppDeviceId { get; }

    public ApprovalAppDeviceCreatedEvent(ApprovalAppDeviceId approvalappdeviceId)
    {
        ApprovalAppDeviceId = approvalappdeviceId;
    }
}

public sealed class ApprovalAppDeviceUpdatedEvent : DomainEvent
{
    public ApprovalAppDeviceId ApprovalAppDeviceId { get; }

    public ApprovalAppDeviceUpdatedEvent(ApprovalAppDeviceId approvalappdeviceId)
    {
        ApprovalAppDeviceId = approvalappdeviceId;
    }
}

public sealed class ApprovalAppDeviceDeletedEvent : DomainEvent
{
    public ApprovalAppDeviceId ApprovalAppDeviceId { get; }

    public ApprovalAppDeviceDeletedEvent(ApprovalAppDeviceId approvalappdeviceId)
    {
        ApprovalAppDeviceId = approvalappdeviceId;
    }
}
}
