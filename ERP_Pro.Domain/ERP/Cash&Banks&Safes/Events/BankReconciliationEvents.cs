using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events
{
    public class BankReconciliationCreatedEvent : DomainEvent
    {
        public BankReconciliation Reconciliation { get; }

        public BankReconciliationCreatedEvent(BankReconciliation reconciliation)
        {
            Reconciliation = reconciliation;
        }
    }

    public class BankReconciliationItemAddedEvent : DomainEvent
    {
        public BankReconciliation Reconciliation { get; }
        public BankReconciliationItem Item { get; }

        public BankReconciliationItemAddedEvent(BankReconciliation reconciliation, BankReconciliationItem item)
        {
            Reconciliation = reconciliation;
            Item = item;
        }
    }

    public class BankReconciliationItemRemovedEvent : DomainEvent
    {
        public BankReconciliation Reconciliation { get; }
        public BankReconciliationItem Item { get; }

        public BankReconciliationItemRemovedEvent(BankReconciliation reconciliation, BankReconciliationItem item)
        {
            Reconciliation = reconciliation;
            Item = item;
        }
    }

    public class BankReconciliationBalancesUpdatedEvent : DomainEvent
    {
        public BankReconciliation Reconciliation { get; }
        public decimal OldBankBalance { get; }
        public decimal OldSystemBalance { get; }

        public BankReconciliationBalancesUpdatedEvent(
            BankReconciliation reconciliation,
            decimal oldBankBalance,
            decimal oldSystemBalance)
        {
            Reconciliation = reconciliation;
            OldBankBalance = oldBankBalance;
            OldSystemBalance = oldSystemBalance;
        }
    }

    public class BankReconciliationDocumentInfoUpdatedEvent : DomainEvent
    {
        public BankReconciliation Reconciliation { get; }

        public BankReconciliationDocumentInfoUpdatedEvent(BankReconciliation reconciliation)
        {
            Reconciliation = reconciliation;
        }
    }

    public class BankReconciliationPostedEvent : DomainEvent
    {
        public BankReconciliation Reconciliation { get; }

        public BankReconciliationPostedEvent(BankReconciliation reconciliation)
        {
            Reconciliation = reconciliation;
        }
    }

    public class BankReconciliationUnpostedEvent : DomainEvent
    {
        public BankReconciliation Reconciliation { get; }

        public BankReconciliationUnpostedEvent(BankReconciliation reconciliation)
        {
            Reconciliation = reconciliation;
        }
    }
} 