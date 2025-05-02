using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record AccountGroupingCreatedEvent : IDomainEvent
    {
        public AccountGrouping AccountGrouping { get; }
        public DateTime OccurredOn { get; }

        public AccountGroupingCreatedEvent(AccountGrouping accountGrouping)
        {
            AccountGrouping = accountGrouping;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record AccountGroupingInfoUpdatedEvent : IDomainEvent
    {
        public AccountGrouping AccountGrouping { get; }
        public GroupInfo OldGroupInfo { get; }
        public DateTime OccurredOn { get; }

        public AccountGroupingInfoUpdatedEvent(AccountGrouping accountGrouping, GroupInfo oldGroupInfo)
        {
            AccountGrouping = accountGrouping;
            OldGroupInfo = oldGroupInfo;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record AccountGroupingReportInfoUpdatedEvent : IDomainEvent
    {
        public AccountGrouping AccountGrouping { get; }
        public ReportInfo OldReportInfo { get; }
        public DateTime OccurredOn { get; }

        public AccountGroupingReportInfoUpdatedEvent(AccountGrouping accountGrouping, ReportInfo oldReportInfo)
        {
            AccountGrouping = accountGrouping;
            OldReportInfo = oldReportInfo;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record AccountGroupingActivatedEvent : IDomainEvent
    {
        public AccountGrouping AccountGrouping { get; }
        public DateTime OccurredOn { get; }

        public AccountGroupingActivatedEvent(AccountGrouping accountGrouping)
        {
            AccountGrouping = accountGrouping;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record AccountGroupingDeactivatedEvent : IDomainEvent
    {
        public AccountGrouping AccountGrouping { get; }
        public DateTime OccurredOn { get; }

        public AccountGroupingDeactivatedEvent(AccountGrouping accountGrouping)
        {
            AccountGrouping = accountGrouping;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 