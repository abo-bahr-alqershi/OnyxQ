using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events
{
    public class BankCheckCreatedEvent : DomainEvent
    {
        public BankCheck Check { get; }

        public BankCheckCreatedEvent(BankCheck check)
        {
            Check = check;
        }
    }

    public class BankCheckStatusUpdatedEvent : DomainEvent
    {
        public BankCheck Check { get; }
        public int OldStatus { get; }

        public BankCheckStatusUpdatedEvent(BankCheck check, int oldStatus)
        {
            Check = check;
            OldStatus = oldStatus;
        }
    }

    public class BankCheckAmountUpdatedEvent : DomainEvent
    {
        public BankCheck Check { get; }
        public decimal OldAmount { get; }
        public string? OldCurrencyCode { get; }
        public decimal OldExchangeRate { get; }

        public BankCheckAmountUpdatedEvent(BankCheck check, decimal oldAmount, string? oldCurrencyCode, decimal oldExchangeRate)
        {
            Check = check;
            OldAmount = oldAmount;
            OldCurrencyCode = oldCurrencyCode;
            OldExchangeRate = oldExchangeRate;
        }
    }

    public class BankCheckDocumentInfoUpdatedEvent : DomainEvent
    {
        public BankCheck Check { get; }

        public BankCheckDocumentInfoUpdatedEvent(BankCheck check)
        {
            Check = check;
        }
    }

    public class BankCheckEndorsementUpdatedEvent : DomainEvent
    {
        public BankCheck Check { get; }

        public BankCheckEndorsementUpdatedEvent(BankCheck check)
        {
            Check = check;
        }
    }

    public class BankCheckTaxInfoUpdatedEvent : DomainEvent
    {
        public BankCheck Check { get; }

        public BankCheckTaxInfoUpdatedEvent(BankCheck check)
        {
            Check = check;
        }
    }
} 