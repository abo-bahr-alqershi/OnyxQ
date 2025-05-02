using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events
{
    public class BankAdjustmentCreatedEvent : DomainEvent
    {
        public BankAdjustment Adjustment { get; }

        public BankAdjustmentCreatedEvent(BankAdjustment adjustment)
        {
            Adjustment = adjustment;
        }
    }

    public class BankAdjustmentAmountUpdatedEvent : DomainEvent
    {
        public BankAdjustment Adjustment { get; }
        public decimal OldAmount { get; }
        public string? OldCurrencyCode { get; }
        public decimal OldExchangeRate { get; }

        public BankAdjustmentAmountUpdatedEvent(
            BankAdjustment adjustment,
            decimal oldAmount,
            string? oldCurrencyCode,
            decimal oldExchangeRate)
        {
            Adjustment = adjustment;
            OldAmount = oldAmount;
            OldCurrencyCode = oldCurrencyCode;
            OldExchangeRate = oldExchangeRate;
        }
    }

    public class BankAdjustmentDocumentInfoUpdatedEvent : DomainEvent
    {
        public BankAdjustment Adjustment { get; }

        public BankAdjustmentDocumentInfoUpdatedEvent(BankAdjustment adjustment)
        {
            Adjustment = adjustment;
        }
    }

    public class BankAdjustmentPostedEvent : DomainEvent
    {
        public BankAdjustment Adjustment { get; }

        public BankAdjustmentPostedEvent(BankAdjustment adjustment)
        {
            Adjustment = adjustment;
        }
    }

    public class BankAdjustmentUnpostedEvent : DomainEvent
    {
        public BankAdjustment Adjustment { get; }

        public BankAdjustmentUnpostedEvent(BankAdjustment adjustment)
        {
            Adjustment = adjustment;
        }
    }

    public class BankAdjustmentTaxInfoUpdatedEvent : DomainEvent
    {
        public BankAdjustment Adjustment { get; }

        public BankAdjustmentTaxInfoUpdatedEvent(BankAdjustment adjustment)
        {
            Adjustment = adjustment;
        }
    }
} 