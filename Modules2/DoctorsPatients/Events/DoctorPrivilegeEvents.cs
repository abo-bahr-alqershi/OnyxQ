using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.DoctorsPatients.ValueObjects;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.Events
{
/// <summary>
/// Events related to DoctorPrivilege entity
/// </summary>
public sealed class DoctorPrivilegeCreatedEvent : DomainEvent
{
    public DoctorPrivilegeId DoctorPrivilegeId { get; }

    public DoctorPrivilegeCreatedEvent(DoctorPrivilegeId doctorprivilegeId)
    {
        DoctorPrivilegeId = doctorprivilegeId;
    }
}

public sealed class DoctorPrivilegeUpdatedEvent : DomainEvent
{
    public DoctorPrivilegeId DoctorPrivilegeId { get; }

    public DoctorPrivilegeUpdatedEvent(DoctorPrivilegeId doctorprivilegeId)
    {
        DoctorPrivilegeId = doctorprivilegeId;
    }
}

public sealed class DoctorPrivilegeDeletedEvent : DomainEvent
{
    public DoctorPrivilegeId DoctorPrivilegeId { get; }

    public DoctorPrivilegeDeletedEvent(DoctorPrivilegeId doctorprivilegeId)
    {
        DoctorPrivilegeId = doctorprivilegeId;
    }
}
}
