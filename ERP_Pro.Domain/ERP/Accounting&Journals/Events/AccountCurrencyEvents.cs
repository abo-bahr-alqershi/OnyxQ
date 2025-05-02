using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record AccountCurrencyCreatedEvent : IDomainEvent
    {
        public AccountCurrency AccountCurrency { get; }
        public DateTime OccurredOn { get; }

        public AccountCurrencyCreatedEvent(AccountCurrency accountCurrency)
        {
            AccountCurrency = accountCurrency;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record AccountCurrencyBalancesUpdatedEvent : IDomainEvent
    {
        public AccountCurrency AccountCurrency { get; }
        public decimal OldOpeningBalanceDebit { get; }
        public decimal OldOpeningBalanceCredit { get; }
        public decimal OldCurrentBalanceDebit { get; }
        public decimal OldCurrentBalanceCredit { get; }
        public DateTime OccurredOn { get; }

        public AccountCurrencyBalancesUpdatedEvent(
            AccountCurrency accountCurrency,
            decimal oldOpeningBalanceDebit,
            decimal oldOpeningBalanceCredit,
            decimal oldCurrentBalanceDebit,
            decimal oldCurrentBalanceCredit)
        {
            AccountCurrency = accountCurrency;
            OldOpeningBalanceDebit = oldOpeningBalanceDebit;
            OldOpeningBalanceCredit = oldOpeningBalanceCredit;
            OldCurrentBalanceDebit = oldCurrentBalanceDebit;
            OldCurrentBalanceCredit = oldCurrentBalanceCredit;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record AccountCurrencyExchangeRatesUpdatedEvent : IDomainEvent
    {
        public AccountCurrency AccountCurrency { get; }
        public decimal OldOpeningExchangeRate { get; }
        public decimal OldCurrentExchangeRate { get; }
        public DateTime OccurredOn { get; }

        public AccountCurrencyExchangeRatesUpdatedEvent(
            AccountCurrency accountCurrency,
            decimal oldOpeningExchangeRate,
            decimal oldCurrentExchangeRate)
        {
            AccountCurrency = accountCurrency;
            OldOpeningExchangeRate = oldOpeningExchangeRate;
            OldCurrentExchangeRate = oldCurrentExchangeRate;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 