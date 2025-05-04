using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AccountReportType entity
/// </summary>
public sealed class AccountReportTypeCreatedEvent : DomainEvent
{
    public AccountReportTypeId AccountReportTypeId { get; }

    public AccountReportTypeCreatedEvent(AccountReportTypeId accountreporttypeId)
    {
        AccountReportTypeId = accountreporttypeId;
    }
}

public sealed class AccountReportTypeUpdatedEvent : DomainEvent
{
    public AccountReportTypeId AccountReportTypeId { get; }

    public AccountReportTypeUpdatedEvent(AccountReportTypeId accountreporttypeId)
    {
        AccountReportTypeId = accountreporttypeId;
    }
}

public sealed class AccountReportTypeDeletedEvent : DomainEvent
{
    public AccountReportTypeId AccountReportTypeId { get; }

    public AccountReportTypeDeletedEvent(AccountReportTypeId accountreporttypeId)
    {
        AccountReportTypeId = accountreporttypeId;
    }
}
}
