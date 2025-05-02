using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record PeriodExchangeRateCreatedEvent : IDomainEvent
    {
        public PeriodExchangeRate ExchangeRate { get; }
        public DateTime OccurredOn { get; }

        public PeriodExchangeRateCreatedEvent(PeriodExchangeRate exchangeRate)
        {
            ExchangeRate = exchangeRate;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record PeriodExchangeRateUpdatedEvent : IDomainEvent
    {
        public PeriodExchangeRate ExchangeRate { get; }
        public object OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodExchangeRateUpdatedEvent(PeriodExchangeRate exchangeRate, object oldState)
        {
            ExchangeRate = exchangeRate;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record PeriodExchangeRateDatesUpdatedEvent : IDomainEvent
    {
        public PeriodExchangeRate ExchangeRate { get; }
        public object OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodExchangeRateDatesUpdatedEvent(PeriodExchangeRate exchangeRate, object oldState)
        {
            ExchangeRate = exchangeRate;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record PeriodExchangeRateApprovedEvent : IDomainEvent
    {
        public PeriodExchangeRate ExchangeRate { get; }
        public object OldState { get; }
        public DateTime OccurredOn { get; }

        public PeriodExchangeRateApprovedEvent(PeriodExchangeRate exchangeRate, object oldState)
        {
            ExchangeRate = exchangeRate;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record PeriodExchangeRateActivatedEvent : IDomainEvent
    {
        public PeriodExchangeRate ExchangeRate { get; }
        public DateTime OccurredOn { get; }

        public PeriodExchangeRateActivatedEvent(PeriodExchangeRate exchangeRate)
        {
            ExchangeRate = exchangeRate;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record PeriodExchangeRateDeactivatedEvent : IDomainEvent
    {
        public PeriodExchangeRate ExchangeRate { get; }
        public DateTime OccurredOn { get; }

        public PeriodExchangeRateDeactivatedEvent(PeriodExchangeRate exchangeRate)
        {
            ExchangeRate = exchangeRate;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 