using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record AccountTypeCreatedEvent : IDomainEvent
    {
        public AccountType AccountType { get; }
        public DateTime OccurredOn { get; }

        public AccountTypeCreatedEvent(AccountType accountType)
        {
            AccountType = accountType;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record AccountTypeUpdatedEvent : IDomainEvent
    {
        public AccountType AccountType { get; }
        public object OldState { get; }
        public DateTime OccurredOn { get; }

        public AccountTypeUpdatedEvent(AccountType accountType, object oldState)
        {
            AccountType = accountType;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 