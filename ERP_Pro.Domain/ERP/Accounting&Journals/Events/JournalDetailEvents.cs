using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record JournalDetailCreatedEvent : IDomainEvent
    {
        public JournalDetail Detail { get; }
        public DateTime OccurredOn { get; }

        public JournalDetailCreatedEvent(JournalDetail detail)
        {
            Detail = detail;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalDetailAmountsUpdatedEvent : IDomainEvent
    {
        public JournalDetail Detail { get; }
        public Money OldDebitAmount { get; }
        public Money OldCreditAmount { get; }
        public ExchangeRate OldExchangeRate { get; }
        public DateTime OccurredOn { get; }

        public JournalDetailAmountsUpdatedEvent(
            JournalDetail detail,
            Money oldDebitAmount,
            Money oldCreditAmount,
            ExchangeRate oldExchangeRate)
        {
            Detail = detail;
            OldDebitAmount = oldDebitAmount;
            OldCreditAmount = oldCreditAmount;
            OldExchangeRate = oldExchangeRate;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalDetailReferencesUpdatedEvent : IDomainEvent
    {
        public JournalDetail Detail { get; }
        public string OldCostCenterCode { get; }
        public string OldProjectCode { get; }
        public string OldActivityCode { get; }
        public string OldVendorCode { get; }
        public string OldCustomerCode { get; }
        public string OldEmployeeCode { get; }
        public DateTime OccurredOn { get; }

        public JournalDetailReferencesUpdatedEvent(
            JournalDetail detail,
            string oldCostCenterCode,
            string oldProjectCode,
            string oldActivityCode,
            string oldVendorCode,
            string oldCustomerCode,
            string oldEmployeeCode)
        {
            Detail = detail;
            OldCostCenterCode = oldCostCenterCode;
            OldProjectCode = oldProjectCode;
            OldActivityCode = oldActivityCode;
            OldVendorCode = oldVendorCode;
            OldCustomerCode = oldCustomerCode;
            OldEmployeeCode = oldEmployeeCode;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalDetailDescriptionUpdatedEvent : IDomainEvent
    {
        public JournalDetail Detail { get; }
        public string OldDescription { get; }
        public DateTime OccurredOn { get; }

        public JournalDetailDescriptionUpdatedEvent(JournalDetail detail, string oldDescription)
        {
            Detail = detail;
            OldDescription = oldDescription;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 