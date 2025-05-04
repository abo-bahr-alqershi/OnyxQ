using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to GuaranteeAccount entity
/// </summary>
public sealed class GuaranteeAccountCreatedEvent : DomainEvent
{
    public GuaranteeAccountId GuaranteeAccountId { get; }

    public GuaranteeAccountCreatedEvent(GuaranteeAccountId guaranteeaccountId)
    {
        GuaranteeAccountId = guaranteeaccountId;
    }
}

public sealed class GuaranteeAccountUpdatedEvent : DomainEvent
{
    public GuaranteeAccountId GuaranteeAccountId { get; }

    public GuaranteeAccountUpdatedEvent(GuaranteeAccountId guaranteeaccountId)
    {
        GuaranteeAccountId = guaranteeaccountId;
    }
}

public sealed class GuaranteeAccountDeletedEvent : DomainEvent
{
    public GuaranteeAccountId GuaranteeAccountId { get; }

    public GuaranteeAccountDeletedEvent(GuaranteeAccountId guaranteeaccountId)
    {
        GuaranteeAccountId = guaranteeaccountId;
    }
}
}
